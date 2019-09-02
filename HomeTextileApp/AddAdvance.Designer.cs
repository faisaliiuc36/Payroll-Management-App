namespace HomeTextileApp
{
	partial class AddAdvance
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
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label employeeIdLabel;
			System.Windows.Forms.Label dateLabel;
			System.Windows.Forms.Label amountLabel;
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.advanceDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.advanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bloodGroupsTableAdapter1 = new HomeTextileApp.HomeTextileDBDataSet1TableAdapters.BloodGroupsTableAdapter();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.employeeIdComboBox = new System.Windows.Forms.ComboBox();
			this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.amountTextBox = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			idLabel = new System.Windows.Forms.Label();
			employeeIdLabel = new System.Windows.Forms.Label();
			dateLabel = new System.Windows.Forms.Label();
			amountLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.advanceDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.advanceBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Location = new System.Drawing.Point(53, 28);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(19, 13);
			idLabel.TabIndex = 25;
			idLabel.Text = "Id:";
			idLabel.Visible = false;
			// 
			// employeeIdLabel
			// 
			employeeIdLabel.AutoSize = true;
			employeeIdLabel.Location = new System.Drawing.Point(18, 69);
			employeeIdLabel.Name = "employeeIdLabel";
			employeeIdLabel.Size = new System.Drawing.Size(68, 13);
			employeeIdLabel.TabIndex = 23;
			employeeIdLabel.Text = "Employee Id:";
			// 
			// dateLabel
			// 
			dateLabel.AutoSize = true;
			dateLabel.Location = new System.Drawing.Point(53, 139);
			dateLabel.Name = "dateLabel";
			dateLabel.Size = new System.Drawing.Size(33, 13);
			dateLabel.TabIndex = 21;
			dateLabel.Text = "Date:";
			// 
			// amountLabel
			// 
			amountLabel.AutoSize = true;
			amountLabel.Location = new System.Drawing.Point(40, 106);
			amountLabel.Name = "amountLabel";
			amountLabel.Size = new System.Drawing.Size(46, 13);
			amountLabel.TabIndex = 20;
			amountLabel.Text = "Amount:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(534, 13);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 11;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(427, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "Search By Month:";
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(169, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(167, 22);
			this.textBox1.TabIndex = 9;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(35, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 15);
			this.label1.TabIndex = 8;
			this.label1.Text = "Search By EmployeeId:";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button5.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Location = new System.Drawing.Point(137, 165);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(75, 32);
			this.button5.TabIndex = 14;
			this.button5.Text = "Update";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(56, 165);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 32);
			this.button2.TabIndex = 13;
			this.button2.Text = "Delete";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(218, 165);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 32);
			this.button1.TabIndex = 12;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// advanceDataGridView
			// 
			this.advanceDataGridView.AutoGenerateColumns = false;
			this.advanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.advanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.advanceDataGridView.DataSource = this.advanceBindingSource;
			this.advanceDataGridView.Location = new System.Drawing.Point(12, 58);
			this.advanceDataGridView.Name = "advanceDataGridView";
			this.advanceDataGridView.Size = new System.Drawing.Size(453, 382);
			this.advanceDataGridView.TabIndex = 15;
			this.advanceDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advanceDataGridView_CellClick);
			this.advanceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advanceDataGridView_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeId";
			this.dataGridViewTextBoxColumn2.DataSource = this.employeeBindingSource;
			this.dataGridViewTextBoxColumn2.DisplayMember = "NameWithId";
			this.dataGridViewTextBoxColumn2.HeaderText = "EmployeeId";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.dataGridViewTextBoxColumn2.ValueMember = "Id";
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(HomeTextileApp.DL.Employee);
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Employee";
			this.dataGridViewTextBoxColumn3.HeaderText = "Employee";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Visible = false;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Amount";
			this.dataGridViewTextBoxColumn4.HeaderText = "Amount";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Installment";
			this.dataGridViewTextBoxColumn5.HeaderText = "Installment";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn6.HeaderText = "Date";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// advanceBindingSource
			// 
			this.advanceBindingSource.DataSource = typeof(HomeTextileApp.DL.Advance);
			// 
			// bloodGroupsTableAdapter1
			// 
			this.bloodGroupsTableAdapter1.ClearBeforeFill = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(idLabel);
			this.groupBox1.Controls.Add(this.idTextBox);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(employeeIdLabel);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.employeeIdComboBox);
			this.groupBox1.Controls.Add(dateLabel);
			this.groupBox1.Controls.Add(this.dateDateTimePicker);
			this.groupBox1.Controls.Add(amountLabel);
			this.groupBox1.Controls.Add(this.amountTextBox);
			this.groupBox1.Location = new System.Drawing.Point(497, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(310, 344);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// idTextBox
			// 
			this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanceBindingSource, "Id", true));
			this.idTextBox.Location = new System.Drawing.Point(92, 28);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 27;
			this.idTextBox.Visible = false;
			// 
			// employeeIdComboBox
			// 
			this.employeeIdComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanceBindingSource, "EmployeeId", true));
			this.employeeIdComboBox.DataSource = this.employeeBindingSource;
			this.employeeIdComboBox.DisplayMember = "NameWithId";
			this.employeeIdComboBox.FormattingEnabled = true;
			this.employeeIdComboBox.Location = new System.Drawing.Point(92, 66);
			this.employeeIdComboBox.Name = "employeeIdComboBox";
			this.employeeIdComboBox.Size = new System.Drawing.Size(201, 21);
			this.employeeIdComboBox.TabIndex = 26;
			this.employeeIdComboBox.ValueMember = "Id";
			// 
			// dateDateTimePicker
			// 
			this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.advanceBindingSource, "Date", true));
			this.dateDateTimePicker.Location = new System.Drawing.Point(92, 139);
			this.dateDateTimePicker.Name = "dateDateTimePicker";
			this.dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
			this.dateDateTimePicker.TabIndex = 24;
			// 
			// amountTextBox
			// 
			this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.advanceBindingSource, "Amount", true));
			this.amountTextBox.Location = new System.Drawing.Point(92, 103);
			this.amountTextBox.Name = "amountTextBox";
			this.amountTextBox.Size = new System.Drawing.Size(200, 20);
			this.amountTextBox.TabIndex = 22;
			// 
			// backgroundWorker1
			// 
			this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
			// 
			// AddAdvance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(871, 572);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.advanceDataGridView);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "AddAdvance";
			this.Text = "AddAdvance";
			this.Load += new System.EventHandler(this.AddAdvance_Load);
			((System.ComponentModel.ISupportInitialize)(this.advanceDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.advanceBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.BindingSource advanceBindingSource;
		private System.Windows.Forms.DataGridView advanceDataGridView;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private HomeTextileDBDataSet1TableAdapters.BloodGroupsTableAdapter bloodGroupsTableAdapter1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.ComboBox employeeIdComboBox;
		private System.Windows.Forms.DateTimePicker dateDateTimePicker;
		private System.Windows.Forms.TextBox amountTextBox;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
	}
}