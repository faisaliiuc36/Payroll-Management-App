namespace HomeTextileApp
{
	partial class BonusReport
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.companyComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.homeTextileDBDataSet2 = new HomeTextileApp.HomeTextileDBDataSet2();
			this.companiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.companiesTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter();
			this.unitsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.unitsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter();
			this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.departmentsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter();
			this.sectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sectionsTableAdapter = new HomeTextileApp.HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter();
			this.viewBonusBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.viewBonusDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBonusBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBonusDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.groupBox2.Controls.Add(this.comboBox1);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.dateTimePicker1);
			this.groupBox2.Controls.Add(this.label3);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Controls.Add(this.label1);
			this.groupBox2.Controls.Add(this.comboBox4);
			this.groupBox2.Controls.Add(this.comboBox3);
			this.groupBox2.Controls.Add(this.comboBox2);
			this.groupBox2.Controls.Add(this.companyComboBox);
			this.groupBox2.Location = new System.Drawing.Point(3, 1);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(797, 136);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Lime;
			this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(412, 62);
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
			this.button1.Location = new System.Drawing.Point(530, 62);
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
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(109, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "Select A Year";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(191, 62);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(204, 22);
			this.dateTimePicker1.TabIndex = 7;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(109, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(77, 15);
			this.label5.TabIndex = 13;
			this.label5.Text = "Select Bonus";
			// 
			// comboBox1
			// 
			this.comboBox1.DisplayMember = "Name";
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(191, 92);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(204, 23);
			this.comboBox1.TabIndex = 14;
			this.comboBox1.ValueMember = "Id";
			// 
			// homeTextileDBDataSet2
			// 
			this.homeTextileDBDataSet2.DataSetName = "HomeTextileDBDataSet2";
			this.homeTextileDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// companiesBindingSource
			// 
			this.companiesBindingSource.DataMember = "Companies";
			this.companiesBindingSource.DataSource = this.homeTextileDBDataSet2;
			// 
			// companiesTableAdapter
			// 
			this.companiesTableAdapter.ClearBeforeFill = true;
			// 
			// unitsBindingSource
			// 
			this.unitsBindingSource.DataMember = "FK_dbo.Units_dbo.Companies_CompanyId";
			this.unitsBindingSource.DataSource = this.companiesBindingSource;
			// 
			// unitsTableAdapter
			// 
			this.unitsTableAdapter.ClearBeforeFill = true;
			// 
			// departmentsBindingSource
			// 
			this.departmentsBindingSource.DataMember = "FK_dbo.Departments_dbo.Units_UnitId";
			this.departmentsBindingSource.DataSource = this.unitsBindingSource;
			// 
			// departmentsTableAdapter
			// 
			this.departmentsTableAdapter.ClearBeforeFill = true;
			// 
			// sectionsBindingSource
			// 
			this.sectionsBindingSource.DataMember = "FK_dbo.Sections_dbo.Departments_DepartmentId";
			this.sectionsBindingSource.DataSource = this.departmentsBindingSource;
			// 
			// sectionsTableAdapter
			// 
			this.sectionsTableAdapter.ClearBeforeFill = true;
			// 
			// viewBonusBindingSource
			// 
			this.viewBonusBindingSource.DataSource = typeof(HomeTextileApp.DL.ViewBonus);
			// 
			// viewBonusDataGridView
			// 
			this.viewBonusDataGridView.AutoGenerateColumns = false;
			this.viewBonusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewBonusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
			this.viewBonusDataGridView.DataSource = this.viewBonusBindingSource;
			this.viewBonusDataGridView.Location = new System.Drawing.Point(3, 143);
			this.viewBonusDataGridView.Name = "viewBonusDataGridView";
			this.viewBonusDataGridView.Size = new System.Drawing.Size(656, 220);
			this.viewBonusDataGridView.TabIndex = 7;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Emp_Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Emp_Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Grade";
			this.dataGridViewTextBoxColumn2.HeaderText = "Grade";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn3.HeaderText = "Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Days";
			this.dataGridViewTextBoxColumn4.HeaderText = "Days";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Gross";
			this.dataGridViewTextBoxColumn5.HeaderText = "Gross";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Basic";
			this.dataGridViewTextBoxColumn6.HeaderText = "Basic";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Visible = false;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "CompanyPercentage";
			this.dataGridViewTextBoxColumn7.HeaderText = "CompanyPercentage";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Visible = false;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Bonus";
			this.dataGridViewTextBoxColumn8.HeaderText = "Bonus";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			// 
			// BonusReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(820, 572);
			this.Controls.Add(this.viewBonusDataGridView);
			this.Controls.Add(this.groupBox2);
			this.Name = "BonusReport";
			this.Text = "BonusReport";
			this.Load += new System.EventHandler(this.BonusReport_Load);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.homeTextileDBDataSet2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companiesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.unitsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sectionsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBonusBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewBonusDataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox companyComboBox;
		private HomeTextileDBDataSet2 homeTextileDBDataSet2;
		private System.Windows.Forms.BindingSource companiesBindingSource;
		private HomeTextileDBDataSet2TableAdapters.CompaniesTableAdapter companiesTableAdapter;
		private System.Windows.Forms.BindingSource unitsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.UnitsTableAdapter unitsTableAdapter;
		private System.Windows.Forms.BindingSource departmentsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
		private System.Windows.Forms.BindingSource sectionsBindingSource;
		private HomeTextileDBDataSet2TableAdapters.SectionsTableAdapter sectionsTableAdapter;
		private System.Windows.Forms.BindingSource viewBonusBindingSource;
		private System.Windows.Forms.DataGridView viewBonusDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
	}
}