namespace EmployeeManagerUI
{
    partial class FrmAddEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.edtAddName = new System.Windows.Forms.TextBox();
            this.edtAddAge = new System.Windows.Forms.TextBox();
            this.edtAddPhone = new System.Windows.Forms.TextBox();
            this.edtAddJob = new System.Windows.Forms.TextBox();
            this.edtAddDeptName = new System.Windows.Forms.TextBox();
            this.cbbAddGender = new System.Windows.Forms.ComboBox();
            this.cbbAddMgr = new System.Windows.Forms.ComboBox();
            this.cbbAddDeptno = new System.Windows.Forms.ComboBox();
            this.dtpAddHireDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工名称：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工年龄：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "员工职务：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "直属上级：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "入职日期：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "联系方式：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 491);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "所属部门：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 567);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "部门名称：";
            // 
            // edtAddName
            // 
            this.edtAddName.Location = new System.Drawing.Point(122, 29);
            this.edtAddName.Name = "edtAddName";
            this.edtAddName.Size = new System.Drawing.Size(205, 25);
            this.edtAddName.TabIndex = 10;
            // 
            // edtAddAge
            // 
            this.edtAddAge.Location = new System.Drawing.Point(122, 85);
            this.edtAddAge.Name = "edtAddAge";
            this.edtAddAge.Size = new System.Drawing.Size(205, 25);
            this.edtAddAge.TabIndex = 11;
            this.edtAddAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.edtAddAge_KeyPress);
            // 
            // edtAddPhone
            // 
            this.edtAddPhone.Location = new System.Drawing.Point(122, 422);
            this.edtAddPhone.Name = "edtAddPhone";
            this.edtAddPhone.Size = new System.Drawing.Size(205, 25);
            this.edtAddPhone.TabIndex = 12;
            // 
            // edtAddJob
            // 
            this.edtAddJob.Location = new System.Drawing.Point(122, 214);
            this.edtAddJob.Name = "edtAddJob";
            this.edtAddJob.Size = new System.Drawing.Size(205, 25);
            this.edtAddJob.TabIndex = 13;
            // 
            // edtAddDeptName
            // 
            this.edtAddDeptName.Location = new System.Drawing.Point(122, 564);
            this.edtAddDeptName.Name = "edtAddDeptName";
            this.edtAddDeptName.ReadOnly = true;
            this.edtAddDeptName.Size = new System.Drawing.Size(205, 25);
            this.edtAddDeptName.TabIndex = 14;
            // 
            // cbbAddGender
            // 
            this.cbbAddGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddGender.FormattingEnabled = true;
            this.cbbAddGender.Items.AddRange(new object[] {
            "",
            "男",
            "女"});
            this.cbbAddGender.Location = new System.Drawing.Point(122, 147);
            this.cbbAddGender.Name = "cbbAddGender";
            this.cbbAddGender.Size = new System.Drawing.Size(205, 23);
            this.cbbAddGender.TabIndex = 15;
            // 
            // cbbAddMgr
            // 
            this.cbbAddMgr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddMgr.FormattingEnabled = true;
            this.cbbAddMgr.Location = new System.Drawing.Point(122, 283);
            this.cbbAddMgr.Name = "cbbAddMgr";
            this.cbbAddMgr.Size = new System.Drawing.Size(205, 23);
            this.cbbAddMgr.TabIndex = 16;
            // 
            // cbbAddDeptno
            // 
            this.cbbAddDeptno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbAddDeptno.FormattingEnabled = true;
            this.cbbAddDeptno.Location = new System.Drawing.Point(122, 488);
            this.cbbAddDeptno.Name = "cbbAddDeptno";
            this.cbbAddDeptno.Size = new System.Drawing.Size(205, 23);
            this.cbbAddDeptno.TabIndex = 17;
            this.cbbAddDeptno.SelectedIndexChanged += new System.EventHandler(this.cbbAddDeptno_SelectedIndexChanged);
            // 
            // dtpAddHireDate
            // 
            this.dtpAddHireDate.Location = new System.Drawing.Point(122, 352);
            this.dtpAddHireDate.Name = "dtpAddHireDate";
            this.dtpAddHireDate.Size = new System.Drawing.Size(205, 25);
            this.dtpAddHireDate.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::EmployeeManagerUI.Properties.Resources.新增;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(122, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpAddHireDate);
            this.Controls.Add(this.cbbAddDeptno);
            this.Controls.Add(this.cbbAddMgr);
            this.Controls.Add(this.cbbAddGender);
            this.Controls.Add(this.edtAddDeptName);
            this.Controls.Add(this.edtAddJob);
            this.Controls.Add(this.edtAddPhone);
            this.Controls.Add(this.edtAddAge);
            this.Controls.Add(this.edtAddName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmAddEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加员工信息";
            this.Load += new System.EventHandler(this.FrmAddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox edtAddName;
        private System.Windows.Forms.TextBox edtAddAge;
        private System.Windows.Forms.TextBox edtAddPhone;
        private System.Windows.Forms.TextBox edtAddJob;
        private System.Windows.Forms.TextBox edtAddDeptName;
        private System.Windows.Forms.ComboBox cbbAddGender;
        private System.Windows.Forms.ComboBox cbbAddMgr;
        private System.Windows.Forms.ComboBox cbbAddDeptno;
        private System.Windows.Forms.DateTimePicker dtpAddHireDate;
        private System.Windows.Forms.Button button1;
    }
}