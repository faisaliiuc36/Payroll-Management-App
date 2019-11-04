namespace HomeTextileApp
{
	partial class LoanReport
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
			this.sectionsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter();
			this.button4 = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewOTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.departmentsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.companyComboBox = new System.Windows.Forms.ComboBox();
			this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companiesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter();
			this.unitsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter();
			this.viewLoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.viewLoanDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.viewOTBindingSource)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLoanBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLoanDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// sectionsTableAdapter
			// 
			this.sectionsTableAdapter.ClearBeforeFill = true;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Lime;
			this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button4.Location = new System.Drawing.Point(710, 550);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 40);
			this.button4.TabIndex = 22;
			this.button4.Text = "Print";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn7.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "TotalHour";
			this.dataGridViewTextBoxColumn6.HeaderText = "TotalHour";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "OutTime";
			this.dataGridViewTextBoxColumn5.HeaderText = "OutTime";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "InTime";
			this.dataGridViewTextBoxColumn4.HeaderText = "InTime";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn3.HeaderText = "Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Grade";
			this.dataGridViewTextBoxColumn2.HeaderText = "Grade";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Emp_Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Emp_Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Emp_Id";
			this.dataGridViewTextBoxColumn8.HeaderText = "Emp_Id";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "Grade";
			this.dataGridViewTextBoxColumn9.HeaderText = "Grade";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn10.HeaderText = "Name";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "InTime";
			this.dataGridViewTextBoxColumn11.HeaderText = "InTime";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.Visible = false;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "OutTime";
			this.dataGridViewTextBoxColumn12.HeaderText = "OutTime";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.Visible = false;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "TotalHour";
			this.dataGridViewTextBoxColumn13.HeaderText = "TotalHour";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.Visible = false;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn14.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Visible = false;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.DataPropertyName = "Gross";
			this.dataGridViewTextBoxColumn15.HeaderText = "Gross";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			// 
			// dataGridViewTextBoxColumn16
			// 
			this.dataGridViewTextBoxColumn16.DataPropertyName = "TotalHourC";
			this.dataGridViewTextBoxColumn16.HeaderText = "Total Hour";
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			// 
			// viewOTBindingSource
			// 
			this.viewOTBindingSource.DataSource = typeof(HomeTextileApp.DL.ViewOT);
			// 
			// departmentsTableAdapter
			// 
			this.departmentsTableAdapter.ClearBeforeFill = true;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.comboBox4);
			this.groupBox2.Controls.Add(this.comboBox3);
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.companyComboBox);
			this.groupBox2.Location = new System.Drawing.Point(-12, 0);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(797, 109);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lime;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(558, 53);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(93, 48);
			this.button3.TabIndex = 12;
			this.button3.Text = "Search By Department";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(413, 55);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(92, 48);
			this.button1.TabIndex = 11;
			this.button1.Text = "Search By Section";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(381, 7);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Department:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(247, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(33, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Unit:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(527, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Section";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(108, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Company:";
			// 
			// comboBox4
			// 
			this.comboBox4.DataSource = this.sectionsBindingSource;
			this.comboBox4.DisplayMember = "Name";
			this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(530, 24);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(121, 23);
			this.comboBox4.TabIndex = 3;
			this.comboBox4.ValueMember = "Id";
			// 
			// sectionsBindingSource
			// 
			this.sectionsBindingSource.DataMember = "FK_dbo.Sections_dbo.Departments_DepartmentId";
			this.sectionsBindingSource.DataSource = this.departmentsBindingSource;
			// 
			// departmentsBindingSource
			// 
			this.departmentsBindingSource.DataMember = "FK_dbo.Departments_dbo.Units_UnitId";
			this.departmentsBindingSource.DataSource = this.unitsBindingSource;
			// 
			// unitsBindingSource
			// 
			this.unitsBindingSource.DataMember = "FK_dbo.Units_dbo.Companies_CompanyId";
			this.unitsBindingSource.DataSource = this.companiesBindingSource;
			// 
			// companiesBindingSource
			// 
			this.companiesBindingSource.DataMember = "Companies";
			this.companiesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// comboBox3
			// 
			this.comboBox3.DataSource = this.departmentsBindingSource;
			this.comboBox3.DisplayMember = "Name";
			this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Location = new System.Drawing.Point(384, 24);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(121, 23);
			this.comboBox3.TabIndex = 2;
			this.comboBox3.ValueMember = "Id";
			// 
			// comboBox2
			// 
			this.comboBox2.DataSource = this.unitsBindingSource;
			this.comboBox2.DisplayMember = "Name";
			this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(250, 24);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(121, 23);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.ValueMember = "Id";
			// 
			// companyComboBox
			// 
			this.companyComboBox.DataSource = this.companiesBindingSource;
			this.companyComboBox.DisplayMember = "Name";
			this.companyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.companyComboBox.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.companyComboBox.FormattingEnabled = true;
			this.companyComboBox.Location = new System.Drawing.Point(111, 24);
			this.companyComboBox.Name = "companyComboBox";
			this.companyComboBox.Size = new System.Drawing.Size(121, 23);
			this.companyComboBox.TabIndex = 0;
			this.companyComboBox.ValueMember = "Id";
			// 
			// dataGridViewTextBoxColumn17
			// 
			this.dataGridViewTextBoxColumn17.DataPropertyName = "AmountC";
			this.dataGridViewTextBoxColumn17.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn17.ReadOnly = true;
			// 
			// companiesTableAdapter
			// 
			this.companiesTableAdapter.ClearBeforeFill = true;
			// 
			// unitsTableAdapter
			// 
			this.unitsTableAdapter.ClearBeforeFill = true;
			// 
			// viewLoanBindingSource
			// 
			this.viewLoanBindingSource.DataSource = typeof(HomeTextileApp.DL.ViewLoan);
			// 
			// viewLoanDataGridView
			// 
			this.viewLoanDataGridView.AutoGenerateColumns = false;
			this.viewLoanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewLoanDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24});
			this.viewLoanDataGridView.DataSource = this.viewLoanBindingSource;
			this.viewLoanDataGridView.Location = new System.Drawing.Point(12, 137);
			this.viewLoanDataGridView.Name = "viewLoanDataGridView";
			this.viewLoanDataGridView.Size = new System.Drawing.Size(773, 407);
			this.viewLoanDataGridView.TabIndex = 23;
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.DataPropertyName = "EmployeeName";
			this.dataGridViewTextBoxColumn18.HeaderText = "EmployeeName";
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn19.HeaderText = "EmployeeId";
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn20.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			// 
			// dataGridViewTextBoxColumn21
			// 
			this.dataGridViewTextBoxColumn21.DataPropertyName = "Paid";
			this.dataGridViewTextBoxColumn21.HeaderText = "Paid";
			this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
			// 
			// dataGridViewTextBoxColumn22
			// 
			this.dataGridViewTextBoxColumn22.DataPropertyName = "PaidInstallment";
			this.dataGridViewTextBoxColumn22.HeaderText = "PaidInstallment";
			this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
			// 
			// dataGridViewTextBoxColumn23
			// 
			this.dataGridViewTextBoxColumn23.DataPropertyName = "Payable";
			this.dataGridViewTextBoxColumn23.HeaderText = "Payable";
			this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
			// 
			// dataGridViewTextBoxColumn24
			// 
			this.dataGridViewTextBoxColumn24.DataPropertyName = "PayableInstallment";
			this.dataGridViewTextBoxColumn24.HeaderText = "PayableInstallment";
			this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(528, 560);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 24;
			this.label5.Text = "label5";
			this.label5.Visible = false;
			// 
			// LoanReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(836, 650);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.viewLoanDataGridView);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.groupBox2);
			this.Name = "LoanReport";
			this.Text = "LoanReport";
			this.Load += new System.EventHandler(this.LoanReport_Load);
			((System.ComponentModel.ISupportInitialize)(this.viewOTBindingSource)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLoanBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewLoanDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter sectionsTableAdapter;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private System.Windows.Forms.BindingSource viewOTBindingSource;
		private HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.BindingSource sectionsBindingSource;
		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private System.Windows.Forms.BindingSource unitsBindingSource;
		private System.Windows.Forms.BindingSource companiesBindingSource;
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox companyComboBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter companiesTableAdapter;
		private HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter unitsTableAdapter;
		private System.Windows.Forms.BindingSource viewLoanBindingSource;
		private System.Windows.Forms.DataGridView viewLoanDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
		private System.Windows.Forms.Label label5;
	}
}