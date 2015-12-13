using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GoodPointManageProgram
{
    public partial class frmEdit : Form
    {
        /* 추가/편집 모드를 구분하여 준다. */
        public const byte ADDMODE = 1;
        public const byte EDITMODE = 2;

        /* ShowDialog() 함수를 종료 할 때, Main폼에 데이터를 넘겨준다. */
        public string DATA = "";

        public frmEdit()
        {
            InitializeComponent();
        }

        public string ShowDialog(byte MODE, string data = "")
        {
            /* 추가/편집 모드에 따라서 폼을 설정한다. */
            switch (MODE)
            {
                case ADDMODE:
                    pnlPoint.Enabled = false;
                    btnControl.Text = "추가 하기";
                    btnControl.Tag = ADDMODE;
                    break;
                case EDITMODE:
                    /* data="이름|포인트" -> 엑셀에서 데이터 가져오기 */
                    pnlEdit.Enabled = false;
                    btnControl.Text = "편집 하기";
                    btnControl.Tag = EDITMODE;
                    break;
            }

            this.ShowDialog();

            /* 추가/편집 모드에 따라서 반환한다. */
            switch (MODE)
            {
                case ADDMODE:
                    return DATA;
                case EDITMODE:
                    return DATA;
            }

            return "";
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            /* 추가/편집 모드에 따라서 처리한다. */
            switch ((byte)btnControl.Tag)
            {
                case ADDMODE:
                    /* 추가 모드 */
                    if (txtName.Text.Equals(""))
                    {
                        MessageBox.Show("이름을 입력하여 주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    
                    if (txtPoint.Text.Equals(""))
                    {
                        MessageBox.Show("포인트를 입력하여 주세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (MessageBox.Show(txtName.Text + " 님을 추가하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                    {
                        DATA = txtName.Text + "|" + txtPoint.Text;
                        Close();
                    }

                    break;
                case EDITMODE:
                    /* 편집 모드 */
                    break;
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            /* 이름칸에서 엔터키를 누르면, 포인트 텍스트로 이동한다! */
            if (e.KeyCode == Keys.Enter && !txtName.Text.Equals(""))
            {
                txtPoint.Focus();
            }
        }

        private void txtPoint_KeyDown(object sender, KeyEventArgs e)
        {
            /* 포인트칸에서 엔터키를 누르면, 버튼을 눌러준다! */
            if (e.KeyCode == Keys.Enter && !txtPoint.Value.Equals(""))
            {
                btnControl_Click(null, null);
            }
        }
    }
}
