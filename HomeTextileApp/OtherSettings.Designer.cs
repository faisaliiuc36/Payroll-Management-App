namespace HomeTextileApp
{
	partial class OtherSettings
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
			this.bloodGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bloodGroupsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.BloodGroupsTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.designationsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.DesignationsTableAdapter();
			this.gendersTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.GendersTableAdapter();
			this.maritialStatusTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.MaritialStatusTableAdapter();
			this.religionsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.ReligionsTableAdapter();
			this.maritialStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.designationsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.designationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.gendersDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.maritialStatusDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button7 = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.button4 = new System.Windows.Forms.Button();
			this.religionsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.religionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.bloodGroupsDataGridView = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bloodGroupsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maritialStatusBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.designationsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).BeginInit();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gendersDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.maritialStatusDataGridView)).BeginInit();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.religionsDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.religionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bloodGroupsDataGridView)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bloodGroupsBindingSource
			// 
			this.bloodGroupsBindingSource.DataMember = "BloodGroups";
			this.bloodGroupsBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// bloodGroupsTableAdapter
			// 
			this.bloodGroupsTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.BloodGroupsTableAdapter = this.bloodGroupsTableAdapter;
			this.tableAdapterManager.BonusTableAdapter = null;
			this.tableAdapterManager.CompaniesTableAdapter = null;
			this.tableAdapterManager.DepartmentsTableAdapter = null;
			this.tableAdapterManager.DesignationsTableAdapter = this.designationsTableAdapter;
			this.tableAdapterManager.Duty_RosterTableAdapter = null;
			this.tableAdapterManager.Emp_CheckInOutTableAdapter = null;
			this.tableAdapterManager.EmployeesTableAdapter = null;
			this.tableAdapterManager.EmployeeTypesTableAdapter = null;
			this.tableAdapterManager.GendersTableAdapter = this.gendersTableAdapter;
			this.tableAdapterManager.HolidaysTableAdapter = null;
			this.tableAdapterManager.HTAdminsTableAdapter = null;
			this.tableAdapterManager.InActiveHistoriesTableAdapter = null;
			this.tableAdapterManager.LeavesTableAdapter = null;
			this.tableAdapterManager.LeaveStoresTableAdapter = null;
			this.tableAdapterManager.LeaveTypesTableAdapter = null;
			this.tableAdapterManager.LoansTableAdapter = null;
			this.tableAdapterManager.MaritialStatusTableAdapter = this.maritialStatusTableAdapter;
			this.tableAdapterManager.PaytimesTableAdapter = null;
			this.tableAdapterManager.ReligionsTableAdapter = this.religionsTableAdapter;
			this.tableAdapterManager.SalariesTableAdapter = null;
			this.tableAdapterManager.SalaryGradesTableAdapter = null;
			this.tableAdapterManager.SalarySettingsTableAdapter = null;
			this.tableAdapterManager.SectionsTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = null;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// designationsTableAdapter
			// 
			this.designationsTableAdapter.ClearBeforeFill = true;
			// 
			// gendersTableAdapter
			// 
			this.gendersTableAdapter.ClearBeforeFill = true;
			// 
			// maritialStatusTableAdapter
			// 
			this.maritialStatusTableAdapter.ClearBeforeFill = true;
			// 
			// religionsTableAdapter
			// 
			this.religionsTableAdapter.ClearBeforeFill = true;
			// 
			// maritialStatusBindingSource
			// 
			this.maritialStatusBindingSource.DataMember = "MaritialStatus";
			this.maritialStatusBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Controls.Add(this.designationsDataGridView);
			this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(255, 42);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(282, 299);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Designation";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Maroon;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.Location = new System.Drawing.Point(148, 258);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(116, 31);
			this.button2.TabIndex = 10;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// designationsDataGridView
			// 
			this.designationsDataGridView.AutoGenerateColumns = false;
			this.designationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.designationsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.designationsDataGridView.DataSource = this.designationsBindingSource;
			this.designationsDataGridView.Location = new System.Drawing.Point(36, 14);
			this.designationsDataGridView.Name = "designationsDataGridView";
			this.designationsDataGridView.Size = new System.Drawing.Size(228, 241);
			this.designationsDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn3.HeaderText = "Id";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Visible = false;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn4.HeaderText = "Name";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// designationsBindingSource
			// 
			this.designationsBindingSource.DataMember = "Designations";
			this.designationsBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button3);
			this.groupBox3.Controls.Add(this.gendersDataGridView);
			this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(543, 42);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(433, 299);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Gender";
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Maroon;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.Location = new System.Drawing.Point(133, 258);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(116, 31);
			this.button3.TabIndex = 11;
			this.button3.Text = "Delete";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// gendersDataGridView
			// 
			this.gendersDataGridView.AutoGenerateColumns = false;
			this.gendersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gendersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.gendersDataGridView.DataSource = this.gendersBindingSource;
			this.gendersDataGridView.Location = new System.Drawing.Point(30, 15);
			this.gendersDataGridView.Name = "gendersDataGridView";
			this.gendersDataGridView.Size = new System.Drawing.Size(219, 240);
			this.gendersDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn5.HeaderText = "Id";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn6.HeaderText = "Name";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// gendersBindingSource
			// 
			this.gendersBindingSource.DataMember = "Genders";
			this.gendersBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.maritialStatusDataGridView);
			this.groupBox4.Controls.Add(this.button7);
			this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(12, 347);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(237, 214);
			this.groupBox4.TabIndex = 3;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Maritial Status";
			// 
			// maritialStatusDataGridView
			// 
			this.maritialStatusDataGridView.AutoGenerateColumns = false;
			this.maritialStatusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.maritialStatusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
			this.maritialStatusDataGridView.DataSource = this.maritialStatusBindingSource;
			this.maritialStatusDataGridView.Location = new System.Drawing.Point(17, 16);
			this.maritialStatusDataGridView.Name = "maritialStatusDataGridView";
			this.maritialStatusDataGridView.Size = new System.Drawing.Size(214, 168);
			this.maritialStatusDataGridView.TabIndex = 9;
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
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.Maroon;
			this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button7.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button7.Location = new System.Drawing.Point(115, 182);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(116, 31);
			this.button7.TabIndex = 13;
			this.button7.Text = "Delete";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.button4);
			this.groupBox5.Controls.Add(this.religionsDataGridView);
			this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(255, 347);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(282, 214);
			this.groupBox5.TabIndex = 6;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Religion";
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Maroon;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button4.Location = new System.Drawing.Point(148, 183);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(116, 31);
			this.button4.TabIndex = 12;
			this.button4.Text = "Delete";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// religionsDataGridView
			// 
			this.religionsDataGridView.AutoGenerateColumns = false;
			this.religionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.religionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.religionsDataGridView.DataSource = this.religionsBindingSource;
			this.religionsDataGridView.Location = new System.Drawing.Point(36, 17);
			this.religionsDataGridView.Name = "religionsDataGridView";
			this.religionsDataGridView.Size = new System.Drawing.Size(228, 167);
			this.religionsDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn7.HeaderText = "Id";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Visible = false;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn8.HeaderText = "Name";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// religionsBindingSource
			// 
			this.religionsBindingSource.DataMember = "Religions";
			this.religionsBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button6.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button6.Location = new System.Drawing.Point(348, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(276, 39);
			this.button6.TabIndex = 9;
			this.button6.Text = "Discard All Changes";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button5.Location = new System.Drawing.Point(66, 3);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(276, 39);
			this.button5.TabIndex = 8;
			this.button5.Text = "Save All Changes";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// bloodGroupsDataGridView
			// 
			this.bloodGroupsDataGridView.AutoGenerateColumns = false;
			this.bloodGroupsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bloodGroupsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
			this.bloodGroupsDataGridView.DataSource = this.bloodGroupsBindingSource;
			this.bloodGroupsDataGridView.Location = new System.Drawing.Point(17, 15);
			this.bloodGroupsDataGridView.Name = "bloodGroupsDataGridView";
			this.bloodGroupsDataGridView.Size = new System.Drawing.Size(214, 240);
			this.bloodGroupsDataGridView.TabIndex = 1;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Maroon;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.Location = new System.Drawing.Point(115, 258);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(116, 31);
			this.button1.TabIndex = 9;
			this.button1.Text = "Delete";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.bloodGroupsDataGridView);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 42);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(237, 299);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Blood Groups";
			// 
			// OtherSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "OtherSettings";
			this.Text = "OtherSettings";
			this.Load += new System.EventHandler(this.OtherSettings_Load);
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bloodGroupsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maritialStatusBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.designationsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).EndInit();
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gendersDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
			this.groupBox4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.maritialStatusDataGridView)).EndInit();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.religionsDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.religionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bloodGroupsDataGridView)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource bloodGroupsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.BloodGroupsTableAdapter bloodGroupsTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private HomeTextileDBDataSet2TableAdapters.DesignationsTableAdapter designationsTableAdapter;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.BindingSource designationsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.GendersTableAdapter gendersTableAdapter;
		private System.Windows.Forms.DataGridView designationsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.BindingSource gendersBindingSource;
		private System.Windows.Forms.DataGridView gendersDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.GroupBox groupBox4;
		private HomeTextileDBDataSet2TableAdapters.MaritialStatusTableAdapter maritialStatusTableAdapter;
		private System.Windows.Forms.BindingSource maritialStatusBindingSource;
		private HomeTextileDBDataSet2TableAdapters.ReligionsTableAdapter religionsTableAdapter;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.BindingSource religionsBindingSource;
		private System.Windows.Forms.DataGridView religionsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.DataGridView maritialStatusDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridView bloodGroupsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}