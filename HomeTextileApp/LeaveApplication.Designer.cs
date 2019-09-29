namespace HomeTextileApp
{
	partial class LeaveApplication
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.leavesDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.leaveTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leavesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.leaveTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.leavesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.LeavesTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.leaveTypesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.LeaveTypesTableAdapter();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fKdboUnitsdboCompaniesCompanyIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.companiesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter();
			this.unitsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter();
			this.departmentsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter();
			this.sectionsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leavesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource1)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fKdboUnitsdboCompaniesCompanyIdBindingSource)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.leavesDataGridView);
			this.groupBox1.Location = new System.Drawing.Point(345, 117);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(458, 442);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Application List";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.Location = new System.Drawing.Point(296, 409);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 27);
			this.button2.TabIndex = 2;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(377, 409);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 27);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// leavesDataGridView
			// 
			this.leavesDataGridView.AutoGenerateColumns = false;
			this.leavesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.leavesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.leavesDataGridView.DataSource = this.leavesBindingSource;
			this.leavesDataGridView.Location = new System.Drawing.Point(6, 19);
			this.leavesDataGridView.Name = "leavesDataGridView";
			this.leavesDataGridView.Size = new System.Drawing.Size(446, 384);
			this.leavesDataGridView.TabIndex = 0;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeId";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "LeaveTypeId";
			this.dataGridViewTextBoxColumn3.DataSource = this.leaveTypesBindingSource;
			this.dataGridViewTextBoxColumn3.DisplayMember = "Tags";
			this.dataGridViewTextBoxColumn3.HeaderText = "LeaveType";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn3.ValueMember = "Id";
			// 
			// leaveTypesBindingSource
			// 
			this.leaveTypesBindingSource.DataMember = "LeaveTypes";
			this.leaveTypesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "From";
			this.dataGridViewTextBoxColumn4.HeaderText = "From";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "To";
			this.dataGridViewTextBoxColumn5.HeaderText = "To";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// leavesBindingSource
			// 
			this.leavesBindingSource.DataMember = "Leaves";
			this.leavesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// leaveTypesBindingSource1
			// 
			this.leaveTypesBindingSource1.DataMember = "LeaveTypes";
			this.leaveTypesBindingSource1.DataSource = this.homeTextileDBDataSet2;
			// 
			// leavesTableAdapter
			// 
			this.leavesTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.DesignationsTableAdapter = null;
			this.tableAdapterManager.Duty_RosterTableAdapter = null;
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = null;
			this.tableAdapterManager.EmployeeDuesTableAdapter = null;
			this.tableAdapterManager.EmployeesTableAdapter = null;
			this.tableAdapterManager.EmployeeTypesTableAdapter = null;
			this.tableAdapterManager.GendersTableAdapter = null;
			this.tableAdapterManager.HolidaysTableAdapter = null;
			this.tableAdapterManager.HTAdminsTableAdapter = null;
			this.tableAdapterManager.InActiveHistoriesTableAdapter = null;
			this.tableAdapterManager.LeavesTableAdapter = this.leavesTableAdapter;
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
			this.tableAdapterManager.ShadowEmployeesTableAdapter = null;
			this.tableAdapterManager.ShadowSalaryGradesTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationHistoriesTableAdapter = null;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// leaveTypesTableAdapter
			// 
			this.leaveTypesTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.textBox1);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Location = new System.Drawing.Point(12, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(780, 77);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Filter Application";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(26, 43);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(146, 20);
			this.textBox1.TabIndex = 9;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(23, 26);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(120, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Search By Employee Id:";
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
			// fKdboUnitsdboCompaniesCompanyIdBindingSource
			// 
			this.fKdboUnitsdboCompaniesCompanyIdBindingSource.DataMember = "FK_dbo.Units_dbo.Companies_CompanyId";
			this.fKdboUnitsdboCompaniesCompanyIdBindingSource.DataSource = this.companiesBindingSource;
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(199, 26);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Year:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(202, 43);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 11;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Location = new System.Drawing.Point(12, 117);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(327, 436);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Leave History";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(6, 19);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(315, 349);
			this.dataGridView1.TabIndex = 14;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(72, 387);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(0, 15);
			this.label7.TabIndex = 13;
			// 
			// LeaveApplication
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "LeaveApplication";
			this.Text = "LeaveApplication";
			this.Load += new System.EventHandler(this.LeaveApplication_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.leavesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leavesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fKdboUnitsdboCompaniesCompanyIdBindingSource)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource leavesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.LeavesTableAdapter leavesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView leavesDataGridView;
		private System.Windows.Forms.BindingSource leaveTypesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.LeaveTypesTableAdapter leaveTypesTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.BindingSource leaveTypesBindingSource1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource companiesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter companiesTableAdapter;
		private System.Windows.Forms.BindingSource fKdboUnitsdboCompaniesCompanyIdBindingSource;
		private System.Windows.Forms.BindingSource unitsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter unitsTableAdapter;
		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
		private System.Windows.Forms.BindingSource sectionsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter sectionsTableAdapter;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}