namespace HomeTextileApp
{
	partial class LeaveSetting
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaveSetting));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.leaveTypesDataGridView = new System.Windows.Forms.DataGridView();
			this.leaveTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.leaveTypesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.LeaveTypesTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.leaveTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.leaveTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.leaveStoresTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.LeaveStoresTableAdapter();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.leaveTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.Paid = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IsIncremental = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.leaveStoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.leaveStoresDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingNavigator)).BeginInit();
			this.leaveTypesBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.leaveTypesDataGridView);
			this.groupBox1.Location = new System.Drawing.Point(90, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(679, 166);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "LeaveType";
			// 
			// leaveTypesDataGridView
			// 
			this.leaveTypesDataGridView.AutoGenerateColumns = false;
			this.leaveTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.leaveTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.Paid,
            this.IsIncremental,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.leaveTypesDataGridView.DataSource = this.leaveTypesBindingSource;
			this.leaveTypesDataGridView.Location = new System.Drawing.Point(6, 16);
			this.leaveTypesDataGridView.Name = "leaveTypesDataGridView";
			this.leaveTypesDataGridView.Size = new System.Drawing.Size(661, 145);
			this.leaveTypesDataGridView.TabIndex = 0;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.leaveStoresDataGridView);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Location = new System.Drawing.Point(31, 191);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(738, 369);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Add Yearly Leave";
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
			this.tableAdapterManager.LeaveStoresTableAdapter = null;
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
			// leaveTypesBindingNavigator
			// 
			this.leaveTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.leaveTypesBindingNavigator.BindingSource = this.leaveTypesBindingSource;
			this.leaveTypesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.leaveTypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.leaveTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.leaveTypesBindingNavigatorSaveItem});
			this.leaveTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.leaveTypesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.leaveTypesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.leaveTypesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.leaveTypesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.leaveTypesBindingNavigator.Name = "leaveTypesBindingNavigator";
			this.leaveTypesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.leaveTypesBindingNavigator.Size = new System.Drawing.Size(804, 25);
			this.leaveTypesBindingNavigator.TabIndex = 2;
			this.leaveTypesBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// leaveTypesBindingNavigatorSaveItem
			// 
			this.leaveTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.leaveTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("leaveTypesBindingNavigatorSaveItem.Image")));
			this.leaveTypesBindingNavigatorSaveItem.Name = "leaveTypesBindingNavigatorSaveItem";
			this.leaveTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.leaveTypesBindingNavigatorSaveItem.Text = "Save Data";
			this.leaveTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.leaveTypesBindingNavigatorSaveItem_Click);
			// 
			// leaveStoresTableAdapter
			// 
			this.leaveStoresTableAdapter.ClearBeforeFill = true;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(59, 47);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
			this.dateTimePicker1.TabIndex = 1;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Year";
			// 
			// leaveTypesBindingSource1
			// 
			this.leaveTypesBindingSource1.DataMember = "LeaveTypes";
			this.leaveTypesBindingSource1.DataSource = this.homeTextileDBDataSet2;
			// 
			// Paid
			// 
			this.Paid.DataPropertyName = "Paid";
			this.Paid.HeaderText = "Paid";
			this.Paid.Name = "Paid";
			// 
			// IsIncremental
			// 
			this.IsIncremental.DataPropertyName = "IsIncremental";
			this.IsIncremental.HeaderText = "IsIncremental";
			this.IsIncremental.Name = "IsIncremental";
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
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn1});
			this.leaveStoresDataGridView.DataSource = this.leaveStoresBindingSource;
			this.leaveStoresDataGridView.Location = new System.Drawing.Point(168, 19);
			this.leaveStoresDataGridView.Name = "leaveStoresDataGridView";
			this.leaveStoresDataGridView.Size = new System.Drawing.Size(558, 220);
			this.leaveStoresDataGridView.TabIndex = 2;
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
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "DaysCountForEL";
			this.dataGridViewTextBoxColumn5.HeaderText = "DaysCountForEL";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn7.HeaderText = "Employee Id";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn8.HeaderText = "Count";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Year";
			this.dataGridViewTextBoxColumn9.HeaderText = "Year";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn6.HeaderText = "Id";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Visible = false;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn10.HeaderText = "Employee Id";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "LeaveTypeId";
			this.dataGridViewTextBoxColumn11.DataSource = this.leaveTypesBindingSource1;
			this.dataGridViewTextBoxColumn11.DisplayMember = "Tags";
			this.dataGridViewTextBoxColumn11.HeaderText = "Leave Type";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn11.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn11.ValueMember = "Id";
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "Count";
			this.dataGridViewTextBoxColumn12.HeaderText = "Count";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "Year";
			this.dataGridViewTextBoxColumn13.HeaderText = "Year";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsSingleEmployee";
			this.dataGridViewCheckBoxColumn1.HeaderText = "IsSingleEmployee";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// LeaveSetting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.leaveTypesBindingNavigator);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "LeaveSetting";
			this.Text = "LeaveSetting";
			this.Load += new System.EventHandler(this.LeaveSetting_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingNavigator)).EndInit();
			this.leaveTypesBindingNavigator.ResumeLayout(false);
			this.leaveTypesBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.leaveTypesBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.leaveStoresDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource leaveTypesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.LeaveTypesTableAdapter leaveTypesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator leaveTypesBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton leaveTypesBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView leaveTypesDataGridView;
		private System.Windows.Forms.BindingSource leaveStoresBindingSource;
		private HomeTextileDBDataSet2TableAdapters.LeaveStoresTableAdapter leaveStoresTableAdapter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.BindingSource leaveTypesBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Paid;
		private System.Windows.Forms.DataGridViewCheckBoxColumn IsIncremental;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridView leaveStoresDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
	}
}