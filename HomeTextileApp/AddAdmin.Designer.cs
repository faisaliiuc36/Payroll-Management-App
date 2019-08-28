namespace HomeTextileApp
{
	partial class AddAdmin
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
			this.hTAdminsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.hTAdminsTableAdapter1 = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.HTAdminsTableAdapter();
			this.tableAdapterManager1 = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.button1 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.hTAdminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.hTAdminsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet1TableAdapters.HTAdminsTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet1TableAdapters.TableAdapterManager();
			this.hTAdminsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Admin = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hTAdminsBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hTAdminsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.hTAdminsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// hTAdminsBindingSource1
			// 
			this.hTAdminsBindingSource1.DataMember = "HTAdmins";
			this.hTAdminsBindingSource1.DataSource = this.homeTextileDBDataSet2;
			// 
			// hTAdminsTableAdapter1
			// 
			this.hTAdminsTableAdapter1.ClearBeforeFill = true;
			// 
			// tableAdapterManager1
			// 
			this.tableAdapterManager1.@__MigrationHistoryTableAdapter = null;
			this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager1.BloodGroupsTableAdapter = null;
			this.tableAdapterManager1.BonusTableAdapter = null;
			this.tableAdapterManager1.CompaniesTableAdapter = null;
			this.tableAdapterManager1.DepartmentsTableAdapter = null;
			this.tableAdapterManager1.DesignationsTableAdapter = null;
			this.tableAdapterManager1.Duty_RosterTableAdapter = null;
			this.tableAdapterManager1.Emp_CheckInOutTableAdapter = null;
			this.tableAdapterManager1.EmployeesTableAdapter = null;
			this.tableAdapterManager1.EmployeeTypesTableAdapter = null;
			this.tableAdapterManager1.GendersTableAdapter = null;
			this.tableAdapterManager1.HolidaysTableAdapter = null;
			this.tableAdapterManager1.HTAdminsTableAdapter = this.hTAdminsTableAdapter1;
			this.tableAdapterManager1.InActiveHistoriesTableAdapter = null;
			this.tableAdapterManager1.LeavesTableAdapter = null;
			this.tableAdapterManager1.LeaveStoresTableAdapter = null;
			this.tableAdapterManager1.LeaveTypesTableAdapter = null;
			this.tableAdapterManager1.LoansTableAdapter = null;
			this.tableAdapterManager1.MaritialStatusTableAdapter = null;
			this.tableAdapterManager1.PaytimesTableAdapter = null;
			this.tableAdapterManager1.ReligionsTableAdapter = null;
			this.tableAdapterManager1.SalariesTableAdapter = null;
			this.tableAdapterManager1.SalaryGradesTableAdapter = null;
			this.tableAdapterManager1.SalarySettingsTableAdapter = null;
			this.tableAdapterManager1.SectionsTableAdapter = null;
			this.tableAdapterManager1.ShiftsTableAdapter = null;
			this.tableAdapterManager1.UnitsTableAdapter = null;
			this.tableAdapterManager1.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager1.WorkerDesignationsTableAdapter = null;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Maroon;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(576, 465);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 31);
			this.button1.TabIndex = 11;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button6.Location = new System.Drawing.Point(409, 465);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(161, 31);
			this.button6.TabIndex = 10;
			this.button6.Text = "Discard All Changes";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button5.Location = new System.Drawing.Point(662, 464);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(95, 32);
			this.button5.TabIndex = 9;
			this.button5.Text = "Save";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// hTAdminsTableAdapter
			// 
			this.hTAdminsTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.HTAdminsTableAdapter = this.hTAdminsTableAdapter;
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
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// hTAdminsDataGridView
			// 
			this.hTAdminsDataGridView.AutoGenerateColumns = false;
			this.hTAdminsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.hTAdminsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Admin,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6});
			this.hTAdminsDataGridView.DataSource = this.hTAdminsBindingSource1;
			this.hTAdminsDataGridView.Location = new System.Drawing.Point(12, 12);
			this.hTAdminsDataGridView.Name = "hTAdminsDataGridView";
			this.hTAdminsDataGridView.Size = new System.Drawing.Size(745, 447);
			this.hTAdminsDataGridView.TabIndex = 11;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "UserName";
			this.dataGridViewTextBoxColumn2.HeaderText = "UserName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Password";
			this.dataGridViewTextBoxColumn3.HeaderText = "Password";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// Admin
			// 
			this.Admin.DataPropertyName = "Admin";
			this.Admin.HeaderText = "Admin";
			this.Admin.IndeterminateValue = "0";
			this.Admin.Name = "Admin";
			// 
			// dataGridViewCheckBoxColumn2
			// 
			this.dataGridViewCheckBoxColumn2.DataPropertyName = "Attendance";
			this.dataGridViewCheckBoxColumn2.HeaderText = "Attendance";
			this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			// 
			// dataGridViewCheckBoxColumn3
			// 
			this.dataGridViewCheckBoxColumn3.DataPropertyName = "Employee";
			this.dataGridViewCheckBoxColumn3.HeaderText = "Employee";
			this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
			// 
			// dataGridViewCheckBoxColumn4
			// 
			this.dataGridViewCheckBoxColumn4.DataPropertyName = "Settings";
			this.dataGridViewCheckBoxColumn4.HeaderText = "Settings";
			this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
			// 
			// dataGridViewCheckBoxColumn5
			// 
			this.dataGridViewCheckBoxColumn5.DataPropertyName = "LeaveAndHoliday";
			this.dataGridViewCheckBoxColumn5.HeaderText = "LeaveAndHoliday";
			this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
			// 
			// dataGridViewCheckBoxColumn6
			// 
			this.dataGridViewCheckBoxColumn6.DataPropertyName = "Report";
			this.dataGridViewCheckBoxColumn6.HeaderText = "Report";
			this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
			// 
			// AddAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.hTAdminsDataGridView);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Name = "AddAdmin";
			this.Text = "AddAdmin";
			this.Load += new System.EventHandler(this.AddAdmin_Load);
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hTAdminsBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hTAdminsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.hTAdminsDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource hTAdminsBindingSource1;
		private HomeTextileDBDataSet2TableAdapters.HTAdminsTableAdapter hTAdminsTableAdapter1;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.BindingSource hTAdminsBindingSource;
		private HomeTextileDBDataSet1TableAdapters.HTAdminsTableAdapter hTAdminsTableAdapter;
		private HomeTextileDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView hTAdminsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Admin;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
	}
}