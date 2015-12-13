namespace GoodPointManageProgram
{
    partial class frmEdit
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
            this.components = new System.ComponentModel.Container();
            this.lblSplit = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.txtPoint = new System.Windows.Forms.NumericUpDown();
            this.btnControl = new System.Windows.Forms.Button();
            this.lblPoint = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlPoint = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvLog = new System.Windows.Forms.ListView();
            this.chNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPoint = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chReason = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnPut = new System.Windows.Forms.Button();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.NumericUpDown();
            this.lblGivePoint = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint)).BeginInit();
            this.pnlPoint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSplit
            // 
            this.lblSplit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSplit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplit.Location = new System.Drawing.Point(42, 175);
            this.lblSplit.Name = "lblSplit";
            this.lblSplit.Size = new System.Drawing.Size(480, 2);
            this.lblSplit.TabIndex = 4;
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.txtPoint);
            this.pnlEdit.Controls.Add(this.btnControl);
            this.pnlEdit.Controls.Add(this.lblPoint);
            this.pnlEdit.Controls.Add(this.txtName);
            this.pnlEdit.Controls.Add(this.lblName);
            this.pnlEdit.Location = new System.Drawing.Point(8, 7);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(543, 162);
            this.pnlEdit.TabIndex = 7;
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(263, 66);
            this.txtPoint.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.txtPoint.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(172, 28);
            this.txtPoint.TabIndex = 10;
            this.txtPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPoint_KeyDown);
            // 
            // btnControl
            // 
            this.btnControl.Location = new System.Drawing.Point(34, 110);
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(482, 38);
            this.btnControl.TabIndex = 2;
            this.btnControl.Text = "추가/편집 하기";
            this.btnControl.UseVisualStyleBackColor = true;
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // lblPoint
            // 
            this.lblPoint.Location = new System.Drawing.Point(114, 66);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(136, 23);
            this.lblPoint.TabIndex = 9;
            this.lblPoint.Text = "현재 포인트 :";
            this.lblPoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(263, 15);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 28);
            this.txtName.TabIndex = 0;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(114, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 23);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "이름 :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlPoint
            // 
            this.pnlPoint.Controls.Add(this.btnDel);
            this.pnlPoint.Controls.Add(this.btnClear);
            this.pnlPoint.Controls.Add(this.label1);
            this.pnlPoint.Controls.Add(this.lvLog);
            this.pnlPoint.Controls.Add(this.btnPut);
            this.pnlPoint.Controls.Add(this.txtReason);
            this.pnlPoint.Controls.Add(this.lblReason);
            this.pnlPoint.Controls.Add(this.txtNum);
            this.pnlPoint.Controls.Add(this.lblGivePoint);
            this.pnlPoint.Location = new System.Drawing.Point(8, 180);
            this.pnlPoint.Name = "pnlPoint";
            this.pnlPoint.Size = new System.Drawing.Size(543, 523);
            this.pnlPoint.TabIndex = 8;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(269, 123);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(245, 38);
            this.btnDel.TabIndex = 6;
            this.btnDel.Text = "칭찬 항목 삭제하기";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(35, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(479, 38);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "칭찬 항목 초기화하기";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(480, 2);
            this.label1.TabIndex = 16;
            // 
            // lvLog
            // 
            this.lvLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumber,
            this.chDate,
            this.chPoint,
            this.chReason});
            this.lvLog.FullRowSelect = true;
            this.lvLog.GridLines = true;
            this.lvLog.Location = new System.Drawing.Point(35, 197);
            this.lvLog.Name = "lvLog";
            this.lvLog.Size = new System.Drawing.Size(481, 256);
            this.lvLog.TabIndex = 15;
            this.lvLog.UseCompatibleStateImageBehavior = false;
            this.lvLog.View = System.Windows.Forms.View.Details;
            // 
            // chNumber
            // 
            this.chNumber.Text = "번호";
            this.chNumber.Width = 52;
            // 
            // chDate
            // 
            this.chDate.Text = "날짜";
            this.chDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDate.Width = 168;
            // 
            // chPoint
            // 
            this.chPoint.Text = "포인트";
            this.chPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPoint.Width = 70;
            // 
            // chReason
            // 
            this.chReason.Text = "이유";
            this.chReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chReason.Width = 187;
            // 
            // btnPut
            // 
            this.btnPut.Location = new System.Drawing.Point(34, 123);
            this.btnPut.Name = "btnPut";
            this.btnPut.Size = new System.Drawing.Size(229, 38);
            this.btnPut.TabIndex = 5;
            this.btnPut.Text = "추가하기";
            this.btnPut.UseVisualStyleBackColor = true;
            // 
            // txtReason
            // 
            this.txtReason.Location = new System.Drawing.Point(263, 76);
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(173, 28);
            this.txtReason.TabIndex = 4;
            this.txtReason.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReason
            // 
            this.lblReason.Location = new System.Drawing.Point(114, 81);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(136, 23);
            this.lblReason.TabIndex = 12;
            this.lblReason.Text = "이유 :";
            this.lblReason.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(263, 32);
            this.txtNum.Maximum = new decimal(new int[] {
            32000,
            0,
            0,
            0});
            this.txtNum.Minimum = new decimal(new int[] {
            32000,
            0,
            0,
            -2147483648});
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(172, 28);
            this.txtNum.TabIndex = 3;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblGivePoint
            // 
            this.lblGivePoint.Location = new System.Drawing.Point(114, 35);
            this.lblGivePoint.Name = "lblGivePoint";
            this.lblGivePoint.Size = new System.Drawing.Size(136, 23);
            this.lblGivePoint.TabIndex = 9;
            this.lblGivePoint.Text = "넣을 포인트 :";
            this.lblGivePoint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 712);
            this.Controls.Add(this.pnlPoint);
            this.Controls.Add(this.lblSplit);
            this.Controls.Add(this.pnlEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "포인트 편집";
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPoint)).EndInit();
            this.pnlPoint.ResumeLayout(false);
            this.pnlPoint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblSplit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnControl;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlPoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvLog;
        private System.Windows.Forms.Button btnPut;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private System.Windows.Forms.NumericUpDown txtNum;
        private System.Windows.Forms.Label lblGivePoint;
        private System.Windows.Forms.ColumnHeader chNumber;
        private System.Windows.Forms.ColumnHeader chPoint;
        private System.Windows.Forms.ColumnHeader chReason;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.NumericUpDown txtPoint;
    }
}