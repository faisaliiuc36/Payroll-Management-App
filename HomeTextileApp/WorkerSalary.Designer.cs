namespace HomeTextileApp
{
	partial class WorkerSalary
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
			this.workerDesignationHistoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.workerDesignationHistoriesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.WorkerDesignationHistoriesTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.workerDesignationHistoriesDataGridView = new System.Windows.Forms.DataGridView();
			this.workerDesignationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.workerDesignationsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.WorkerDesignationsTableAdapter();
			this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.employeesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workerDesignationHistoriesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workerDesignationHistoriesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workerDesignationsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// workerDesignationHistoriesBindingSource
			// 
			this.workerDesignationHistoriesBindingSource.DataMember = "WorkerDesignationHistories";
			this.workerDesignationHistoriesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// workerDesignationHistoriesTableAdapter
			// 
			this.workerDesignationHistoriesTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.WorkerDesignationHistoriesTableAdapter = this.workerDesignationHistoriesTableAdapter;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = this.workerDesignationsTableAdapter;
			// 
			// workerDesignationHistoriesDataGridView
			// 
			this.workerDesignationHistoriesDataGridView.AutoGenerateColumns = false;
			this.workerDesignationHistoriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.workerDesignationHistoriesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.workerDesignationHistoriesDataGridView.DataSource = this.workerDesignationHistoriesBindingSource;
			this.workerDesignationHistoriesDataGridView.Location = new System.Drawing.Point(123, 36);
			this.workerDesignationHistoriesDataGridView.Name = "workerDesignationHistoriesDataGridView";
			this.workerDesignationHistoriesDataGridView.Size = new System.Drawing.Size(506, 468);
			this.workerDesignationHistoriesDataGridView.TabIndex = 1;
			// 
			// workerDesignationsBindingSource
			// 
			this.workerDesignationsBindingSource.DataMember = "WorkerDesignations";
			this.workerDesignationsBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// workerDesignationsTableAdapter
			// 
			this.workerDesignationsTableAdapter.ClearBeforeFill = true;
			// 
			// employeesBindingSource
			// 
			this.employeesBindingSource.DataMember = "Employees";
			this.employeesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// employeesTableAdapter
			// 
			this.employeesTableAdapter.ClearBeforeFill = true;
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
			this.dataGridViewTextBoxColumn2.DataSource = this.employeesBindingSource;
			this.dataGridViewTextBoxColumn2.DisplayMember = "Emp_Id";
			this.dataGridViewTextBoxColumn2.HeaderText = "Employee Id";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn2.ValueMember = "Id";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "WorkerDesignationId";
			this.dataGridViewTextBoxColumn3.DataSource = this.workerDesignationsBindingSource;
			this.dataGridViewTextBoxColumn3.DisplayMember = "Name";
			this.dataGridViewTextBoxColumn3.HeaderText = "Worker Designation";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn3.ValueMember = "Id";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "TechnicalAllowance";
			this.dataGridViewTextBoxColumn4.HeaderText = "Technical Allowance";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 120;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "From";
			this.dataGridViewTextBoxColumn5.HeaderText = "Effective From";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(254, 8);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(167, 22);
			this.textBox1.TabIndex = 7;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(120, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Search By EmployeeId:";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(473, 508);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 32);
			this.button5.TabIndex = 10;
			this.button5.Text = "Discard";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(392, 508);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 32);
			this.button2.TabIndex = 9;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(554, 508);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 8;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// WorkerSalary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.workerDesignationHistoriesDataGridView);
			this.Name = "WorkerSalary";
			this.Text = "WorkerSalary";
			this.Load += new System.EventHandler(this.WorkerSalary_Load);
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workerDesignationHistoriesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workerDesignationHistoriesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workerDesignationsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource workerDesignationHistoriesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.WorkerDesignationHistoriesTableAdapter workerDesignationHistoriesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridView workerDesignationHistoriesDataGridView;
		private HomeTextileDBDataSet2TableAdapters.WorkerDesignationsTableAdapter workerDesignationsTableAdapter;
		private System.Windows.Forms.BindingSource workerDesignationsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
	}
}