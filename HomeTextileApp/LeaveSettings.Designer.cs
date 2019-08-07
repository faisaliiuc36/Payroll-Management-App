namespace HomeTextileApp
{
	partial class LeaveSettings
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
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.leaveTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.leaveTypesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.LeaveTypesTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.leaveStoresTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.LeaveStoresTableAdapter();
			this.leaveTypesDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.leaveStoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.leaveStoresDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.IsSingleEmployee = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.LeaveTypeId = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.leaveTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.EmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Year = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// leaveTypesBindingSource
			// 
			this.leaveTypesBindingSource.DataMember = "LeaveTypes";
			this.leaveTypesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// leaveTypesTableAdapter
			// 
			this.leaveTypesTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BloodGroupsTableAdapter = null;
			this.tableAdapterManager.BonusTableAdapter = null;
			this.tableAdapterManager.CompaniesTableAdapter = null;
			this.tableAdapterManager.DepartmentsTableAdapter = null;
			this.tableAdapterManager.DesignationsTableAdapter = null;
			this.tableAdapterManager.Duty_RosterTableAdapter = null;
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = null;
			this.tableAdapterManager.EmployeesTableAdapter = null;
			this.tableAdapterManager.EmployeeTypesTableAdapter = null;
			this.tableAdapterManager.GendersTableAdapter = null;
			this.tableAdapterManager.HolidaysTableAdapter = null;
			this.tableAdapterManager.HTAdminsTableAdapter = null;
			this.tableAdapterManager.InActiveHistoriesTableAdapter = null;
			this.tableAdapterManager.LeavesTableAdapter = null;
			this.tableAdapterManager.LeaveStoresTableAdapter = this.leaveStoresTableAdapter;
			this.tableAdapterManager.LeaveTypesTableAdapter = this.leaveTypesTableAdapter;
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
			// leaveStoresTableAdapter
			// 
			this.leaveStoresTableAdapter.ClearBeforeFill = true;
			// 
			// leaveTypesDataGridView
			// 
			this.leaveTypesDataGridView.AutoGenerateColumns = false;
			this.leaveTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.leaveTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn5});
			this.leaveTypesDataGridView.DataSource = this.leaveTypesBindingSource;
			this.leaveTypesDataGridView.Location = new System.Drawing.Point(11, 15);
			this.leaveTypesDataGridView.Name = "leaveTypesDataGridView";
			this.leaveTypesDataGridView.Size = new System.Drawing.Size(661, 205);
			this.leaveTypesDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Type";
			this.dataGridViewTextBoxColumn2.HeaderText = "Type";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Description";
			this.dataGridViewTextBoxColumn3.HeaderText = "Description";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Tags";
			this.dataGridViewTextBoxColumn4.HeaderText = "Tags";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "Paid";
			this.dataGridViewCheckBoxColumn1.HeaderText = "Paid";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// dataGridViewCheckBoxColumn2
			// 
			this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsIncremental";
			this.dataGridViewCheckBoxColumn2.HeaderText = "IsIncremental";
			this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "DaysCountForEL";
			this.dataGridViewTextBoxColumn5.HeaderText = "DaysCountForEL";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// leaveStoresBindingSource
			// 
			this.leaveStoresBindingSource.DataMember = "FK_dbo.LeaveStores_dbo.LeaveTypes_LeaveTypeId";
			this.leaveStoresBindingSource.DataSource = this.leaveTypesBindingSource;
			// 
			// leaveStoresDataGridView
			// 
			this.leaveStoresDataGridView.AutoGenerateColumns = false;
			this.leaveStoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.leaveStoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.IsSingleEmployee,
            this.LeaveTypeId,
            this.EmployeeId,
            this.Count,
            this.Year});
			this.leaveStoresDataGridView.DataSource = this.leaveStoresBindingSource;
			this.leaveStoresDataGridView.Location = new System.Drawing.Point(131, 10);
			this.leaveStoresDataGridView.Name = "leaveStoresDataGridView";
			this.leaveStoresDataGridView.Size = new System.Drawing.Size(541, 259);
			this.leaveStoresDataGridView.TabIndex = 2;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn6.HeaderText = "Id";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Visible = false;
			// 
			// IsSingleEmployee
			// 
			this.IsSingleEmployee.DataPropertyName = "IsSingleEmployee";
			this.IsSingleEmployee.HeaderText = "IsSingleEmployee";
			this.IsSingleEmployee.Name = "IsSingleEmployee";
			// 
			// LeaveTypeId
			// 
			this.LeaveTypeId.DataPropertyName = "LeaveTypeId";
			this.LeaveTypeId.DataSource = this.leaveTypesBindingSource1;
			this.LeaveTypeId.DisplayMember = "Tags";
			this.LeaveTypeId.HeaderText = "Leave Type";
			this.LeaveTypeId.Name = "LeaveTypeId";
			this.LeaveTypeId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.LeaveTypeId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.LeaveTypeId.ValueMember = "Id";
			// 
			// leaveTypesBindingSource1
			// 
			this.leaveTypesBindingSource1.DataMember = "LeaveTypes";
			this.leaveTypesBindingSource1.DataSource = this.homeTextileDBDataSet2;
			// 
			// EmployeeId
			// 
			this.EmployeeId.DataPropertyName = "EmployeeId";
			this.EmployeeId.HeaderText = "EmployeeId";
			this.EmployeeId.Name = "EmployeeId";
			// 
			// Count
			// 
			this.Count.DataPropertyName = "Count";
			this.Count.HeaderText = "Count";
			this.Count.Name = "Count";
			// 
			// Year
			// 
			this.Year.DataPropertyName = "Year";
			this.Year.HeaderText = "Year";
			this.Year.Name = "Year";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.leaveTypesDataGridView);
			this.groupBox1.Location = new System.Drawing.Point(47, 9);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(678, 251);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Leave Type";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lime;
			this.button3.Location = new System.Drawing.Point(597, 222);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 5;
			this.button3.Text = "Save";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Red;
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(516, 222);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 6;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button4);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.leaveStoresDataGridView);
			this.groupBox2.Location = new System.Drawing.Point(47, 258);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(678, 304);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add Leave Yearly";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lime;
			this.button4.Location = new System.Drawing.Point(597, 275);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 6;
			this.button4.Text = "Save";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Red;
			this.button1.Location = new System.Drawing.Point(516, 275);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Year";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(40, 44);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
			this.dateTimePicker1.TabIndex = 3;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn7.HeaderText = "EmployeeId";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "LeaveTypeId";
			this.dataGridViewTextBoxColumn8.HeaderText = "LeaveTypeId";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn9.HeaderText = "Count";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Year";
			this.dataGridViewTextBoxColumn10.HeaderText = "Year";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// LeaveSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 591);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "LeaveSettings";
			this.Text = "LeaveSettings";
			this.Load += new System.EventHandler(this.LeaveSettings_Load);
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource leaveTypesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.LeaveTypesTableAdapter leaveTypesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView leaveTypesDataGridView;
		private HomeTextileDBDataSet2TableAdapters.LeaveStoresTableAdapter leaveStoresTableAdapter;
		private System.Windows.Forms.BindingSource leaveStoresBindingSource;
		private System.Windows.Forms.DataGridView leaveStoresDataGridView;
		private System.Windows.Forms.BindingSource leaveTypesBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsSingleEmployee;
		private System.Windows.Forms.DataGridViewComboBoxColumn LeaveTypeId;
		private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Count;
		private System.Windows.Forms.DataGridViewTextBoxColumn Year;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}