namespace HomeTextileApp
{
	partial class Manuel_Attendance
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
			System.Windows.Forms.Label emp_IdLabel;
			System.Windows.Forms.Label cHECKTIMELabel;
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.emp_IdTextBox = new System.Windows.Forms.TextBox();
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.cHECKTIMEDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.emp_CheckInOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button1 = new System.Windows.Forms.Button();
			this.employeesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.emp_CheckInOutTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.Emp_CheckInOutTableAdapter();
			this.emp_CheckInOutDataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.empCheckInOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.OT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.InTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OutTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			emp_IdLabel = new System.Windows.Forms.Label();
			cHECKTIMELabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empCheckInOutBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// emp_IdLabel
			// 
			emp_IdLabel.AutoSize = true;
			emp_IdLabel.Location = new System.Drawing.Point(89, 22);
			emp_IdLabel.Name = "emp_IdLabel";
			emp_IdLabel.Size = new System.Drawing.Size(43, 13);
			emp_IdLabel.TabIndex = 1;
			emp_IdLabel.Text = "Emp Id:";
			// 
			// cHECKTIMELabel
			// 
			cHECKTIMELabel.AutoSize = true;
			cHECKTIMELabel.Location = new System.Drawing.Point(262, 25);
			cHECKTIMELabel.Name = "cHECKTIMELabel";
			cHECKTIMELabel.Size = new System.Drawing.Size(30, 13);
			cHECKTIMELabel.TabIndex = 2;
			cHECKTIMELabel.Text = "Date";
			// 
			// emp_IdTextBox
			// 
			this.emp_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Id", true));
			this.emp_IdTextBox.Location = new System.Drawing.Point(138, 22);
			this.emp_IdTextBox.Name = "emp_IdTextBox";
			this.emp_IdTextBox.Size = new System.Drawing.Size(118, 20);
			this.emp_IdTextBox.TabIndex = 2;
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "Employees";
			this.employeesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// cHECKTIMEDateTimePicker
			// 
			this.cHECKTIMEDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.emp_CheckInOutBindingSource, "CHECKTIME", true));
			this.cHECKTIMEDateTimePicker.Location = new System.Drawing.Point(298, 22);
			this.cHECKTIMEDateTimePicker.Name = "cHECKTIMEDateTimePicker";
			this.cHECKTIMEDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.cHECKTIMEDateTimePicker.TabIndex = 3;
			// 
			// emp_CheckInOutBindingSource
			// 
			this.emp_CheckInOutBindingSource.DataMember = "Emp_CheckInOut";
			this.emp_CheckInOutBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(526, 18);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(94, 26);
			this.button1.TabIndex = 4;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = this.emp_CheckInOutTableAdapter;
			this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
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
			this.tableAdapterManager.SectionsTableAdapter = null;
			this.tableAdapterManager.ShadowEmployeesTableAdapter = null;
			this.tableAdapterManager.ShadowSalaryGradesTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// emp_CheckInOutTableAdapter
			// 
			this.emp_CheckInOutTableAdapter.ClearBeforeFill = true;
			// 
			// emp_CheckInOutDataGridView
			// 
			this.emp_CheckInOutDataGridView.AutoGenerateColumns = false;
			this.emp_CheckInOutDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.emp_CheckInOutDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.OT,
            this.dataGridViewTextBoxColumn6,
            this.InTime,
            this.OutTime});
			this.emp_CheckInOutDataGridView.DataSource = this.emp_CheckInOutBindingSource;
			this.emp_CheckInOutDataGridView.Location = new System.Drawing.Point(25, 78);
			this.emp_CheckInOutDataGridView.Name = "emp_CheckInOutDataGridView";
			this.emp_CheckInOutDataGridView.Size = new System.Drawing.Size(734, 423);
			this.emp_CheckInOutDataGridView.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(135, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(0, 15);
			this.label1.TabIndex = 6;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.Location = new System.Drawing.Point(629, 507);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(130, 34);
			this.button2.TabIndex = 7;
			this.button2.Text = "Save All";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// empCheckInOutBindingSource
			// 
			this.empCheckInOutBindingSource.DataMember = "Emp_CheckInOut";
			this.empCheckInOutBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// dataGridViewTextBoxColumn7
			// 
			dataGridViewCellStyle2.Format = "T";
			dataGridViewCellStyle2.NullValue = null;
			this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewTextBoxColumn7.HeaderText = "In Time";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "UpdatedBy";
			this.dataGridViewTextBoxColumn8.HeaderText = "OutTime";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "UserId";
			this.dataGridViewTextBoxColumn2.HeaderText = "UserId";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "CHECKTIME";
			this.dataGridViewTextBoxColumn3.HeaderText = "Date";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "LOGID";
			this.dataGridViewTextBoxColumn4.HeaderText = "LOGID";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Visible = false;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "MACHINEID";
			this.dataGridViewTextBoxColumn5.HeaderText = "MACHINEID";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// dataGridViewCheckBoxColumn2
			// 
			this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsAbsent";
			this.dataGridViewCheckBoxColumn2.HeaderText = "IsAbsent";
			this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsManual";
			this.dataGridViewCheckBoxColumn1.HeaderText = "IsManual";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// OT
			// 
			this.OT.DataPropertyName = "OT";
			this.OT.HeaderText = "OT(Hour)";
			this.OT.Name = "OT";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "UpdatedBy";
			dataGridViewCellStyle1.Format = "T";
			dataGridViewCellStyle1.NullValue = null;
			this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewTextBoxColumn6.HeaderText = "UpdatedBy";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// InTime
			// 
			this.InTime.HeaderText = "In Time";
			this.InTime.Name = "InTime";
			// 
			// OutTime
			// 
			this.OutTime.HeaderText = "Out Time";
			this.OutTime.Name = "OutTime";
			// 
			// Manuel_Attendance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.emp_CheckInOutDataGridView);
			this.Controls.Add(this.button1);
			this.Controls.Add(cHECKTIMELabel);
			this.Controls.Add(this.cHECKTIMEDateTimePicker);
			this.Controls.Add(emp_IdLabel);
			this.Controls.Add(this.emp_IdTextBox);
			this.Name = "Manuel_Attendance";
			this.Text = "Manual_Attendance";
			this.Load += new System.EventHandler(this.Manuel_Attendance_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empCheckInOutBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.TextBox emp_IdTextBox;
		private HomeTextileDBDataSet2TableAdapters.Emp_CheckInOutTableAdapter emp_CheckInOutTableAdapter;
		private System.Windows.Forms.BindingSource emp_CheckInOutBindingSource;
		private System.Windows.Forms.DateTimePicker cHECKTIMEDateTimePicker;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView emp_CheckInOutDataGridView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.BindingSource empCheckInOutBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn OT;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn InTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn OutTime;
	}
}