namespace GoodPointManageProgram
{
    partial class frmSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.chkMonth = new System.Windows.Forms.CheckBox();
            this.dtpPoint = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.chkCheck = new System.Windows.Forms.CheckBox();
            this.chkCheck2 = new System.Windows.Forms.CheckBox();
            this.gb2 = new System.Windows.Forms.GroupBox();
            this.chkMonth2 = new System.Windows.Forms.CheckBox();
            this.dtpExcel = new System.Windows.Forms.DateTimePicker();
            this.lblDate2 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            this.gb2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.chkMonth);
            this.gb1.Controls.Add(this.dtpPoint);
            this.gb1.Controls.Add(this.lblDate);
            this.gb1.Enabled = false;
            this.gb1.Location = new System.Drawing.Point(12, 61);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(437, 125);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            this.gb1.Text = "지정 날짜에 포인트 초기화";
            // 
            // chkMonth
            // 
            this.chkMonth.AutoSize = true;
            this.chkMonth.Location = new System.Drawing.Point(23, 84);
            this.chkMonth.Name = "chkMonth";
            this.chkMonth.Size = new System.Drawing.Size(154, 22);
            this.chkMonth.TabIndex = 2;
            this.chkMonth.Text = "매 달 실행하기";
            this.chkMonth.UseVisualStyleBackColor = true;
            // 
            // dtpPoint
            // 
            this.dtpPoint.Location = new System.Drawing.Point(124, 36);
            this.dtpPoint.Name = "dtpPoint";
            this.dtpPoint.Size = new System.Drawing.Size(292, 28);
            this.dtpPoint.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(20, 42);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(98, 18);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "날짜 선택 :";
            // 
            // chkCheck
            // 
            this.chkCheck.AutoSize = true;
            this.chkCheck.Location = new System.Drawing.Point(22, 19);
            this.chkCheck.Name = "chkCheck";
            this.chkCheck.Size = new System.Drawing.Size(148, 22);
            this.chkCheck.TabIndex = 4;
            this.chkCheck.Text = "비활성화 상태";
            this.chkCheck.UseVisualStyleBackColor = true;
            this.chkCheck.CheckedChanged += new System.EventHandler(this.chkCheck_CheckedChanged);
            // 
            // chkCheck2
            // 
            this.chkCheck2.AutoSize = true;
            this.chkCheck2.Location = new System.Drawing.Point(22, 204);
            this.chkCheck2.Name = "chkCheck2";
            this.chkCheck2.Size = new System.Drawing.Size(148, 22);
            this.chkCheck2.TabIndex = 6;
            this.chkCheck2.Text = "비활성화 상태";
            this.chkCheck2.UseVisualStyleBackColor = true;
            // 
            // gb2
            // 
            this.gb2.Controls.Add(this.chkMonth2);
            this.gb2.Controls.Add(this.dtpExcel);
            this.gb2.Controls.Add(this.lblDate2);
            this.gb2.Enabled = false;
            this.gb2.Location = new System.Drawing.Point(12, 246);
            this.gb2.Name = "gb2";
            this.gb2.Size = new System.Drawing.Size(437, 125);
            this.gb2.TabIndex = 5;
            this.gb2.TabStop = false;
            this.gb2.Text = "지정 날짜에 엑셀 추출";
            // 
            // chkMonth2
            // 
            this.chkMonth2.AutoSize = true;
            this.chkMonth2.Location = new System.Drawing.Point(23, 84);
            this.chkMonth2.Name = "chkMonth2";
            this.chkMonth2.Size = new System.Drawing.Size(154, 22);
            this.chkMonth2.TabIndex = 2;
            this.chkMonth2.Text = "매 달 실행하기";
            this.chkMonth2.UseVisualStyleBackColor = true;
            // 
            // dtpExcel
            // 
            this.dtpExcel.Location = new System.Drawing.Point(124, 36);
            this.dtpExcel.Name = "dtpExcel";
            this.dtpExcel.Size = new System.Drawing.Size(292, 28);
            this.dtpExcel.TabIndex = 1;
            // 
            // lblDate2
            // 
            this.lblDate2.AutoSize = true;
            this.lblDate2.Location = new System.Drawing.Point(20, 42);
            this.lblDate2.Name = "lblDate2";
            this.lblDate2.Size = new System.Drawing.Size(98, 18);
            this.lblDate2.TabIndex = 0;
            this.lblDate2.Text = "날짜 선택 :";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(12, 386);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(437, 49);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "적용하기";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 446);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.chkCheck2);
            this.Controls.Add(this.gb2);
            this.Controls.Add(this.chkCheck);
            this.Controls.Add(this.gb1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "설정";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.gb2.ResumeLayout(false);
            this.gb2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.CheckBox chkMonth;
        private System.Windows.Forms.DateTimePicker dtpPoint;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.CheckBox chkCheck;
        private System.Windows.Forms.CheckBox chkCheck2;
        private System.Windows.Forms.GroupBox gb2;
        private System.Windows.Forms.CheckBox chkMonth2;
        private System.Windows.Forms.DateTimePicker dtpExcel;
        private System.Windows.Forms.Label lblDate2;
        private System.Windows.Forms.Button btnApply;
    }
}