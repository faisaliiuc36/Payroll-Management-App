namespace HomeTextileApp
{
	partial class Shift
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shift));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.shiftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.shiftsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.ShiftsTableAdapter();
			this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager();
			this.shiftsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.shiftsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.shiftsDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.shiftsBindingNavigator)).BeginInit();
			this.shiftsBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.shiftsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.shiftsDataGridView);
			this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(788, 519);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Shift Grid View";
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// shiftsBindingSource
			// 
			this.shiftsBindingSource.DataMember = "Shifts";
			this.shiftsBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// shiftsTableAdapter
			// 
			this.shiftsTableAdapter.ClearBeforeFill = true;
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
			this.tableAdapterManager.SalaryGradesTableAdapter = null;
			this.tableAdapterManager.SalarySettingsTableAdapter = null;
			this.tableAdapterManager.SectionsTableAdapter = null;
			this.tableAdapterManager.ShiftsTableAdapter = this.shiftsTableAdapter;
			this.tableAdapterManager.UnitsTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			this.tableAdapterManager.WorkerDesignationsTableAdapter = null;
			// 
			// shiftsBindingNavigator
			// 
			this.shiftsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.shiftsBindingNavigator.BindingSource = this.shiftsBindingSource;
			this.shiftsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.shiftsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.shiftsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.shiftsBindingNavigatorSaveItem});
			this.shiftsBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.shiftsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.shiftsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.shiftsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.shiftsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.shiftsBindingNavigator.Name = "shiftsBindingNavigator";
			this.shiftsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.shiftsBindingNavigator.Size = new System.Drawing.Size(804, 25);
			this.shiftsBindingNavigator.TabIndex = 1;
			this.shiftsBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// shiftsBindingNavigatorSaveItem
			// 
			this.shiftsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.shiftsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("shiftsBindingNavigatorSaveItem.Image")));
			this.shiftsBindingNavigatorSaveItem.Name = "shiftsBindingNavigatorSaveItem";
			this.shiftsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.shiftsBindingNavigatorSaveItem.Text = "Save Data";
			this.shiftsBindingNavigatorSaveItem.Click += new System.EventHandler(this.shiftsBindingNavigatorSaveItem_Click);
			// 
			// shiftsDataGridView
			// 
			this.shiftsDataGridView.AutoGenerateColumns = false;
			this.shiftsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.shiftsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn5});
			this.shiftsDataGridView.DataSource = this.shiftsBindingSource;
			this.shiftsDataGridView.Location = new System.Drawing.Point(6, 21);
			this.shiftsDataGridView.Name = "shiftsDataGridView";
			this.shiftsDataGridView.Size = new System.Drawing.Size(646, 318);
			this.shiftsDataGridView.TabIndex = 0;
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
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "From";
			this.dataGridViewTextBoxColumn3.HeaderText = "From";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "To";
			this.dataGridViewTextBoxColumn4.HeaderText = "To";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewCheckBoxColumn1
			// 
			this.dataGridViewCheckBoxColumn1.DataPropertyName = "IsGeneral";
			this.dataGridViewCheckBoxColumn1.HeaderText = "IsGeneral";
			this.dataGridViewCheckBoxColumn1.IndeterminateValue = "False";
			this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
			// 
			// dataGridViewCheckBoxColumn2
			// 
			this.dataGridViewCheckBoxColumn2.DataPropertyName = "IsDayToNight";
			this.dataGridViewCheckBoxColumn2.HeaderText = "IsDayToNight";
			this.dataGridViewCheckBoxColumn2.IndeterminateValue = "False";
			this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "EffectiveDate";
			this.dataGridViewTextBoxColumn5.HeaderText = "EffectiveDate";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// Shift
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.shiftsBindingNavigator);
			this.Controls.Add(this.groupBox1);
			this.Name = "Shift";
			this.Text = "Shift";
			this.Load += new System.EventHandler(this.Shift_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shiftsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.shiftsBindingNavigator)).EndInit();
			this.shiftsBindingNavigator.ResumeLayout(false);
			this.shiftsBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.shiftsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource shiftsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.ShiftsTableAdapter shiftsTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator shiftsBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton shiftsBindingNavigatorSaveItem;
		private System.Windows.Forms.DataGridView shiftsDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}