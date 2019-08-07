namespace HomeTextileApp
{
	partial class ImportAttendance
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
			this.emp_CheckInOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.emp_CheckInOutTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.Emp_CheckInOutTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.emp_CheckInOutDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// emp_CheckInOutBindingSource
			// 
			this.emp_CheckInOutBindingSource.DataMember = "Emp_CheckInOut";
			this.emp_CheckInOutBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// emp_CheckInOutTableAdapter
			// 
			this.emp_CheckInOutTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = this.emp_CheckInOutTableAdapter;
			this.tableAdapterManager.EmployeesTableAdapter = null;
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
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
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
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn6});
			this.emp_CheckInOutDataGridView.DataSource = this.emp_CheckInOutBindingSource;
			this.emp_CheckInOutDataGridView.Location = new System.Drawing.Point(28, 52);
			this.emp_CheckInOutDataGridView.Name = "emp_CheckInOutDataGridView";
			this.emp_CheckInOutDataGridView.Size = new System.Drawing.Size(560, 490);
			this.emp_CheckInOutDataGridView.TabIndex = 1;
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
			this.dataGridViewTextBoxColumn3.HeaderText = "CHECKTIME";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "LOGID";
			this.dataGridViewTextBoxColumn4.HeaderText = "LOGID";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "MACHINEID";
			this.dataGridViewTextBoxColumn5.HeaderText = "MACHINEID";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsManual";
			this.dataGridViewCheckBoxColumn1.HeaderText = "IsManual";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			this.dataGridViewCheckBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "UpdatedBy";
			this.dataGridViewTextBoxColumn6.HeaderText = "Updated By";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Maroon;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(28, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 36);
			this.button1.TabIndex = 2;
			this.button1.Text = "Import Attendance";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ImportAttendance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.emp_CheckInOutDataGridView);
			this.Name = "ImportAttendance";
			this.Text = "ImportAttendance";
			this.Load += new System.EventHandler(this.ImportAttendance_Load);
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.emp_CheckInOutDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource emp_CheckInOutBindingSource;
		private HomeTextileDBDataSet2TableAdapters.Emp_CheckInOutTableAdapter emp_CheckInOutTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView emp_CheckInOutDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.Button button1;
	}
}