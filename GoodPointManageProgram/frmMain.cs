using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading;

namespace GoodPointManageProgram
{
    public partial class frmMain : Form
    {
        /* 추가 / 편집 구분 */
        public const byte ADDMODE = 1;
        public const byte EDITMODE = 2;

        /* 프로그램 제목 및 상태 */
        public const string TITLE = "선행포인트 관리 프로그램";
        public const string LOADINGEXCEL = "엑셀 파일 불러오는중....";
        public const string SAVINGEXCEL = "엑셀 파일 작성중....";

        /* 엑셀 저장 파일 이름 ( 확장자 포함 ) */
        public const string excelDataName = "Data.xls";

        /* 데이터 로딩 중 타입 */
        public const byte ROWADD = 0;
        public const byte DATAADD = 1;

        public frmMain()
        {
            InitializeComponent();
        }

        private String getNowTime()
        {
            return String.Format("{0:yyyy년 MM월 dd일 HH시 mm분 ss초}", DateTime.Now);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(LoadExcel)).Start();
            
        }

        private delegate void LoadExcelCallBack(string title, bool boool);
        private void updateForm(string title, bool boool)
        {
            Text = title;
            Enabled = boool;
        }

        private void LoadExcel()
        {
            this.Invoke(new LoadExcelCallBack(updateForm), new object[] { TITLE + " - " + LOADINGEXCEL, false });

            /* 엑셀로부터 데이터 불러오기!  */
            if (!LoadDataFromExcel())
            {
                this.Invoke(new LoadExcelCallBack(updateForm), new object[] { TITLE + " - " + SAVINGEXCEL, false });
                CreateNewExcel();   /* 엑셀파일이 없으면, 또는 지정한 양식이 아니면 기본 엑셀 파일을 생성한다. */
            }

            this.Invoke(new LoadExcelCallBack(updateForm), new object[] { TITLE, true });
        }

        private delegate void EditCellinLoading(byte type, int row, int col, String str);
        private void updateDataGridViewRow(byte type, int row, int col, String str)
        {
            switch (type)
            {
                case ROWADD:
                    dgv.Rows.Add();
                    break;
                case DATAADD:
                    dgv.Rows[row].Cells[col].Value = str;
                    break;
            }
        }

