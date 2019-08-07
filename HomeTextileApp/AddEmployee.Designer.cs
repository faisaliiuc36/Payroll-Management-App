namespace HomeTextileApp
{
	partial class AddEmployee
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
			this.salaryGradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet1 = new HomeTextileApp.HomeTextileDBDataSet1();
			this.salaryGradesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet1TableAdapters.SalaryGradesTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet1TableAdapters.TableAdapterManager();
			((System.ComponentModel.ISupportInitialize)(this.salaryGradesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// salaryGradesBindingSource
			// 
			this.salaryGradesBindingSource.DataMember = "SalaryGrades";
			this.salaryGradesBindingSource.DataSource = this.homeTextileDBDataSet1;
			// 
			// homeTextileDBDataSet1
			// 
			this.homeTextileDBDataSet1.DataSetName = "HomeTextileDBDataSet1";
			this.homeTextileDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// salaryGradesTableAdapter
			// 
			this.salaryGradesTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.LeaveStoresTableAdapter = null;
			this.tableAdapterManager.LeaveTypesTableAdapter = null;
			this.tableAdapterManager.LoansTableAdapter = null;
			this.tableAdapterManager.MaritialStatusTableAdapter = null;
			this.tableAdapterManager.PaytimesTableAdapter = null;
			this.tableAdapterManager.ReligionsTableAdapter = null;
			this.tableAdapterManager.SalariesTableAdapter = null;
			this.tableAdapterManager.SalaryGradesTableAdapter = this.salaryGradesTableAdapter;
			this.tableAdapterManager.SalarySettingsTableAdapter = null;
			this.tableAdapterManager.SectionsTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// AddEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(854, 749);
			this.Name = "AddEmployee";
			this.Text = "AddEmployee";
			this.Load += new System.EventHandler(this.AddEmployee_Load);
			((System.ComponentModel.ISupportInitialize)(this.salaryGradesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private HomeTextileDBDataSet1 homeTextileDBDataSet1;
		private System.Windows.Forms.BindingSource salaryGradesBindingSource;
		private HomeTextileDBDataSet1TableAdapters.SalaryGradesTableAdapter salaryGradesTableAdapter;
		private HomeTextileDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
	}
}