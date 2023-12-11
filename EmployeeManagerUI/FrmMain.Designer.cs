namespace EmployeeManagerUI
{
    partial class FrmMain
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
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbExit = new System.Windows.Forms.ToolStripButton();
            this.tsState = new System.Windows.Forms.ToolStrip();
            this.tslTimer = new System.Windows.Forms.ToolStripLabel();
            this.tslTime = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tslLoginName = new System.Windows.Forms.ToolStripLabel();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpEHireDate = new System.Windows.Forms.DateTimePicker();
            this.dtpBHireDate = new System.Windows.Forms.DateTimePicker();
            this.cbbDeptno = new System.Windows.Forms.ComboBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.edtEmpMgr = new System.Windows.Forms.TextBox();
            this.edtEmpName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.edtEmpId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.edtDeptName = new System.Windows.Forms.TextBox();
            this.edtDeptno = new System.Windows.Forms.TextBox();
            this.edtPhone = new System.Windows.Forms.TextBox();
            this.edtHireDate = new System.Windows.Forms.TextBox();
            this.edtMgr = new System.Windows.Forms.TextBox();
            this.edtJob = new System.Windows.Forms.TextBox();
            this.edtGender = new System.Windows.Forms.TextBox();
            this.edtAge = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtId = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dbgEmployees = new System.Windows.Forms.DataGridView();
            this.empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.job = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mgr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hiredate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMainMenu.SuspendLayout();
            this.tsState.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSearch,
            this.tsbAdd,
            this.tsbEdit,
            this.tsbDelete,
            this.tsbExit});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(1376, 27);
            this.tsMainMenu.TabIndex = 0;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // tsbSearch
            // 
            this.tsbSearch.Image = global::EmployeeManagerUI.Properties.Resources.查询选择;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(82, 24);
            this.tsbSearch.Text = "查询(&S)";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::EmployeeManagerUI.Properties.Resources.新增;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(84, 24);
            this.tsbAdd.Text = "新增(&A)";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::EmployeeManagerUI.Properties.Resources.修改;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(84, 24);
            this.tsbEdit.Text = "修改(&U)";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::EmployeeManagerUI.Properties.Resources.删除;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(84, 24);
            this.tsbDelete.Text = "删除(&D)";
            // 
            // tsbExit
            // 
            this.tsbExit.Image = global::EmployeeManagerUI.Properties.Resources.退出;
            this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExit.Name = "tsbExit";
            this.tsbExit.Size = new System.Drawing.Size(81, 24);
            this.tsbExit.Text = "退出(&E)";
            this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
            // 
            // tsState
            // 
            this.tsState.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tsState.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsState.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTimer,
            this.tslTime,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.tslLoginName});
            this.tsState.Location = new System.Drawing.Point(0, 1030);
            this.tsState.Name = "tsState";
            this.tsState.Size = new System.Drawing.Size(1376, 25);
            this.tsState.TabIndex = 1;
            this.tsState.Text = "toolStrip1";
            // 
            // tslTimer
            // 
            this.tslTimer.Name = "tslTimer";
            this.tslTimer.Size = new System.Drawing.Size(84, 22);
            this.tslTimer.Text = "当前时间：";
            // 
            // tslTime
            // 
            this.tslTime.Name = "tslTime";
            this.tslTime.Size = new System.Drawing.Size(42, 22);
            this.tslTime.Text = "time";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(114, 22);
            this.toolStripLabel1.Text = "当前登录用户：";
            // 
            // tslLoginName
            // 
            this.tslLoginName.Name = "tslLoginName";
            this.tslLoginName.Size = new System.Drawing.Size(45, 22);
            this.tslLoginName.Text = "1001";
            // 
            // tmTime
            // 
            this.tmTime.Enabled = true;
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.dtpEHireDate);
            this.panel3.Controls.Add(this.dtpBHireDate);
            this.panel3.Controls.Add(this.cbbDeptno);
            this.panel3.Controls.Add(this.cbbGender);
            this.panel3.Controls.Add(this.edtEmpMgr);
            this.panel3.Controls.Add(this.edtEmpName);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.edtEmpId);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1376, 125);
            this.panel3.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(668, 86);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "到";
            // 
            // dtpEHireDate
            // 
            this.dtpEHireDate.CustomFormat = "yyyy-mm-dd";
            this.dtpEHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEHireDate.Location = new System.Drawing.Point(699, 79);
            this.dtpEHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEHireDate.Name = "dtpEHireDate";
            this.dtpEHireDate.Size = new System.Drawing.Size(204, 25);
            this.dtpEHireDate.TabIndex = 12;
            // 
            // dtpBHireDate
            // 
            this.dtpBHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBHireDate.Location = new System.Drawing.Point(455, 79);
            this.dtpBHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpBHireDate.Name = "dtpBHireDate";
            this.dtpBHireDate.Size = new System.Drawing.Size(204, 25);
            this.dtpBHireDate.TabIndex = 11;
            // 
            // cbbDeptno
            // 
            this.cbbDeptno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDeptno.FormattingEnabled = true;
            this.cbbDeptno.Location = new System.Drawing.Point(111, 82);
            this.cbbDeptno.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDeptno.Name = "cbbDeptno";
            this.cbbDeptno.Size = new System.Drawing.Size(204, 23);
            this.cbbDeptno.TabIndex = 10;
            // 
            // cbbGender
            // 
            this.cbbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbbGender.Location = new System.Drawing.Point(805, 25);
            this.cbbGender.Margin = new System.Windows.Forms.Padding(4);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(204, 23);
            this.cbbGender.TabIndex = 9;
            // 
            // edtEmpMgr
            // 
            this.edtEmpMgr.Location = new System.Drawing.Point(1152, 25);
            this.edtEmpMgr.Margin = new System.Windows.Forms.Padding(4);
            this.edtEmpMgr.Name = "edtEmpMgr";
            this.edtEmpMgr.Size = new System.Drawing.Size(196, 25);
            this.edtEmpMgr.TabIndex = 8;
            // 
            // edtEmpName
            // 
            this.edtEmpName.Location = new System.Drawing.Point(455, 25);
            this.edtEmpName.Margin = new System.Windows.Forms.Padding(4);
            this.edtEmpName.Name = "edtEmpName";
            this.edtEmpName.Size = new System.Drawing.Size(196, 25);
            this.edtEmpName.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1057, 29);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "直属上级：";
            // 
            // edtEmpId
            // 
            this.edtEmpId.Location = new System.Drawing.Point(111, 25);
            this.edtEmpId.Margin = new System.Windows.Forms.Padding(4);
            this.edtEmpId.Name = "edtEmpId";
            this.edtEmpId.Size = new System.Drawing.Size(196, 25);
            this.edtEmpId.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 86);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 15);
            this.label15.TabIndex = 4;
            this.label15.Text = "部门编号：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 86);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 3;
            this.label14.Text = "入职日期：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(711, 29);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 15);
            this.label13.TabIndex = 2;
            this.label13.Text = "员工性别：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(360, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "员工姓名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "员工编号：";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.edtDeptName);
            this.panel5.Controls.Add(this.edtDeptno);
            this.panel5.Controls.Add(this.edtPhone);
            this.panel5.Controls.Add(this.edtHireDate);
            this.panel5.Controls.Add(this.edtMgr);
            this.panel5.Controls.Add(this.edtJob);
            this.panel5.Controls.Add(this.edtGender);
            this.panel5.Controls.Add(this.edtAge);
            this.panel5.Controls.Add(this.edtName);
            this.panel5.Controls.Add(this.edtId);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 807);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1376, 223);
            this.panel5.TabIndex = 6;
            // 
            // edtDeptName
            // 
            this.edtDeptName.Location = new System.Drawing.Point(455, 165);
            this.edtDeptName.Margin = new System.Windows.Forms.Padding(4);
            this.edtDeptName.Name = "edtDeptName";
            this.edtDeptName.ReadOnly = true;
            this.edtDeptName.Size = new System.Drawing.Size(204, 25);
            this.edtDeptName.TabIndex = 19;
            // 
            // edtDeptno
            // 
            this.edtDeptno.Location = new System.Drawing.Point(103, 165);
            this.edtDeptno.Margin = new System.Windows.Forms.Padding(4);
            this.edtDeptno.Name = "edtDeptno";
            this.edtDeptno.ReadOnly = true;
            this.edtDeptno.Size = new System.Drawing.Size(204, 25);
            this.edtDeptno.TabIndex = 18;
            // 
            // edtPhone
            // 
            this.edtPhone.Location = new System.Drawing.Point(1152, 99);
            this.edtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.edtPhone.Name = "edtPhone";
            this.edtPhone.ReadOnly = true;
            this.edtPhone.Size = new System.Drawing.Size(204, 25);
            this.edtPhone.TabIndex = 17;
            // 
            // edtHireDate
            // 
            this.edtHireDate.Location = new System.Drawing.Point(805, 99);
            this.edtHireDate.Margin = new System.Windows.Forms.Padding(4);
            this.edtHireDate.Name = "edtHireDate";
            this.edtHireDate.ReadOnly = true;
            this.edtHireDate.Size = new System.Drawing.Size(204, 25);
            this.edtHireDate.TabIndex = 16;
            // 
            // edtMgr
            // 
            this.edtMgr.Location = new System.Drawing.Point(455, 99);
            this.edtMgr.Margin = new System.Windows.Forms.Padding(4);
            this.edtMgr.Name = "edtMgr";
            this.edtMgr.ReadOnly = true;
            this.edtMgr.Size = new System.Drawing.Size(204, 25);
            this.edtMgr.TabIndex = 15;
            // 
            // edtJob
            // 
            this.edtJob.Location = new System.Drawing.Point(103, 102);
            this.edtJob.Margin = new System.Windows.Forms.Padding(4);
            this.edtJob.Name = "edtJob";
            this.edtJob.ReadOnly = true;
            this.edtJob.Size = new System.Drawing.Size(204, 25);
            this.edtJob.TabIndex = 14;
            // 
            // edtGender
            // 
            this.edtGender.Location = new System.Drawing.Point(1152, 39);
            this.edtGender.Margin = new System.Windows.Forms.Padding(4);
            this.edtGender.Name = "edtGender";
            this.edtGender.ReadOnly = true;
            this.edtGender.Size = new System.Drawing.Size(204, 25);
            this.edtGender.TabIndex = 13;
            // 
            // edtAge
            // 
            this.edtAge.Location = new System.Drawing.Point(805, 39);
            this.edtAge.Margin = new System.Windows.Forms.Padding(4);
            this.edtAge.Name = "edtAge";
            this.edtAge.ReadOnly = true;
            this.edtAge.Size = new System.Drawing.Size(204, 25);
            this.edtAge.TabIndex = 12;
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(455, 39);
            this.edtName.Margin = new System.Windows.Forms.Padding(4);
            this.edtName.Name = "edtName";
            this.edtName.ReadOnly = true;
            this.edtName.Size = new System.Drawing.Size(204, 25);
            this.edtName.TabIndex = 11;
            // 
            // edtId
            // 
            this.edtId.Location = new System.Drawing.Point(103, 39);
            this.edtId.Margin = new System.Windows.Forms.Padding(4);
            this.edtId.Name = "edtId";
            this.edtId.ReadOnly = true;
            this.edtId.Size = new System.Drawing.Size(204, 25);
            this.edtId.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(360, 169);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 9;
            this.label10.Text = "部门名称：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 169);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 8;
            this.label9.Text = "部门编号：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1057, 102);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "联系方式：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(711, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "入职日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 102);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "直属上级：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "员工职务：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1057, 42);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "员工性别：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "员工年龄：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 42);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "员工姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "员工编号：";
            // 
            // dbgEmployees
            // 
            this.dbgEmployees.AllowUserToAddRows = false;
            this.dbgEmployees.AllowUserToDeleteRows = false;
            this.dbgEmployees.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dbgEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbgEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empid,
            this.ename,
            this.age,
            this.gender,
            this.job,
            this.mgr,
            this.hiredate,
            this.phone,
            this.deptno,
            this.dname});
            this.dbgEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dbgEmployees.Location = new System.Drawing.Point(0, 152);
            this.dbgEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dbgEmployees.Name = "dbgEmployees";
            this.dbgEmployees.ReadOnly = true;
            this.dbgEmployees.RowHeadersWidth = 51;
            this.dbgEmployees.RowTemplate.Height = 23;
            this.dbgEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dbgEmployees.Size = new System.Drawing.Size(1376, 655);
            this.dbgEmployees.TabIndex = 7;
            this.dbgEmployees.SelectionChanged += new System.EventHandler(this.dbgEmployees_SelectionChanged);
            // 
            // empid
            // 
            this.empid.DataPropertyName = "empid";
            this.empid.HeaderText = "员工编号";
            this.empid.MinimumWidth = 6;
            this.empid.Name = "empid";
            this.empid.ReadOnly = true;
            this.empid.Width = 125;
            // 
            // ename
            // 
            this.ename.DataPropertyName = "ename";
            this.ename.HeaderText = "员工姓名";
            this.ename.MinimumWidth = 6;
            this.ename.Name = "ename";
            this.ename.ReadOnly = true;
            this.ename.Width = 125;
            // 
            // age
            // 
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "员工年龄";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 125;
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "员工性别";
            this.gender.MinimumWidth = 6;
            this.gender.Name = "gender";
            this.gender.ReadOnly = true;
            this.gender.Width = 125;
            // 
            // job
            // 
            this.job.DataPropertyName = "job";
            this.job.HeaderText = "员工职务";
            this.job.MinimumWidth = 6;
            this.job.Name = "job";
            this.job.ReadOnly = true;
            this.job.Width = 125;
            // 
            // mgr
            // 
            this.mgr.DataPropertyName = "mgr";
            this.mgr.HeaderText = "直属上级";
            this.mgr.MinimumWidth = 6;
            this.mgr.Name = "mgr";
            this.mgr.ReadOnly = true;
            this.mgr.Width = 125;
            // 
            // hiredate
            // 
            this.hiredate.DataPropertyName = "hiredate";
            this.hiredate.HeaderText = "入职日期";
            this.hiredate.MinimumWidth = 6;
            this.hiredate.Name = "hiredate";
            this.hiredate.ReadOnly = true;
            this.hiredate.Width = 125;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "联系方式";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 125;
            // 
            // deptno
            // 
            this.deptno.DataPropertyName = "deptno";
            this.deptno.HeaderText = "所属部门";
            this.deptno.MinimumWidth = 6;
            this.deptno.Name = "deptno";
            this.deptno.ReadOnly = true;
            this.deptno.Width = 125;
            // 
            // dname
            // 
            this.dname.DataPropertyName = "dname";
            this.dname.HeaderText = "部门名称";
            this.dname.MinimumWidth = 6;
            this.dname.Name = "dname";
            this.dname.ReadOnly = true;
            this.dname.Width = 125;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 1055);
            this.Controls.Add(this.dbgEmployees);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tsState);
            this.Controls.Add(this.tsMainMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            this.tsState.ResumeLayout(false);
            this.tsState.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbgEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripButton tsbExit;
        private System.Windows.Forms.ToolStrip tsState;
        private System.Windows.Forms.ToolStripLabel tslTimer;
        private System.Windows.Forms.ToolStripLabel tslTime;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel tslLoginName;
        private System.Windows.Forms.Timer tmTime;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox edtEmpId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.DateTimePicker dtpBHireDate;
        private System.Windows.Forms.ComboBox cbbDeptno;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.TextBox edtEmpMgr;
        private System.Windows.Forms.TextBox edtEmpName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpEHireDate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox edtDeptName;
        private System.Windows.Forms.TextBox edtDeptno;
        private System.Windows.Forms.TextBox edtPhone;
        private System.Windows.Forms.TextBox edtHireDate;
        private System.Windows.Forms.TextBox edtMgr;
        private System.Windows.Forms.TextBox edtJob;
        private System.Windows.Forms.TextBox edtGender;
        private System.Windows.Forms.TextBox edtAge;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtId;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dbgEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ename;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn job;
        private System.Windows.Forms.DataGridViewTextBoxColumn mgr;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiredate;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn deptno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dname;
    }
}