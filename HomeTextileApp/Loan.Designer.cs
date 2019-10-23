namespace HomeTextileApp
{
	partial class Loan
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
			System.Windows.Forms.Label empFullNameLabel;
			System.Windows.Forms.Label designationIdLabel1;
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label amountLabel;
			System.Windows.Forms.Label dateLabel;
			System.Windows.Forms.Label installmentLabel;
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.loansBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.loansTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.LoansTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.designationsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.DesignationsTableAdapter();
			this.employeesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter();
			this.paytimesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.PaytimesTableAdapter();
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.empIdTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.amountTextBox = new System.Windows.Forms.TextBox();
			this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.installmentTextBox = new System.Windows.Forms.TextBox();
			this.loansDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.designationIdComboBox = new System.Windows.Forms.ComboBox();
			this.designationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.empFullNameTextBox = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.paytimesDataGridView = new System.Windows.Forms.DataGridView();
			this.paytimesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button2 = new System.Windows.Forms.Button();
			this.paytimesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loanIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			empFullNameLabel = new System.Windows.Forms.Label();
			designationIdLabel1 = new System.Windows.Forms.Label();
			idLabel = new System.Windows.Forms.Label();
			amountLabel = new System.Windows.Forms.Label();
			dateLabel = new System.Windows.Forms.Label();
			installmentLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paytimesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paytimesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.paytimesBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// empFullNameLabel
			// 
			empFullNameLabel.AutoSize = true;
			empFullNameLabel.Location = new System.Drawing.Point(467, 121);
			empFullNameLabel.Name = "empFullNameLabel";
			empFullNameLabel.Size = new System.Drawing.Size(89, 15);
			empFullNameLabel.TabIndex = 1;
			empFullNameLabel.Text = "Emp Full Name:";
			// 
			// designationIdLabel1
			// 
			designationIdLabel1.AutoSize = true;
			designationIdLabel1.Location = new System.Drawing.Point(481, 92);
			designationIdLabel1.Name = "designationIdLabel1";
			designationIdLabel1.Size = new System.Drawing.Size(75, 15);
			designationIdLabel1.TabIndex = 6;
			designationIdLabel1.Text = "Designation:";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Location = new System.Drawing.Point(481, 232);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(21, 15);
			idLabel.TabIndex = 12;
			idLabel.Text = "Id:";
			idLabel.Visible = false;
			// 
			// amountLabel
			// 
			amountLabel.AutoSize = true;
			amountLabel.Location = new System.Drawing.Point(481, 150);
			amountLabel.Name = "amountLabel";
			amountLabel.Size = new System.Drawing.Size(54, 15);
			amountLabel.TabIndex = 16;
			amountLabel.Text = "Amount:";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new System.Drawing.Point(481, 179);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new System.Drawing.Size(35, 15);
			dateLabel.TabIndex = 18;
			dateLabel.Text = "Date:";
			// 
			// installmentLabel
			// 
			installmentLabel.AutoSize = true;
			installmentLabel.Location = new System.Drawing.Point(481, 206);
			installmentLabel.Name = "installmentLabel";
			installmentLabel.Size = new System.Drawing.Size(69, 15);
			installmentLabel.TabIndex = 20;
			installmentLabel.Text = "Installment:";
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// loansBindingSource
			// 
			this.loansBindingSource.DataMember = "Loans";
			this.loansBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// loansTableAdapter
			// 
			this.loansTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
			this.tableAdapterManager.AdvancesTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BloodGroupsTableAdapter = null;
			this.tableAdapterManager.BonusTableAdapter = null;
			this.tableAdapterManager.CompaniesTableAdapter = null;
			this.tableAdapterManager.DepartmentsTableAdapter = null;
			this.tableAdapterManager.DesignationsTableAdapter = this.designationsTableAdapter;
			this.tableAdapterManager.Duty_RosterTableAdapter = null;
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = null;
			this.tableAdapterManager.EmployeeDuesTableAdapter = null;
			this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
			this.tableAdapterManager.EmployeeTypesTableAdapter = null;
			this.tableAdapterManager.GendersTableAdapter = null;
			this.tableAdapterManager.HolidaysTableAdapter = null;
			this.tableAdapterManager.HTAdminsTableAdapter = null;
			this.tableAdapterManager.InActiveHistoriesTableAdapter = null;
			this.tableAdapterManager.LeavesTableAdapter = null;
			this.tableAdapterManager.LeaveStoresTableAdapter = null;
			this.tableAdapterManager.LeaveTypesTableAdapter = null;
			this.tableAdapterManager.LoansTableAdapter = this.loansTableAdapter;
			this.tableAdapterManager.MaritialStatusTableAdapter = null;
			this.tableAdapterManager.PaytimesTableAdapter = this.paytimesTableAdapter;
			this.tableAdapterManager.ReligionsTableAdapter = null;
			this.tableAdapterManager.SalariesTableAdapter = null;
			this.tableAdapterManager.SalaryGradesTableAdapter = null;
			this.tableAdapterManager.SalarySettingsTableAdapter = null;
			this.tableAdapterManager.SectionsTableAdapter = null;
			this.tableAdapterManager.ShadowEmployeesTableAdapter = null;
			this.tableAdapterManager.ShadowSalaryGradesTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationHistoriesTableAdapter = null;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// designationsTableAdapter
			// 
			this.designationsTableAdapter.ClearBeforeFill = true;
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
			// 
			// paytimesTableAdapter
			// 
			this.paytimesTableAdapter.ClearBeforeFill = true;
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataSource = this.homeTextileDBDataSet2;
			this.employeesBindingSource.Position = 0;
			// 
			// employeesBindingSource1
			// 
			this.employeesBindingSource1.DataMember = "Employees";
			this.employeesBindingSource1.DataSource = this.homeTextileDBDataSet2;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.empIdTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(idLabel);
			this.groupBox1.Controls.Add(this.idTextBox);
			this.groupBox1.Controls.Add(amountLabel);
			this.groupBox1.Controls.Add(this.amountTextBox);
			this.groupBox1.Controls.Add(dateLabel);
			this.groupBox1.Controls.Add(this.dateDateTimePicker);
			this.groupBox1.Controls.Add(installmentLabel);
			this.groupBox1.Controls.Add(this.installmentTextBox);
			this.groupBox1.Controls.Add(this.loansDataGridView);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(designationIdLabel1);
			this.groupBox1.Controls.Add(this.designationIdComboBox);
			this.groupBox1.Controls.Add(empFullNameLabel);
			this.groupBox1.Controls.Add(this.empFullNameTextBox);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(814, 291);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Loan List";
			// 
			// empIdTextBox
			// 
			this.empIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "Amount", true));
			this.empIdTextBox.Location = new System.Drawing.Point(562, 60);
			this.empIdTextBox.Name = "empIdTextBox";
			this.empIdTextBox.Size = new System.Drawing.Size(223, 22);
			this.empIdTextBox.TabIndex = 24;
			this.empIdTextBox.TextChanged += new System.EventHandler(this.empIdTextBox_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(477, 65);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 15);
			this.label2.TabIndex = 23;
			this.label2.Text = "Employee Id";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.LimeGreen;
			this.button5.Location = new System.Drawing.Point(630, 254);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(84, 31);
			this.button5.TabIndex = 22;
			this.button5.Text = "Update";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(563, 229);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(223, 22);
			this.idTextBox.TabIndex = 13;
			this.idTextBox.Visible = false;
			// 
			// amountTextBox
			// 
			this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "Amount", true));
			this.amountTextBox.Location = new System.Drawing.Point(563, 147);
			this.amountTextBox.Name = "amountTextBox";
			this.amountTextBox.Size = new System.Drawing.Size(223, 22);
			this.amountTextBox.TabIndex = 17;
			// 
			// dateDateTimePicker
			// 
			this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.loansBindingSource, "Date", true));
			this.dateDateTimePicker.Location = new System.Drawing.Point(563, 175);
			this.dateDateTimePicker.Name = "dateDateTimePicker";
			this.dateDateTimePicker.Size = new System.Drawing.Size(223, 22);
			this.dateDateTimePicker.TabIndex = 19;
			// 
			// installmentTextBox
			// 
			this.installmentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loansBindingSource, "Installment", true));
			this.installmentTextBox.Location = new System.Drawing.Point(563, 203);
			this.installmentTextBox.Name = "installmentTextBox";
			this.installmentTextBox.Size = new System.Drawing.Size(223, 22);
			this.installmentTextBox.TabIndex = 21;
			// 
			// loansDataGridView
			// 
			this.loansDataGridView.AutoGenerateColumns = false;
			this.loansDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.loansDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
			this.loansDataGridView.DataSource = this.loansBindingSource;
			this.loansDataGridView.Location = new System.Drawing.Point(6, 58);
			this.loansDataGridView.Name = "loansDataGridView";
			this.loansDataGridView.ReadOnly = true;
			this.loansDataGridView.Size = new System.Drawing.Size(455, 221);
			this.loansDataGridView.TabIndex = 12;
			this.loansDataGridView.DataSourceChanged += new System.EventHandler(this.loansDataGridView_CellContentClick);
			this.loansDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loansDataGridView_CellContentClick);
			this.loansDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.loansDataGridView_CellContentClick_1);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn7.DataSource = this.employeesBindingSource1;
			this.dataGridViewTextBoxColumn7.DisplayMember = "Emp_Id";
			this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
			this.dataGridViewTextBoxColumn7.HeaderText = "Employee Id";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn7.ValueMember = "Id";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn9.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn10.HeaderText = "Date";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Installment";
			this.dataGridViewTextBoxColumn11.HeaderText = "Installment";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button3.Location = new System.Drawing.Point(560, 254);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 31);
			this.button3.TabIndex = 12;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Green;
			this.button1.Location = new System.Drawing.Point(711, 254);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 31);
			this.button1.TabIndex = 10;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(8, 33);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(121, 22);
			this.textBox1.TabIndex = 9;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(124, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "Filter By Employee Id:";
			// 
			// designationIdComboBox
			// 
			this.designationIdComboBox.DataSource = this.designationsBindingSource;
			this.designationIdComboBox.DisplayMember = "Name";
			this.designationIdComboBox.FormattingEnabled = true;
			this.designationIdComboBox.Location = new System.Drawing.Point(562, 88);
			this.designationIdComboBox.Name = "designationIdComboBox";
			this.designationIdComboBox.Size = new System.Drawing.Size(224, 23);
			this.designationIdComboBox.TabIndex = 7;
			this.designationIdComboBox.ValueMember = "Id";
			// 
			// designationsBindingSource
			// 
			this.designationsBindingSource.DataMember = "Designations";
			this.designationsBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// empFullNameTextBox
			// 
			this.empFullNameTextBox.Location = new System.Drawing.Point(564, 118);
			this.empFullNameTextBox.Name = "empFullNameTextBox";
			this.empFullNameTextBox.Size = new System.Drawing.Size(222, 22);
			this.empFullNameTextBox.TabIndex = 2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.paytimesDataGridView);
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(3, 292);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(820, 365);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Paytime";
			// 
			// paytimesDataGridView
			// 
			this.paytimesDataGridView.AutoGenerateColumns = false;
			this.paytimesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.paytimesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loanIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
			this.paytimesDataGridView.DataSource = this.paytimesBindingSource;
			this.paytimesDataGridView.Location = new System.Drawing.Point(6, 21);
			this.paytimesDataGridView.Name = "paytimesDataGridView";
			this.paytimesDataGridView.Size = new System.Drawing.Size(455, 220);
			this.paytimesDataGridView.TabIndex = 11;
			// 
			// paytimesBindingSource
			// 
			this.paytimesBindingSource.DataMember = "Paytimes";
			this.paytimesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Green;
			this.button2.Location = new System.Drawing.Point(386, 247);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 31);
			this.button2.TabIndex = 11;
			this.button2.Text = "Update";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// paytimesBindingSource1
			// 
			this.paytimesBindingSource1.DataSource = this.homeTextileDBDataSet2;
			this.paytimesBindingSource1.Position = 0;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn2.DataSource = this.employeesBindingSource;
			this.dataGridViewTextBoxColumn2.HeaderText = "Employee Id";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn3.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn4.HeaderText = "Date";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Installment";
			this.dataGridViewTextBoxColumn5.HeaderText = "Installment";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// loanIdDataGridViewTextBoxColumn
			// 
			this.loanIdDataGridViewTextBoxColumn.DataPropertyName = "LoanId";
			this.loanIdDataGridViewTextBoxColumn.HeaderText = "LoanId";
			this.loanIdDataGridViewTextBoxColumn.Name = "loanIdDataGridViewTextBoxColumn";
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			// 
			// amountDataGridViewTextBoxColumn
			// 
			this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
			this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
			this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
			// 
			// Loan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(823, 657);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Loan";
			this.Text = "Loan";
			this.Load += new System.EventHandler(this.Loan_Load);
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.loansBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.loansDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.paytimesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paytimesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.paytimesBindingSource1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource loansBindingSource;
		private HomeTextileDBDataSet2TableAdapters.LoansTableAdapter loansTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.DesignationsTableAdapter designationsTableAdapter;
		private System.Windows.Forms.ComboBox designationIdComboBox;
		private System.Windows.Forms.TextBox empFullNameTextBox;
		private System.Windows.Forms.BindingSource designationsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.PaytimesTableAdapter paytimesTableAdapter;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource paytimesBindingSource;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.BindingSource employeesBindingSource1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridView loansDataGridView;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox amountTextBox;
		private System.Windows.Forms.DateTimePicker dateDateTimePicker;
		private System.Windows.Forms.TextBox installmentTextBox;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox empIdTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.BindingSource paytimesBindingSource1;
		private System.Windows.Forms.DataGridView paytimesDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loanIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
	}
}