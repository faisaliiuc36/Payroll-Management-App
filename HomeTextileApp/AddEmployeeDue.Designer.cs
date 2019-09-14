namespace HomeTextileApp
{
	partial class AddEmployeeDue
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
			this.viewOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.companyComboBox = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.employeeDueDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeDueBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet3 = new HomeTextileApp.HomeTextileDBDataSet3();
			this.companiesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter();
			this.unitsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter();
			this.departmentsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter();
			this.sectionsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.employeeDuesDataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Paid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Due = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.employeeDuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.employeesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet3TableAdapters.EmployeesTableAdapter();
			this.employeeDuesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.EmployeeDuesTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.employeesTableAdapter1 = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.viewOTBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDueDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDueBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.employeeDuesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDuesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// viewOTBindingSource
			// 
			this.viewOTBindingSource.DataSource = typeof(HomeTextileApp.DL.ViewOT);
			// 
			// sectionsBindingSource
			// 
			this.sectionsBindingSource.DataMember = "FK_dbo.Sections_dbo.Departments_DepartmentId";
			this.sectionsBindingSource.DataSource = this.departmentsBindingSource;
			// 
			// departmentsBindingSource
			// 
			this.departmentsBindingSource.DataMember = "FK_dbo.Departments_dbo.Units_UnitId";
			this.departmentsBindingSource.DataSource = this.unitsBindingSource;
			// 
			// unitsBindingSource
			// 
			this.unitsBindingSource.DataMember = "FK_dbo.Units_dbo.Companies_CompanyId";
			this.unitsBindingSource.DataSource = this.companiesBindingSource;
			// 
			// companiesBindingSource
			// 
			this.companiesBindingSource.DataMember = "Companies";
			this.companiesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.comboBox4);
			this.groupBox2.Controls.Add(this.comboBox3);
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.companyComboBox);
			this.groupBox2.Location = new System.Drawing.Point(8, -18);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(797, 109);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lime;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(550, 61);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 48);
			this.button3.TabIndex = 12;
			this.button3.Text = "Search By Department";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(432, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 48);
			this.button1.TabIndex = 11;
			this.button1.Text = "Search By Section";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(400, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Department:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(266, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Unit:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(546, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Section";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(127, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Company:";
			// 
			// comboBox4
			// 
			this.comboBox4.DataSource = this.sectionsBindingSource;
			this.comboBox4.DisplayMember = "Name";
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(549, 35);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 23);
			this.comboBox4.TabIndex = 3;
			this.comboBox4.ValueMember = "Id";
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.departmentsBindingSource;
			this.comboBox3.DisplayMember = "Name";
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(403, 35);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 23);
			this.comboBox3.TabIndex = 2;
			this.comboBox3.ValueMember = "Id";
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.unitsBindingSource;
			this.comboBox2.DisplayMember = "Name";
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(269, 35);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 23);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.ValueMember = "Id";
			// 
			// companyComboBox
			// 
			this.companyComboBox.DataSource = this.companiesBindingSource;
			this.companyComboBox.DisplayMember = "Name";
			this.companyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.companyComboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.companyComboBox.FormattingEnabled = true;
			this.companyComboBox.Location = new System.Drawing.Point(130, 35);
			this.companyComboBox.Name = "companyComboBox";
			this.companyComboBox.Size = new System.Drawing.Size(121, 23);
			this.companyComboBox.TabIndex = 0;
			this.companyComboBox.ValueMember = "Id";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.employeeDueDataGridView);
			this.groupBox1.Location = new System.Drawing.Point(8, 91);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(655, 244);
			this.groupBox1.TabIndex = 25;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add_Due_Info";
			// 
			// employeeDueDataGridView
			// 
			this.employeeDueDataGridView.AutoGenerateColumns = false;
			this.employeeDueDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDueDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn6});
			this.employeeDueDataGridView.DataSource = this.employeeDueBindingSource;
			this.employeeDueDataGridView.Location = new System.Drawing.Point(0, 14);
			this.employeeDueDataGridView.Name = "employeeDueDataGridView";
			this.employeeDueDataGridView.Size = new System.Drawing.Size(570, 220);
			this.employeeDueDataGridView.TabIndex = 0;
			this.employeeDueDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDueDataGridView_CellClick);
			this.employeeDueDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDueDataGridView_CellContentClick);
			this.employeeDueDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDueDataGridView_CellContentDoubleClick);
			this.employeeDueDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDueDataGridView_CellValueChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn2.HeaderText = "Employee Id";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "DueCurrent";
			this.dataGridViewTextBoxColumn5.HeaderText = "Current Due";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "Paid";
			this.dataGridViewCheckBoxColumn1.HeaderText = "Paid";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.Width = 60;
			// 
			// dataGridViewCheckBoxColumn2
			// 
			this.dataGridViewCheckBoxColumn2.DataPropertyName = "Due";
			this.dataGridViewCheckBoxColumn2.HeaderText = "Due";
			this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			this.dataGridViewCheckBoxColumn2.Width = 60;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn6.HeaderText = "Date";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// employeeDueBindingSource
			// 
			this.employeeDueBindingSource.DataSource = typeof(HomeTextileApp.DL.EmployeeDue);
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "Employees";
			this.employeesBindingSource.DataSource = this.homeTextileDBDataSet3;
			// 
			// homeTextileDBDataSet3
			// 
			this.homeTextileDBDataSet3.DataSetName = "HomeTextileDBDataSet3";
			this.homeTextileDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// companiesTableAdapter
			// 
			this.companiesTableAdapter.ClearBeforeFill = true;
			// 
			// unitsTableAdapter
			// 
			this.unitsTableAdapter.ClearBeforeFill = true;
			// 
			// departmentsTableAdapter
			// 
			this.departmentsTableAdapter.ClearBeforeFill = true;
			// 
			// sectionsTableAdapter
			// 
			this.sectionsTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.employeeDuesDataGridView);
			this.groupBox3.Location = new System.Drawing.Point(8, 331);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(655, 304);
			this.groupBox3.TabIndex = 26;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Due_Info";
			// 
			// employeeDuesDataGridView
			// 
			this.employeeDuesDataGridView.AutoGenerateColumns = false;
			this.employeeDuesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDuesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.EmployeeId,
            this.Amount,
            this.Paid,
            this.Due,
            this.Date});
			this.employeeDuesDataGridView.DataSource = this.employeeDuesBindingSource;
			this.employeeDuesDataGridView.Location = new System.Drawing.Point(0, 17);
			this.employeeDuesDataGridView.Name = "employeeDuesDataGridView";
			this.employeeDuesDataGridView.Size = new System.Drawing.Size(570, 220);
			this.employeeDuesDataGridView.TabIndex = 0;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// EmployeeId
			// 
			this.EmployeeId.DataPropertyName = "EmployeeId";
			this.EmployeeId.HeaderText = "Employee Id";
			this.EmployeeId.Name = "EmployeeId";
			// 
			// Amount
			// 
			this.Amount.DataPropertyName = "Amount";
			this.Amount.HeaderText = "Amount";
			this.Amount.Name = "Amount";
			// 
			// Paid
			// 
			this.Paid.DataPropertyName = "Paid";
			this.Paid.HeaderText = "Paid";
			this.Paid.Name = "Paid";
			// 
			// Due
			// 
			this.Due.DataPropertyName = "Due";
			this.Due.HeaderText = "Due";
			this.Due.Name = "Due";
			// 
			// Date
			// 
			this.Date.DataPropertyName = "Date";
			this.Date.HeaderText = "Date";
			this.Date.Name = "Date";
			// 
			// employeeDuesBindingSource
			// 
			this.employeeDuesBindingSource.DataMember = "EmployeeDues";
			this.employeeDuesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// employeesBindingSource1
			// 
			this.employeesBindingSource1.DataMember = "Employees";
			this.employeesBindingSource1.DataSource = this.homeTextileDBDataSet2;
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
			// 
			// employeeDuesTableAdapter
			// 
			this.employeeDuesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
			this.tableAdapterManager.AdvancesTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BloodGroupsTableAdapter = null;
			this.tableAdapterManager.BonusTableAdapter = null;
			this.tableAdapterManager.CompaniesTableAdapter = this.companiesTableAdapter;
			this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
			this.tableAdapterManager.DesignationsTableAdapter = null;
			this.tableAdapterManager.Duty_RosterTableAdapter = null;
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = null;
			this.tableAdapterManager.EmployeeDuesTableAdapter = this.employeeDuesTableAdapter;
			this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter1;
			this.tableAdapterManager.EmployeeTypesTableAdapter = null;
			this.tableAdapterManager.GendersTableAdapter = null;
			this.tableAdapterManager.HolidaysTableAdapter = null;
			this.tableAdapterManager.HTAdminsTableAdapter = null;
			this.tableAdapterManager.InActiveHistoriesTableAdapter = null;
			this.tableAdapterManager.LeavesTableAdapter = null;
			this.tableAdapterManager.LeaveStoresTableAdapter = null;
			this.tableAdapterManager.LeaveTypesTableAdapter = null;
			this.tableAdapterManager.LoansTableAdapter = null;
			this.tableAdapterManager.MaritialStatusTableAdapter = null;
			this.tableAdapterManager.PaytimesTableAdapter = null;
			this.tableAdapterManager.ReligionsTableAdapter = null;
			this.tableAdapterManager.SalariesTableAdapter = null;
			this.tableAdapterManager.SalaryGradesTableAdapter = null;
			this.tableAdapterManager.SalarySettingsTableAdapter = null;
			this.tableAdapterManager.SectionsTableAdapter = this.sectionsTableAdapter;
			this.tableAdapterManager.ShadowEmployeesTableAdapter = null;
			this.tableAdapterManager.ShadowSalaryGradesTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = this.unitsTableAdapter;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationHistoriesTableAdapter = null;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// employeesTableAdapter1
			// 
			this.employeesTableAdapter1.ClearBeforeFill = true;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Lime;
			this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(590, 292);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(61, 33);
			this.button2.TabIndex = 13;
			this.button2.Text = "Save";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Red;
			this.button4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(590, 457);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(61, 33);
			this.button4.TabIndex = 27;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.Lime;
			this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(590, 535);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(61, 33);
			this.button5.TabIndex = 28;
			this.button5.Text = "Update";
			this.button5.UseVisualStyleBackColor = false;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.Lime;
			this.button6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.Location = new System.Drawing.Point(590, 496);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(61, 33);
			this.button6.TabIndex = 29;
			this.button6.Text = "Discard";
			this.button6.UseVisualStyleBackColor = false;
			// 
			// AddEmployeeDue
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddEmployeeDue";
			this.Text = "AddEmployeeDue";
			this.Load += new System.EventHandler(this.AddEmployeeDue_Load);
			((System.ComponentModel.ISupportInitialize)(this.viewOTBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeeDueDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDueBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.employeeDuesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDuesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource viewOTBindingSource;
		private System.Windows.Forms.BindingSource sectionsBindingSource;
		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private System.Windows.Forms.BindingSource unitsBindingSource;
		private System.Windows.Forms.BindingSource companiesBindingSource;
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox companyComboBox;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView employeeDueDataGridView;
		private System.Windows.Forms.BindingSource employeeDueBindingSource;
		private HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter companiesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter unitsTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter sectionsTableAdapter;
		private System.Windows.Forms.GroupBox groupBox3;
		private HomeTextileDBDataSet3 homeTextileDBDataSet3;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private HomeTextileDBDataSet3TableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private System.Windows.Forms.BindingSource employeeDuesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.EmployeeDuesTableAdapter employeeDuesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView employeeDuesDataGridView;
		private HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
		private System.Windows.Forms.BindingSource employeesBindingSource1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Paid;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Due;
		private System.Windows.Forms.DataGridViewTextBoxColumn Date;
	}
}