        private Boolean LoadDataFromExcel()
        {
            /* 엑셀로부터 데이터를 로드한다.
             * 
             * 파일이 존재 하지 않으면, false 반환
             * 파일이 존재하나, 지정한 양식이 아니면, false 반환
             * 성공적으로 데이터를 불러오면 true를 반환한다.
             * 
             */

            /* 데이터 엑셀 파일 존재하지 않을 시 false 반환 */
            if (!existExcelData())
                return false;

            /* 액셀 객체 생성 */
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;
            Excel.Range rg = null;

            try
            {
                String str;
                int rCnt = 0;
                int cCnt = 0;

                excelApp = new Excel.Application();
                wb = excelApp.Workbooks.Open(Application.StartupPath + "\\" + excelDataName, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                ws = (Excel.Worksheet)wb.Worksheets.get_Item(1);

                rg = ws.UsedRange;

                if (rg.Rows.Count >= 2)
                {
                    /* 기본 엑셀 파일이 아니라면, 불러온다! */
                    for (rCnt = 2; rCnt <= rg.Rows.Count; rCnt++)
                    {
                        this.Invoke(new EditCellinLoading(updateDataGridViewRow), new object[] { ROWADD, 0, 0, null });

                        for (cCnt = 1; cCnt <= rg.Columns.Count; cCnt++)
                        {
                            str = Convert.ToString((rg.Cells[rCnt, cCnt] as Excel.Range).Value2);
                            this.Invoke(new EditCellinLoading(updateDataGridViewRow), new object[] { DATAADD, rCnt - 2, cCnt - 1, str });
                        }
                    }
                }

                wb.Close(true, null, null);
                excelApp.Quit();
            }
            finally
            {
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }
            return true;
        }

        private void CreateNewExcel()
        {
            /* 새로운 엑셀 파일을 생성한다! */
            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

            try
            {
                /* Excel 첫번째 워크시트 가져오기 */
                excelApp = new Excel.Application();

                if (excelApp == null)
                {
                    MessageBox.Show("해당 컴퓨터에 엑셀이 깔려있지 않습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    return;
                }

                wb = excelApp.Workbooks.Add();
                ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;

                /* 데이터 넣기 헤더값 */
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    ws.Cells[2, i + 1] = dgv.Columns[i - 1].HeaderText;
                }

                /* 엑셀파일 저장 */
                wb.SaveAs(Application.StartupPath + @"\" + excelDataName, Excel.XlFileFormat.xlWorkbookNormal);
                wb.Close(true);
                excelApp.Quit();
            }
            finally
            {
                /* Clean Up */
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }
        }

        /* 엑셀 오브젝트를 안전하게 없애줌 */
        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void saveDataUsingExcel()
        {
            /* 현재 데이터를 엑셀로 내보낸다. */
            if (dgv.Rows.Count == 0)
            {
                /* 현재 데이터그리뷰의 있는 내용이 없으면 기본파일만 생성한다. */
                CreateNewExcel();
            }
            else
            {
                Excel.Application excelApp = null;
                Excel.Workbook wb = null;
                Excel.Worksheet ws = null;

                try
                {
                    /* Excel 첫번째 워크시트 가져오기 */
                    excelApp = new Excel.Application();

                    if (excelApp == null)
                    {
                        MessageBox.Show("해당 컴퓨터에 엑셀이 깔려있지 않습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    wb = excelApp.Workbooks.Add();
                    ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;

                    /* 데이터 넣기 헤더값 */
                    for (int i = 1; i <= dgv.Columns.Count; i++)
                    {
                        ws.Cells[2, i + 1] = dgv.Columns[i - 1].HeaderText;
                    }

                    /* 데이터 넣기 데이터그리드뷰 내용 */
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            ws.Cells[i + 3, j + 2] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    /* 엑셀파일 저장 */
                    wb.SaveAs(Application.StartupPath + @"\Data.xls", Excel.XlFileFormat.xlWorkbookNormal);
                    wb.Close(true);
                    excelApp.Quit();
                }
                finally
                {
                    /* Clean Up */
                    ReleaseExcelObject(ws);
                    ReleaseExcelObject(wb);
                    ReleaseExcelObject(excelApp);
                }
            }

            lblSaveTime.Text = "마지막 (자동)저장 시간 : " + String.Format("{0:tt HH시 mm분 ss초}", DateTime.Now);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /* 추가하기 버튼 */
            String result;

            /* 에딧폼으로 이동한다. */
            frmEdit edit = new frmEdit();
            result = edit.ShowDialog(ADDMODE);  /* 추가할 데이터를 반환해준다. */

            /* 추가할 데이터가 없으면, 함수를 종료 */
            if (result.Equals("")) 
                return;

            /* "추가할이름|추가할포인트"의 형식으로 반환한다. */
            String name, point;
            name = result.Split('|')[0];    /* 이름 파싱 */
            point = result.Split('|')[1];   /* 포인트 파싱 */

            /* 새로운 데이터를 추가한다. */
            dgv.Rows.Add((dgv.Rows.Count + 1).ToString(), name, point);

            /* 새로운 데이터를 저장한다. */
            if (existExcelData())
                delExcel();
            /* 현재 데이터그리드뷰의 있는 내용들을 엑셀로 저장한다. */
            new Thread(new ThreadStart(SaveExcel)).Start();
        }

        private void delExcel()
        {
            Directory.CreateDirectory("tmp").Create();
            File.Copy(excelDataName, "tmp/" + getNowTime() + " 엑셀파일.xls");

            File.Delete(excelDataName);   
        }

        private Boolean existExcelData()
        {
            return File.Exists("Data.xls");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            /* 설정  버튼 */
            /* 설정폼으로 이동한다. */
            frmSetting setting = new frmSetting();
            setting.ShowDialog();
        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            /* 해당 이벤트는 데이터(Row형식)가 추가될 때 발생한다. */
            /* 총 인원을 계산하여 Status 메뉴의 Label에 편집시켜준다. */
            lblCount.Text = "총 인원 : " + dgv.RowCount.ToString() + " 명";
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            /* 해당 이벤트는 데이터(Row형식)가 삭제될 때 발생한다. */
            /* 총 인원을 계산하여 Status 메뉴의 Label에 편집시켜준다. */
            lblCount.Text = "총 인원 : " + dgv.RowCount.ToString() + " 명";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /* 삭제하기 버튼 */
            /* 데이터가 하나도 없으면 함수를 종료한다. */
            if (dgv.Rows.Count == 0)
            {
                MessageBox.Show("데이터그리드뷰에 아무 데이터도 존재하지 않습니다!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* 선택된 데이터는 여러개일 수 있으므로, 리스트를 생성하여 선택된 인덱스를 관리한다! */
            List<int> selectedlistindex = new List<int>();

            /* 데이터그리드뷰의 처음부터 끝까지 루프를 돌며, 선택되었다며, 인덱스를 리스트에 추가한다! */
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                if (dgv.Rows[i].Selected == true)
                {
                    selectedlistindex.Add(i);
                }
            }

            /* 리스트의 개수가 0이면, 선택된 데이터가 없으므로 함수를 종료한다! */
            if (selectedlistindex.Count == 0)
            {
                MessageBox.Show("데이터그리드뷰를 선택하여 주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            /* 선택된 데이터들의 정보를 저장한다! */
            String data = "";

            for (int i = 0; i < selectedlistindex.Count; i++)
            {
                data += "번호 : " + (selectedlistindex[i] + 1).ToString() + "\n이름 : " + dgv.Rows[selectedlistindex[i]].Cells[1].Value.ToString() + "\n현재 포인트 : " +
                    dgv.Rows[selectedlistindex[i]].Cells[2].Value.ToString() + "\n\n";
            }

            /* 선택된 데이터들을 표시하면서, 삭제 여부를 확인한다. */
            if (MessageBox.Show("총 " + selectedlistindex.Count + " 개의 데이터를 삭제하시겠습니까?\n\n[ 데이터 정보 ]\n" + data, "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
            {
                /* 위 인덱스부터 삭제시 아래 인덱스에 영향을 끼치므로, 아래 인덱스부터 차례대로 삭제한다. */
                for (int i = selectedlistindex.Count - 1; i >= 0; i--)
                {
                    dgv.Rows.RemoveAt(selectedlistindex[i]);
                }

                /* 전체 삭제가 아니라면, 인덱스를 새로고침 해준다. */
                if (dgv.Rows.Count > 0)
                {
                    for (int i = 0; i < dgv.Rows.Count; i++)
                    {
                        dgv.Rows[i].Cells[0].Value = i + 1;
                    }
                }

                /* 새로운 데이터를 저장한다. */
                if (existExcelData())
                    delExcel();
                /* 현재 데이터그리드뷰의 있는 내용들을 엑셀로 저장한다. */
                new Thread(new ThreadStart(SaveExcel)).Start();
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            /* 실시간으로 이름 검색해줌 */
            /* 데이터가 없으면 또는 텍스트에 아무것도 없어도, 함수를 종료 */
            if (dgv.Rows.Count == 0 || txtName.Text == "")
                return;

            // (dgv.DataSource as DataTable).DefaultView.RowFilter = string.Format("[{0}] = '{1}'", "column_Name", txtName.Text);
        }

        private delegate void SaveExcelCallBack(string title, bool boool);

        private void SaveExcel()
        {
            this.Invoke(new SaveExcelCallBack(updateForm), new object[] { TITLE + " - " + SAVINGEXCEL, false });

            /* 엑셀에 데이터 씌우기  */
            saveDataUsingExcel();

            this.Invoke(new SaveExcelCallBack(updateForm), new object[] { TITLE, true });
        }


        private void btnToExcel_Click(object sender, EventArgs e)
        {
            if (existExcelData())
                delExcel();
            /* 현재 데이터그리드뷰의 있는 내용들을 엑셀로 저장한다. */
            new Thread(new ThreadStart(SaveExcel)).Start();
        }
    }
}
