namespace HomeTextileApp
{
	partial class Form1
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
            System.Windows.Forms.Label isEditedLabel;
            System.Windows.Forms.Label insertDateLabel;
            System.Windows.Forms.Label endDateLabel;
            System.Windows.Forms.Label isTraineeLabel;
            System.Windows.Forms.Label emergencyContactLabel;
            System.Windows.Forms.Label middleNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label activeStatusLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneNumberLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label hireDateLabel;
            System.Windows.Forms.Label dateOfBirthLabel;
            System.Windows.Forms.Label badgeNumberLabel;
            System.Windows.Forms.Label empFullNameLabel;
            System.Windows.Forms.Label sectionIdLabel;
            System.Windows.Forms.Label emp_IdLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label employeeTypeIdLabel;
            System.Windows.Forms.Label bloodGroupIdLabel;
            System.Windows.Forms.Label religionIdLabel;
            System.Windows.Forms.Label maritialStatusIdLabel;
            System.Windows.Forms.Label designationIdLabel;
            System.Windows.Forms.Label genderIdLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.homeTextileDBDataSet = new HomeTextileApp.HomeTextileDBDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.EmployeesTableAdapter();
            this.tableAdapterManager = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.TableAdapterManager();
            this.bloodGroupsTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.BloodGroupsTableAdapter();
            this.companiesTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.CompaniesTableAdapter();
            this.designationsTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.DesignationsTableAdapter();
            this.employeeTypesTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.EmployeeTypesTableAdapter();
            this.gendersTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.GendersTableAdapter();
            this.maritialStatusTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.MaritialStatusTableAdapter();
            this.religionsTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.ReligionsTableAdapter();
            this.sectionsTableAdapter = new HomeTextileApp.HomeTextileDBDataSetTableAdapters.SectionsTableAdapter();
            this.employeesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.isEditedCheckBox = new System.Windows.Forms.CheckBox();
            this.insertDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isTraineeCheckBox = new System.Windows.Forms.CheckBox();
            this.emergencyContactTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.activeStatusCheckBox = new System.Windows.Forms.CheckBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.hireDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dateOfBirthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.badgeNumberTextBox = new System.Windows.Forms.TextBox();
            this.empFullNameTextBox = new System.Windows.Forms.TextBox();
            this.emp_IdTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            this.imageFileTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.genderIdComboBox = new System.Windows.Forms.ComboBox();
            this.gendersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.designationIdComboBox = new System.Windows.Forms.ComboBox();
            this.designationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maritialStatusIdComboBox = new System.Windows.Forms.ComboBox();
            this.maritialStatusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.religionIdComboBox = new System.Windows.Forms.ComboBox();
            this.religionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodGroupIdComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sectionIdComboBox = new System.Windows.Forms.ComboBox();
            this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTypeIdComboBox = new System.Windows.Forms.ComboBox();
            this.employeeTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            isEditedLabel = new System.Windows.Forms.Label();
            insertDateLabel = new System.Windows.Forms.Label();
            endDateLabel = new System.Windows.Forms.Label();
            isTraineeLabel = new System.Windows.Forms.Label();
            emergencyContactLabel = new System.Windows.Forms.Label();
            middleNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            activeStatusLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            phoneNumberLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            hireDateLabel = new System.Windows.Forms.Label();
            dateOfBirthLabel = new System.Windows.Forms.Label();
            badgeNumberLabel = new System.Windows.Forms.Label();
            empFullNameLabel = new System.Windows.Forms.Label();
            sectionIdLabel = new System.Windows.Forms.Label();
            emp_IdLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            employeeTypeIdLabel = new System.Windows.Forms.Label();
            bloodGroupIdLabel = new System.Windows.Forms.Label();
            religionIdLabel = new System.Windows.Forms.Label();
            maritialStatusIdLabel = new System.Windows.Forms.Label();
            designationIdLabel = new System.Windows.Forms.Label();
            genderIdLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).BeginInit();
            this.employeesBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritialStatusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.religionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // isEditedLabel
            // 
            isEditedLabel.AutoSize = true;
            isEditedLabel.Location = new System.Drawing.Point(44, 805);
            isEditedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            isEditedLabel.Name = "isEditedLabel";
            isEditedLabel.Size = new System.Drawing.Size(87, 22);
            isEditedLabel.TabIndex = 58;
            isEditedLabel.Text = "Is Edited:";
            // 
            // insertDateLabel
            // 
            insertDateLabel.AutoSize = true;
            insertDateLabel.Location = new System.Drawing.Point(647, 556);
            insertDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            insertDateLabel.Name = "insertDateLabel";
            insertDateLabel.Size = new System.Drawing.Size(102, 22);
            insertDateLabel.TabIndex = 51;
            insertDateLabel.Text = "Insert Date:";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new System.Drawing.Point(647, 508);
            endDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new System.Drawing.Size(89, 22);
            endDateLabel.TabIndex = 49;
            endDateLabel.Text = "End Date:";
            // 
            // isTraineeLabel
            // 
            isTraineeLabel.AutoSize = true;
            isTraineeLabel.Location = new System.Drawing.Point(647, 454);
            isTraineeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            isTraineeLabel.Name = "isTraineeLabel";
            isTraineeLabel.Size = new System.Drawing.Size(95, 22);
            isTraineeLabel.TabIndex = 47;
            isTraineeLabel.Text = "Is Trainee:";
            // 
            // emergencyContactLabel
            // 
            emergencyContactLabel.AutoSize = true;
            emergencyContactLabel.Location = new System.Drawing.Point(647, 354);
            emergencyContactLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            emergencyContactLabel.Name = "emergencyContactLabel";
            emergencyContactLabel.Size = new System.Drawing.Size(168, 22);
            emergencyContactLabel.TabIndex = 43;
            emergencyContactLabel.Text = "Emergency Contact:";
            // 
            // middleNameLabel
            // 
            middleNameLabel.AutoSize = true;
            middleNameLabel.Location = new System.Drawing.Point(647, 306);
            middleNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new System.Drawing.Size(125, 22);
            middleNameLabel.TabIndex = 41;
            middleNameLabel.Text = "Middle Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(647, 258);
            lastNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(100, 22);
            lastNameLabel.TabIndex = 39;
            lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(647, 210);
            firstNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(104, 22);
            firstNameLabel.TabIndex = 37;
            firstNameLabel.Text = "First Name:";
            // 
            // activeStatusLabel
            // 
            activeStatusLabel.AutoSize = true;
            activeStatusLabel.Location = new System.Drawing.Point(26, 748);
            activeStatusLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            activeStatusLabel.Name = "activeStatusLabel";
            activeStatusLabel.Size = new System.Drawing.Size(121, 22);
            activeStatusLabel.TabIndex = 31;
            activeStatusLabel.Text = "Active Status:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(26, 696);
            emailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(63, 22);
            emailLabel.TabIndex = 29;
            emailLabel.Text = "Email:";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new System.Drawing.Point(26, 648);
            phoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new System.Drawing.Size(132, 22);
            phoneNumberLabel.TabIndex = 27;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(26, 600);
            addressLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(82, 22);
            addressLabel.TabIndex = 25;
            addressLabel.Text = "Address:";
            // 
            // hireDateLabel
            // 
            hireDateLabel.AutoSize = true;
            hireDateLabel.Location = new System.Drawing.Point(26, 458);
            hireDateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            hireDateLabel.Name = "hireDateLabel";
            hireDateLabel.Size = new System.Drawing.Size(94, 22);
            hireDateLabel.TabIndex = 19;
            hireDateLabel.Text = "Hire Date:";
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Location = new System.Drawing.Point(26, 362);
            dateOfBirthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new System.Drawing.Size(123, 22);
            dateOfBirthLabel.TabIndex = 15;
            dateOfBirthLabel.Text = "Date Of Birth:";
            // 
            // badgeNumberLabel
            // 
            badgeNumberLabel.AutoSize = true;
            badgeNumberLabel.Location = new System.Drawing.Point(26, 312);
            badgeNumberLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            badgeNumberLabel.Name = "badgeNumberLabel";
            badgeNumberLabel.Size = new System.Drawing.Size(134, 22);
            badgeNumberLabel.TabIndex = 13;
            badgeNumberLabel.Text = "Badge Number:";
            // 
            // empFullNameLabel
            // 
            empFullNameLabel.AutoSize = true;
            empFullNameLabel.Location = new System.Drawing.Point(26, 264);
            empFullNameLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            empFullNameLabel.Name = "empFullNameLabel";
            empFullNameLabel.Size = new System.Drawing.Size(140, 22);
            empFullNameLabel.TabIndex = 11;
            empFullNameLabel.Text = "Emp Full Name:";
            // 
            // sectionIdLabel
            // 
            sectionIdLabel.AutoSize = true;
            sectionIdLabel.Location = new System.Drawing.Point(26, 216);
            sectionIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            sectionIdLabel.Name = "sectionIdLabel";
            sectionIdLabel.Size = new System.Drawing.Size(123, 22);
            sectionIdLabel.TabIndex = 9;
            sectionIdLabel.Text = "Select Section";
            // 
            // emp_IdLabel
            // 
            emp_IdLabel.AutoSize = true;
            emp_IdLabel.Location = new System.Drawing.Point(26, 72);
            emp_IdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            emp_IdLabel.Name = "emp_IdLabel";
            emp_IdLabel.Size = new System.Drawing.Size(73, 22);
            emp_IdLabel.TabIndex = 3;
            emp_IdLabel.Text = "Emp Id:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(26, 24);
            idLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(32, 22);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            idLabel.Visible = false;
            // 
            // employeeTypeIdLabel
            // 
            employeeTypeIdLabel.AutoSize = true;
            employeeTypeIdLabel.Location = new System.Drawing.Point(26, 120);
            employeeTypeIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            employeeTypeIdLabel.Name = "employeeTypeIdLabel";
            employeeTypeIdLabel.Size = new System.Drawing.Size(187, 22);
            employeeTypeIdLabel.TabIndex = 59;
            employeeTypeIdLabel.Text = "Select Employee Type";
            // 
            // bloodGroupIdLabel
            // 
            bloodGroupIdLabel.AutoSize = true;
            bloodGroupIdLabel.Location = new System.Drawing.Point(26, 408);
            bloodGroupIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            bloodGroupIdLabel.Name = "bloodGroupIdLabel";
            bloodGroupIdLabel.Size = new System.Drawing.Size(168, 22);
            bloodGroupIdLabel.TabIndex = 62;
            bloodGroupIdLabel.Text = "Select Blood Group";
            // 
            // religionIdLabel
            // 
            religionIdLabel.AutoSize = true;
            religionIdLabel.Location = new System.Drawing.Point(26, 502);
            religionIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            religionIdLabel.Name = "religionIdLabel";
            religionIdLabel.Size = new System.Drawing.Size(132, 22);
            religionIdLabel.TabIndex = 63;
            religionIdLabel.Text = "Select Religion";
            // 
            // maritialStatusIdLabel
            // 
            maritialStatusIdLabel.AutoSize = true;
            maritialStatusIdLabel.Location = new System.Drawing.Point(26, 548);
            maritialStatusIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            maritialStatusIdLabel.Name = "maritialStatusIdLabel";
            maritialStatusIdLabel.Size = new System.Drawing.Size(186, 22);
            maritialStatusIdLabel.TabIndex = 64;
            maritialStatusIdLabel.Text = "Select Maritial Status ";
            // 
            // designationIdLabel
            // 
            designationIdLabel.AutoSize = true;
            designationIdLabel.Location = new System.Drawing.Point(647, 168);
            designationIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            designationIdLabel.Name = "designationIdLabel";
            designationIdLabel.Size = new System.Drawing.Size(164, 22);
            designationIdLabel.TabIndex = 65;
            designationIdLabel.Text = "Select Designation:";
            // 
            // genderIdLabel
            // 
            genderIdLabel.AutoSize = true;
            genderIdLabel.Location = new System.Drawing.Point(647, 402);
            genderIdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            genderIdLabel.Name = "genderIdLabel";
            genderIdLabel.Size = new System.Drawing.Size(128, 22);
            genderIdLabel.TabIndex = 66;
            genderIdLabel.Text = "Select Gender:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(647, 600);
            label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(111, 22);
            label1.TabIndex = 69;
            label1.Text = "Select Image";
            // 
            // homeTextileDBDataSet
            // 
            this.homeTextileDBDataSet.DataSetName = "HomeTextileDBDataSet";
            this.homeTextileDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.homeTextileDBDataSet;
            this.employeesBindingSource.CurrentChanged += new System.EventHandler(this.employeesBindingSource_CurrentChanged);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.@__MigrationHistoryTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BloodGroupsTableAdapter = this.bloodGroupsTableAdapter;
            this.tableAdapterManager.BonusTableAdapter = null;
            this.tableAdapterManager.CompaniesTableAdapter = this.companiesTableAdapter;
            this.tableAdapterManager.DepartmentsTableAdapter = null;
            this.tableAdapterManager.DesignationsTableAdapter = this.designationsTableAdapter;
            this.tableAdapterManager.Duty_RosterTableAdapter = null;
            this.tableAdapterManager.Emp_CheckInOutTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = this.employeesTableAdapter;
            this.tableAdapterManager.EmployeeTypesTableAdapter = this.employeeTypesTableAdapter;
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
            this.tableAdapterManager.SalarySettingsTableAdapter = null;
            this.tableAdapterManager.SectionsTableAdapter = this.sectionsTableAdapter;
            this.tableAdapterManager.ShiftsTableAdapter = null;
            this.tableAdapterManager.UnitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HomeTextileApp.HomeTextileDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bloodGroupsTableAdapter
            // 
            this.bloodGroupsTableAdapter.ClearBeforeFill = true;
            // 
            // companiesTableAdapter
            // 
            this.companiesTableAdapter.ClearBeforeFill = true;
            // 
            // designationsTableAdapter
            // 
            this.designationsTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTypesTableAdapter
            // 
            this.employeeTypesTableAdapter.ClearBeforeFill = true;
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
            // sectionsTableAdapter
            // 
            this.sectionsTableAdapter.ClearBeforeFill = true;
            // 
            // employeesBindingNavigator
            // 
            this.employeesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeesBindingNavigator.BindingSource = this.employeesBindingSource;
            this.employeesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeesBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.employeesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeesBindingNavigatorSaveItem,
            this.toolStripButton1});
            this.employeesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeesBindingNavigator.Name = "employeesBindingNavigator";
            this.employeesBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.employeesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeesBindingNavigator.Size = new System.Drawing.Size(1848, 35);
            this.employeesBindingNavigator.TabIndex = 0;
            this.employeesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // employeesBindingNavigatorSaveItem
            // 
            this.employeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.employeesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("employeesBindingNavigatorSaveItem.Image")));
            this.employeesBindingNavigatorSaveItem.Name = "employeesBindingNavigatorSaveItem";
            this.employeesBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.employeesBindingNavigatorSaveItem.Text = "Save Data";
            this.employeesBindingNavigatorSaveItem.Click += new System.EventHandler(this.employeesBindingNavigatorSaveItem_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 32);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // isEditedCheckBox
            // 
            this.isEditedCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource, "IsEdited", true));
            this.isEditedCheckBox.Location = new System.Drawing.Point(226, 805);
            this.isEditedCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.isEditedCheckBox.Name = "isEditedCheckBox";
            this.isEditedCheckBox.Size = new System.Drawing.Size(367, 44);
            this.isEditedCheckBox.TabIndex = 59;
            this.isEditedCheckBox.Text = "checkBox1";
            this.isEditedCheckBox.UseVisualStyleBackColor = true;
            // 
            // insertDateDateTimePicker
            // 
            this.insertDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "InsertDate", true));
            this.insertDateDateTimePicker.Location = new System.Drawing.Point(847, 548);
            this.insertDateDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.insertDateDateTimePicker.Name = "insertDateDateTimePicker";
            this.insertDateDateTimePicker.Size = new System.Drawing.Size(363, 30);
            this.insertDateDateTimePicker.TabIndex = 52;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "EndDate", true));
            this.endDateDateTimePicker.Location = new System.Drawing.Point(847, 500);
            this.endDateDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(363, 30);
            this.endDateDateTimePicker.TabIndex = 50;
            // 
            // isTraineeCheckBox
            // 
            this.isTraineeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource, "IsTrainee", true));
            this.isTraineeCheckBox.Location = new System.Drawing.Point(847, 445);
            this.isTraineeCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.isTraineeCheckBox.Name = "isTraineeCheckBox";
            this.isTraineeCheckBox.Size = new System.Drawing.Size(367, 44);
            this.isTraineeCheckBox.TabIndex = 48;
            this.isTraineeCheckBox.Text = "checkBox1";
            this.isTraineeCheckBox.UseVisualStyleBackColor = true;
            // 
            // emergencyContactTextBox
            // 
            this.emergencyContactTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmergencyContact", true));
            this.emergencyContactTextBox.Location = new System.Drawing.Point(847, 349);
            this.emergencyContactTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emergencyContactTextBox.Name = "emergencyContactTextBox";
            this.emergencyContactTextBox.Size = new System.Drawing.Size(363, 30);
            this.emergencyContactTextBox.TabIndex = 44;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "MiddleName", true));
            this.middleNameTextBox.Location = new System.Drawing.Point(847, 301);
            this.middleNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(363, 30);
            this.middleNameTextBox.TabIndex = 42;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(847, 253);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(363, 30);
            this.lastNameTextBox.TabIndex = 40;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(847, 205);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(363, 30);
            this.firstNameTextBox.TabIndex = 38;
            // 
            // activeStatusCheckBox
            // 
            this.activeStatusCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.employeesBindingSource, "ActiveStatus", true));
            this.activeStatusCheckBox.Location = new System.Drawing.Point(233, 738);
            this.activeStatusCheckBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.activeStatusCheckBox.Name = "activeStatusCheckBox";
            this.activeStatusCheckBox.Size = new System.Drawing.Size(367, 44);
            this.activeStatusCheckBox.TabIndex = 32;
            this.activeStatusCheckBox.Text = "checkBox1";
            this.activeStatusCheckBox.UseVisualStyleBackColor = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(233, 690);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(363, 30);
            this.emailTextBox.TabIndex = 30;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "PhoneNumber", true));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(233, 642);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(363, 30);
            this.phoneNumberTextBox.TabIndex = 28;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(233, 594);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(363, 30);
            this.addressTextBox.TabIndex = 26;
            // 
            // hireDateDateTimePicker
            // 
            this.hireDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "HireDate", true));
            this.hireDateDateTimePicker.Location = new System.Drawing.Point(233, 450);
            this.hireDateDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.hireDateDateTimePicker.Name = "hireDateDateTimePicker";
            this.hireDateDateTimePicker.Size = new System.Drawing.Size(363, 30);
            this.hireDateDateTimePicker.TabIndex = 20;
            // 
            // dateOfBirthDateTimePicker
            // 
            this.dateOfBirthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.employeesBindingSource, "DateOfBirth", true));
            this.dateOfBirthDateTimePicker.Location = new System.Drawing.Point(233, 354);
            this.dateOfBirthDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dateOfBirthDateTimePicker.Name = "dateOfBirthDateTimePicker";
            this.dateOfBirthDateTimePicker.Size = new System.Drawing.Size(363, 30);
            this.dateOfBirthDateTimePicker.TabIndex = 16;
            // 
            // badgeNumberTextBox
            // 
            this.badgeNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BadgeNumber", true));
            this.badgeNumberTextBox.Location = new System.Drawing.Point(233, 306);
            this.badgeNumberTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.badgeNumberTextBox.Name = "badgeNumberTextBox";
            this.badgeNumberTextBox.Size = new System.Drawing.Size(363, 30);
            this.badgeNumberTextBox.TabIndex = 14;
            // 
            // empFullNameTextBox
            // 
            this.empFullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmpFullName", true));
            this.empFullNameTextBox.Location = new System.Drawing.Point(233, 258);
            this.empFullNameTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.empFullNameTextBox.Name = "empFullNameTextBox";
            this.empFullNameTextBox.Size = new System.Drawing.Size(363, 30);
            this.empFullNameTextBox.TabIndex = 12;
            // 
            // emp_IdTextBox
            // 
            this.emp_IdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Emp_Id", true));
            this.emp_IdTextBox.Location = new System.Drawing.Point(233, 66);
            this.emp_IdTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.emp_IdTextBox.Name = "emp_IdTextBox";
            this.emp_IdTextBox.Size = new System.Drawing.Size(363, 30);
            this.emp_IdTextBox.TabIndex = 4;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(233, 18);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(363, 30);
            this.idTextBox.TabIndex = 2;
            this.idTextBox.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.imagePathTextBox);
            this.panel1.Controls.Add(this.imageFileTextBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(genderIdLabel);
            this.panel1.Controls.Add(this.genderIdComboBox);
            this.panel1.Controls.Add(designationIdLabel);
            this.panel1.Controls.Add(this.designationIdComboBox);
            this.panel1.Controls.Add(maritialStatusIdLabel);
            this.panel1.Controls.Add(this.maritialStatusIdComboBox);
            this.panel1.Controls.Add(religionIdLabel);
            this.panel1.Controls.Add(this.religionIdComboBox);
            this.panel1.Controls.Add(bloodGroupIdLabel);
            this.panel1.Controls.Add(this.bloodGroupIdComboBox);
            this.panel1.Controls.Add(this.sectionIdComboBox);
            this.panel1.Controls.Add(employeeTypeIdLabel);
            this.panel1.Controls.Add(this.employeeTypeIdComboBox);
            this.panel1.Controls.Add(isEditedLabel);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.isEditedCheckBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(emp_IdLabel);
            this.panel1.Controls.Add(this.emp_IdTextBox);
            this.panel1.Controls.Add(sectionIdLabel);
            this.panel1.Controls.Add(empFullNameLabel);
            this.panel1.Controls.Add(this.empFullNameTextBox);
            this.panel1.Controls.Add(badgeNumberLabel);
            this.panel1.Controls.Add(this.badgeNumberTextBox);
            this.panel1.Controls.Add(dateOfBirthLabel);
            this.panel1.Controls.Add(this.dateOfBirthDateTimePicker);
            this.panel1.Controls.Add(hireDateLabel);
            this.panel1.Controls.Add(this.hireDateDateTimePicker);
            this.panel1.Controls.Add(addressLabel);
            this.panel1.Controls.Add(this.addressTextBox);
            this.panel1.Controls.Add(phoneNumberLabel);
            this.panel1.Controls.Add(this.phoneNumberTextBox);
            this.panel1.Controls.Add(emailLabel);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(activeStatusLabel);
            this.panel1.Controls.Add(this.activeStatusCheckBox);
            this.panel1.Controls.Add(firstNameLabel);
            this.panel1.Controls.Add(this.firstNameTextBox);
            this.panel1.Controls.Add(lastNameLabel);
            this.panel1.Controls.Add(this.lastNameTextBox);
            this.panel1.Controls.Add(middleNameLabel);
            this.panel1.Controls.Add(this.middleNameTextBox);
            this.panel1.Controls.Add(emergencyContactLabel);
            this.panel1.Controls.Add(this.emergencyContactTextBox);
            this.panel1.Controls.Add(isTraineeLabel);
            this.panel1.Controls.Add(this.isTraineeCheckBox);
            this.panel1.Controls.Add(endDateLabel);
            this.panel1.Controls.Add(this.endDateDateTimePicker);
            this.panel1.Controls.Add(insertDateLabel);
            this.panel1.Controls.Add(this.insertDateDateTimePicker);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(22, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1525, 886);
            this.panel1.TabIndex = 60;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ImagePath", true));
            this.imagePathTextBox.Location = new System.Drawing.Point(724, 72);
            this.imagePathTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(180, 30);
            this.imagePathTextBox.TabIndex = 72;
            this.imagePathTextBox.Visible = false;
            // 
            // imageFileTextBox
            // 
            this.imageFileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ImageFile", true));
            this.imageFileTextBox.Location = new System.Drawing.Point(724, 24);
            this.imageFileTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.imageFileTextBox.Name = "imageFileTextBox";
            this.imageFileTextBox.Size = new System.Drawing.Size(180, 30);
            this.imageFileTextBox.TabIndex = 71;
            this.imageFileTextBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1051, 731);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 70;
            this.button1.Text = "Upload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(847, 600);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(191, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // genderIdComboBox
            // 
            this.genderIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "GenderId", true));
            this.genderIdComboBox.DataSource = this.gendersBindingSource;
            this.genderIdComboBox.DisplayMember = "Name";
            this.genderIdComboBox.FormattingEnabled = true;
            this.genderIdComboBox.Location = new System.Drawing.Point(847, 402);
            this.genderIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.genderIdComboBox.Name = "genderIdComboBox";
            this.genderIdComboBox.Size = new System.Drawing.Size(219, 29);
            this.genderIdComboBox.TabIndex = 67;
            this.genderIdComboBox.ValueMember = "Id";
            // 
            // gendersBindingSource
            // 
            this.gendersBindingSource.DataMember = "Genders";
            this.gendersBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // designationIdComboBox
            // 
            this.designationIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "DesignationId", true));
            this.designationIdComboBox.DataSource = this.designationsBindingSource;
            this.designationIdComboBox.DisplayMember = "Name";
            this.designationIdComboBox.FormattingEnabled = true;
            this.designationIdComboBox.Location = new System.Drawing.Point(847, 153);
            this.designationIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.designationIdComboBox.Name = "designationIdComboBox";
            this.designationIdComboBox.Size = new System.Drawing.Size(219, 29);
            this.designationIdComboBox.TabIndex = 66;
            this.designationIdComboBox.ValueMember = "Id";
            // 
            // designationsBindingSource
            // 
            this.designationsBindingSource.DataMember = "Designations";
            this.designationsBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // maritialStatusIdComboBox
            // 
            this.maritialStatusIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "MaritialStatusId", true));
            this.maritialStatusIdComboBox.DataSource = this.maritialStatusBindingSource;
            this.maritialStatusIdComboBox.DisplayMember = "Name";
            this.maritialStatusIdComboBox.FormattingEnabled = true;
            this.maritialStatusIdComboBox.Location = new System.Drawing.Point(233, 545);
            this.maritialStatusIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.maritialStatusIdComboBox.Name = "maritialStatusIdComboBox";
            this.maritialStatusIdComboBox.Size = new System.Drawing.Size(219, 29);
            this.maritialStatusIdComboBox.TabIndex = 65;
            this.maritialStatusIdComboBox.ValueMember = "Id";
            // 
            // maritialStatusBindingSource
            // 
            this.maritialStatusBindingSource.DataMember = "MaritialStatus";
            this.maritialStatusBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // religionIdComboBox
            // 
            this.religionIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "ReligionId", true));
            this.religionIdComboBox.DataSource = this.religionsBindingSource;
            this.religionIdComboBox.DisplayMember = "Name";
            this.religionIdComboBox.FormattingEnabled = true;
            this.religionIdComboBox.Location = new System.Drawing.Point(233, 497);
            this.religionIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.religionIdComboBox.Name = "religionIdComboBox";
            this.religionIdComboBox.Size = new System.Drawing.Size(219, 29);
            this.religionIdComboBox.TabIndex = 64;
            this.religionIdComboBox.ValueMember = "Id";
            // 
            // religionsBindingSource
            // 
            this.religionsBindingSource.DataMember = "Religions";
            this.religionsBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // bloodGroupIdComboBox
            // 
            this.bloodGroupIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "BloodGroupId", true));
            this.bloodGroupIdComboBox.DataSource = this.bloodGroupsBindingSource;
            this.bloodGroupIdComboBox.DisplayMember = "Name";
            this.bloodGroupIdComboBox.FormattingEnabled = true;
            this.bloodGroupIdComboBox.Location = new System.Drawing.Point(233, 402);
            this.bloodGroupIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bloodGroupIdComboBox.Name = "bloodGroupIdComboBox";
            this.bloodGroupIdComboBox.Size = new System.Drawing.Size(219, 29);
            this.bloodGroupIdComboBox.TabIndex = 63;
            this.bloodGroupIdComboBox.ValueMember = "Id";
            // 
            // bloodGroupsBindingSource
            // 
            this.bloodGroupsBindingSource.DataMember = "BloodGroups";
            this.bloodGroupsBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // sectionIdComboBox
            // 
            this.sectionIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "SectionId", true));
            this.sectionIdComboBox.DataSource = this.sectionsBindingSource;
            this.sectionIdComboBox.DisplayMember = "Name";
            this.sectionIdComboBox.FormattingEnabled = true;
            this.sectionIdComboBox.Location = new System.Drawing.Point(233, 210);
            this.sectionIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sectionIdComboBox.Name = "sectionIdComboBox";
            this.sectionIdComboBox.Size = new System.Drawing.Size(219, 29);
            this.sectionIdComboBox.TabIndex = 62;
            this.sectionIdComboBox.ValueMember = "Id";
            // 
            // sectionsBindingSource
            // 
            this.sectionsBindingSource.DataMember = "Sections";
            this.sectionsBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // employeeTypeIdComboBox
            // 
            this.employeeTypeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeesBindingSource, "EmployeeTypeId", true));
            this.employeeTypeIdComboBox.DataSource = this.employeeTypesBindingSource;
            this.employeeTypeIdComboBox.DisplayMember = "Name";
            this.employeeTypeIdComboBox.FormattingEnabled = true;
            this.employeeTypeIdComboBox.Location = new System.Drawing.Point(233, 114);
            this.employeeTypeIdComboBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.employeeTypeIdComboBox.Name = "employeeTypeIdComboBox";
            this.employeeTypeIdComboBox.Size = new System.Drawing.Size(219, 29);
            this.employeeTypeIdComboBox.TabIndex = 60;
            this.employeeTypeIdComboBox.ValueMember = "Id";
            // 
            // employeeTypesBindingSource
            // 
            this.employeeTypesBindingSource.DataMember = "EmployeeTypes";
            this.employeeTypesBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // companiesBindingSource
            // 
            this.companiesBindingSource.DataMember = "Companies";
            this.companiesBindingSource.DataSource = this.homeTextileDBDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1848, 1346);
            this.Controls.Add(this.employeesBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingNavigator)).EndInit();
            this.employeesBindingNavigator.ResumeLayout(false);
            this.employeesBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gendersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maritialStatusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.religionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private HomeTextileDBDataSet homeTextileDBDataSet;
		private System.Windows.Forms.BindingSource employeesBindingSource;
		private HomeTextileDBDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
		private HomeTextileDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator employeesBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton employeesBindingNavigatorSaveItem;
		private System.Windows.Forms.CheckBox isEditedCheckBox;
		private System.Windows.Forms.DateTimePicker insertDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
		private System.Windows.Forms.CheckBox isTraineeCheckBox;
		private System.Windows.Forms.TextBox emergencyContactTextBox;
		private System.Windows.Forms.TextBox middleNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.CheckBox activeStatusCheckBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.TextBox phoneNumberTextBox;
		private System.Windows.Forms.TextBox addressTextBox;
		private System.Windows.Forms.DateTimePicker hireDateDateTimePicker;
		private System.Windows.Forms.DateTimePicker dateOfBirthDateTimePicker;
		private System.Windows.Forms.TextBox badgeNumberTextBox;
		private System.Windows.Forms.TextBox empFullNameTextBox;
		private System.Windows.Forms.TextBox emp_IdTextBox;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.Panel panel1;
		private HomeTextileDBDataSetTableAdapters.EmployeeTypesTableAdapter employeeTypesTableAdapter;
		private System.Windows.Forms.ComboBox employeeTypeIdComboBox;
		private System.Windows.Forms.BindingSource employeeTypesBindingSource;
		private HomeTextileDBDataSetTableAdapters.CompaniesTableAdapter companiesTableAdapter;
		private System.Windows.Forms.BindingSource companiesBindingSource;
		private HomeTextileDBDataSetTableAdapters.SectionsTableAdapter sectionsTableAdapter;
		private System.Windows.Forms.ComboBox sectionIdComboBox;
		private System.Windows.Forms.BindingSource sectionsBindingSource;
		private HomeTextileDBDataSetTableAdapters.BloodGroupsTableAdapter bloodGroupsTableAdapter;
		private System.Windows.Forms.ComboBox bloodGroupIdComboBox;
		private System.Windows.Forms.BindingSource bloodGroupsBindingSource;
		private HomeTextileDBDataSetTableAdapters.ReligionsTableAdapter religionsTableAdapter;
		private System.Windows.Forms.ComboBox religionIdComboBox;
		private System.Windows.Forms.BindingSource religionsBindingSource;
		private HomeTextileDBDataSetTableAdapters.MaritialStatusTableAdapter maritialStatusTableAdapter;
		private System.Windows.Forms.ComboBox maritialStatusIdComboBox;
		private System.Windows.Forms.BindingSource maritialStatusBindingSource;
		private HomeTextileDBDataSetTableAdapters.DesignationsTableAdapter designationsTableAdapter;
		private System.Windows.Forms.ComboBox designationIdComboBox;
		private System.Windows.Forms.BindingSource designationsBindingSource;
		private HomeTextileDBDataSetTableAdapters.GendersTableAdapter gendersTableAdapter;
		private System.Windows.Forms.ComboBox genderIdComboBox;
		private System.Windows.Forms.BindingSource gendersBindingSource;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox imagePathTextBox;
		private System.Windows.Forms.TextBox imageFileTextBox;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
	}
}

