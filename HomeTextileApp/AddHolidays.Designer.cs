namespace HomeTextileApp
{
	partial class AddHolidays
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
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label departmentIdLabel;
			System.Windows.Forms.Label holidayReasonsLabel;
			System.Windows.Forms.Label fromLabel;
			System.Windows.Forms.Label toLabel;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.departmentIdComboBox = new System.Windows.Forms.ComboBox();
			this.holidaysBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.departmentsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.holidayReasonsTextBox = new System.Windows.Forms.TextBox();
			this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.holidaysDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.departmentsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.holidaysTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.HolidaysTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.departmentsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.departmentsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.unitsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.companiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.companyComboBox = new System.Windows.Forms.ComboBox();
			this.companiesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter();
			this.unitsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter();
			idLabel = new System.Windows.Forms.Label();
			departmentIdLabel = new System.Windows.Forms.Label();
			holidayReasonsLabel = new System.Windows.Forms.Label();
			fromLabel = new System.Windows.Forms.Label();
			toLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.holidaysBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.holidaysDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource3)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Location = new System.Drawing.Point(24, 187);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(19, 13);
			idLabel.TabIndex = 0;
			idLabel.Text = "Id:";
			idLabel.Visible = false;
			idLabel.Click += new System.EventHandler(this.idLabel_Click);
			// 
			// departmentIdLabel
			// 
			departmentIdLabel.AutoSize = true;
			departmentIdLabel.Location = new System.Drawing.Point(24, 79);
			departmentIdLabel.Name = "departmentIdLabel";
			departmentIdLabel.Size = new System.Drawing.Size(65, 13);
			departmentIdLabel.TabIndex = 2;
			departmentIdLabel.Text = "Department:";
			// 
			// holidayReasonsLabel
			// 
			holidayReasonsLabel.AutoSize = true;
			holidayReasonsLabel.Location = new System.Drawing.Point(24, 109);
			holidayReasonsLabel.Name = "holidayReasonsLabel";
			holidayReasonsLabel.Size = new System.Drawing.Size(90, 13);
			holidayReasonsLabel.TabIndex = 4;
			holidayReasonsLabel.Text = "Holiday Reasons:";
			// 
			// fromLabel
			// 
			fromLabel.AutoSize = true;
			fromLabel.Location = new System.Drawing.Point(24, 136);
			fromLabel.Name = "fromLabel";
			fromLabel.Size = new System.Drawing.Size(33, 13);
			fromLabel.TabIndex = 6;
			fromLabel.Text = "From:";
			// 
			// toLabel
			// 
			toLabel.AutoSize = true;
			toLabel.Location = new System.Drawing.Point(24, 162);
			toLabel.Name = "toLabel";
			toLabel.Size = new System.Drawing.Size(23, 13);
			toLabel.TabIndex = 8;
			toLabel.Text = "To:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.departmentIdComboBox);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(idLabel);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.idTextBox);
			this.groupBox1.Controls.Add(this.comboBox4);
			this.groupBox1.Controls.Add(departmentIdLabel);
			this.groupBox1.Controls.Add(holidayReasonsLabel);
			this.groupBox1.Controls.Add(this.holidayReasonsTextBox);
			this.groupBox1.Controls.Add(fromLabel);
			this.groupBox1.Controls.Add(this.fromDateTimePicker);
			this.groupBox1.Controls.Add(toLabel);
			this.groupBox1.Controls.Add(this.toDateTimePicker);
			this.groupBox1.Location = new System.Drawing.Point(10, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(341, 379);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Holiday Form";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lime;
			this.button4.Location = new System.Drawing.Point(157, 243);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(121, 27);
			this.button4.TabIndex = 18;
			this.button4.Text = "Reset Changes";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// departmentIdComboBox
			// 
			this.departmentIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.holidaysBindingSource, "DepartmentId", true));
			this.departmentIdComboBox.DataSource = this.departmentsBindingSource2;
			this.departmentIdComboBox.DisplayMember = "Name";
			this.departmentIdComboBox.FormattingEnabled = true;
			this.departmentIdComboBox.Location = new System.Drawing.Point(120, 79);
			this.departmentIdComboBox.Name = "departmentIdComboBox";
			this.departmentIdComboBox.Size = new System.Drawing.Size(200, 21);
			this.departmentIdComboBox.TabIndex = 17;
			this.departmentIdComboBox.ValueMember = "Id";
			// 
			// holidaysBindingSource
			// 
			this.holidaysBindingSource.DataMember = "Holidays";
			this.holidaysBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// departmentsBindingSource2
			// 
			this.departmentsBindingSource2.DataMember = "Departments";
			this.departmentsBindingSource2.DataSource = this.homeTextileDBDataSet2;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lime;
			this.button3.Location = new System.Drawing.Point(258, 210);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(62, 27);
			this.button3.TabIndex = 14;
			this.button3.Text = "Save";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Location = new System.Drawing.Point(117, 210);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(60, 27);
			this.button2.TabIndex = 4;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(183, 210);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(69, 27);
			this.button1.TabIndex = 3;
			this.button1.Text = "Update";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Unit:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(24, 33);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 12;
			this.label6.Text = "Company:";
			// 
			// comboBox1
			// 
			this.comboBox1.DataSource = this.unitsBindingSource;
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(120, 52);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 21);
			this.comboBox1.TabIndex = 11;
			this.comboBox1.ValueMember = "Id";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.holidaysBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(120, 184);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(200, 20);
			this.idTextBox.TabIndex = 1;
			this.idTextBox.Visible = false;
			this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
			// 
			// comboBox4
			// 
			this.comboBox4.DataSource = this.companiesBindingSource;
			this.comboBox4.DisplayMember = "Name";
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(120, 25);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(200, 21);
			this.comboBox4.TabIndex = 10;
			this.comboBox4.ValueMember = "Id";
			// 
			// holidayReasonsTextBox
			// 
			this.holidayReasonsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.holidaysBindingSource, "HolidayReasons", true));
			this.holidayReasonsTextBox.Location = new System.Drawing.Point(120, 106);
			this.holidayReasonsTextBox.Name = "holidayReasonsTextBox";
			this.holidayReasonsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.holidayReasonsTextBox.Size = new System.Drawing.Size(200, 20);
			this.holidayReasonsTextBox.TabIndex = 5;
			// 
			// fromDateTimePicker
			// 
			this.fromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidaysBindingSource, "From", true));
			this.fromDateTimePicker.Location = new System.Drawing.Point(120, 132);
			this.fromDateTimePicker.Name = "fromDateTimePicker";
			this.fromDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.fromDateTimePicker.TabIndex = 7;
			// 
			// toDateTimePicker
			// 
			this.toDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.holidaysBindingSource, "To", true));
			this.toDateTimePicker.Location = new System.Drawing.Point(120, 158);
			this.toDateTimePicker.Name = "toDateTimePicker";
			this.toDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.toDateTimePicker.TabIndex = 9;
			// 
			// departmentsBindingSource
			// 
			this.departmentsBindingSource.DataMember = "FK_dbo.Departments_dbo.Units_UnitId";
			this.departmentsBindingSource.DataSource = this.unitsBindingSource;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.holidaysDataGridView);
			this.groupBox2.Location = new System.Drawing.Point(357, 87);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(445, 379);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Holiday List";
			// 
			// holidaysDataGridView
			// 
			this.holidaysDataGridView.AutoGenerateColumns = false;
			this.holidaysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.holidaysDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.holidaysDataGridView.DataSource = this.holidaysBindingSource;
			this.holidaysDataGridView.Location = new System.Drawing.Point(0, 19);
			this.holidaysDataGridView.Name = "holidaysDataGridView";
			this.holidaysDataGridView.ReadOnly = true;
			this.holidaysDataGridView.Size = new System.Drawing.Size(445, 354);
			this.holidaysDataGridView.TabIndex = 0;
			this.holidaysDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.holidaysDataGridView_CellClick);
			this.holidaysDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.holidaysDataGridView_CellValueChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "DepartmentId";
			this.dataGridViewTextBoxColumn2.DataSource = this.departmentsBindingSource3;
			this.dataGridViewTextBoxColumn2.DisplayMember = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Department";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn2.ValueMember = "Id";
			// 
			// departmentsBindingSource3
			// 
			this.departmentsBindingSource3.DataMember = "Departments";
			this.departmentsBindingSource3.DataSource = this.homeTextileDBDataSet2;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "HolidayReasons";
			this.dataGridViewTextBoxColumn3.HeaderText = "HolidayReasons";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "From";
			this.dataGridViewTextBoxColumn4.HeaderText = "From";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "To";
			this.dataGridViewTextBoxColumn5.HeaderText = "To";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// holidaysTableAdapter
			// 
			this.holidaysTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BloodGroupsTableAdapter = null;
			this.tableAdapterManager.BonusTableAdapter = null;
			this.tableAdapterManager.CompaniesTableAdapter = null;
			this.tableAdapterManager.DepartmentsTableAdapter = this.departmentsTableAdapter;
			this.tableAdapterManager.DesignationsTableAdapter = null;
			this.tableAdapterManager.Duty_RosterTableAdapter = null;
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = null;
			this.tableAdapterManager.EmployeesTableAdapter = null;
			this.tableAdapterManager.EmployeeTypesTableAdapter = null;
			this.tableAdapterManager.GendersTableAdapter = null;
			this.tableAdapterManager.HolidaysTableAdapter = this.holidaysTableAdapter;
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
			this.tableAdapterManager.SectionsTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// departmentsTableAdapter
			// 
			this.departmentsTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dateTimePicker1);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label1);
			this.groupBox3.Controls.Add(this.comboBox3);
			this.groupBox3.Controls.Add(this.comboBox2);
			this.groupBox3.Controls.Add(this.companyComboBox);
			this.groupBox3.Location = new System.Drawing.Point(10, 4);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(780, 77);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Filter Holidays";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(444, 41);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 9;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(439, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Search By Year:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(297, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Department:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(163, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Unit:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Company:";
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.departmentsBindingSource1;
			this.comboBox3.DisplayMember = "Name";
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(300, 41);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 21);
			this.comboBox3.TabIndex = 2;
			this.comboBox3.ValueMember = "Id";
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
			// 
			// departmentsBindingSource1
			// 
			this.departmentsBindingSource1.DataMember = "FK_dbo.Departments_dbo.Units_UnitId";
			this.departmentsBindingSource1.DataSource = this.unitsBindingSource;
			// 
			// unitsBindingSource1
			// 
			this.unitsBindingSource1.DataMember = "FK_dbo.Units_dbo.Companies_CompanyId";
			this.unitsBindingSource1.DataSource = this.companiesBindingSource1;
			// 
			// companiesBindingSource1
			// 
			this.companiesBindingSource1.DataMember = "Companies";
			this.companiesBindingSource1.DataSource = this.homeTextileDBDataSet2;
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.unitsBindingSource;
			this.comboBox2.DisplayMember = "Name";
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(166, 41);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 21);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.ValueMember = "Id";
			// 
			// companyComboBox
			// 
			this.companyComboBox.DataSource = this.companiesBindingSource;
			this.companyComboBox.DisplayMember = "Name";
			this.companyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.companyComboBox.FormattingEnabled = true;
			this.companyComboBox.Location = new System.Drawing.Point(27, 41);
			this.companyComboBox.Name = "companyComboBox";
			this.companyComboBox.Size = new System.Drawing.Size(121, 21);
			this.companyComboBox.TabIndex = 0;
			this.companyComboBox.ValueMember = "Id";
			// 
			// companiesTableAdapter
			// 
			this.companiesTableAdapter.ClearBeforeFill = true;
			// 
			// unitsTableAdapter
			// 
			this.unitsTableAdapter.ClearBeforeFill = true;
			// 
			// AddHolidays
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "AddHolidays";
			this.Text = "AddHolidays";
			this.Load += new System.EventHandler(this.AddHolidays_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.holidaysBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.holidaysDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource3)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource holidaysBindingSource;
		private HomeTextileDBDataSet2TableAdapters.HolidaysTableAdapter holidaysTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView holidaysDataGridView;
		private HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox companyComboBox;
		private System.Windows.Forms.BindingSource companiesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter companiesTableAdapter;
		private System.Windows.Forms.BindingSource unitsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter unitsTableAdapter;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox holidayReasonsTextBox;
		private System.Windows.Forms.DateTimePicker fromDateTimePicker;
		private System.Windows.Forms.DateTimePicker toDateTimePicker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.BindingSource departmentsBindingSource1;
		private System.Windows.Forms.BindingSource unitsBindingSource1;
		private System.Windows.Forms.BindingSource companiesBindingSource1;
		private System.Windows.Forms.ComboBox departmentIdComboBox;
		private System.Windows.Forms.BindingSource departmentsBindingSource2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.BindingSource departmentsBindingSource3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.Button button4;
	}
}