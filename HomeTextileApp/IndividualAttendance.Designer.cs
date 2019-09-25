namespace HomeTextileApp
{
	partial class IndividualAttendance
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.viewIndividualAttendanceDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.viewIndividualAttendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewIndividualAttendanceDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.viewIndividualAttendanceBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox1.DataSource = this.employeeBindingSource;
			this.comboBox1.DisplayMember = "NameWithId";
			this.comboBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 27);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(181, 23);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.ValueMember = "Id";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(HomeTextileApp.DL.Employee);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(10, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Employee Id";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(203, 28);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(233, 22);
			this.dateTimePicker1.TabIndex = 2;
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker2.Location = new System.Drawing.Point(447, 27);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(233, 22);
			this.dateTimePicker2.TabIndex = 3;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(200, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "From";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(444, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(21, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "To";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(688, 11);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 38);
			this.button1.TabIndex = 6;
			this.button1.Text = "Search";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.viewIndividualAttendanceDataGridView);
			this.groupBox1.Location = new System.Drawing.Point(13, 66);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(560, 494);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Individual Attendance Report";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(469, 450);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(85, 38);
			this.button2.TabIndex = 1;
			this.button2.Text = "Print";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// viewIndividualAttendanceDataGridView
			// 
			this.viewIndividualAttendanceDataGridView.AutoGenerateColumns = false;
			this.viewIndividualAttendanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.viewIndividualAttendanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.viewIndividualAttendanceDataGridView.DataSource = this.viewIndividualAttendanceBindingSource;
			this.viewIndividualAttendanceDataGridView.Location = new System.Drawing.Point(6, 21);
			this.viewIndividualAttendanceDataGridView.Name = "viewIndividualAttendanceDataGridView";
			this.viewIndividualAttendanceDataGridView.Size = new System.Drawing.Size(548, 429);
			this.viewIndividualAttendanceDataGridView.TabIndex = 0;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn1.HeaderText = "Date";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Shift";
			this.dataGridViewTextBoxColumn2.HeaderText = "Shift";
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
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Status";
			this.dataGridViewTextBoxColumn5.HeaderText = "Status";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// viewIndividualAttendanceBindingSource
			// 
			this.viewIndividualAttendanceBindingSource.DataSource = typeof(HomeTextileApp.DL.ViewIndividualAttendance);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(579, 87);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 15);
			this.label4.TabIndex = 8;
			this.label4.Text = "label4";
			this.label4.Visible = false;
			// 
			// IndividualAttendance
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 572);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "IndividualAttendance";
			this.Text = "IndividualAttendance";
			this.Load += new System.EventHandler(this.IndividualAttendance_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.viewIndividualAttendanceDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.viewIndividualAttendanceBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.BindingSource employeeBindingSource;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView viewIndividualAttendanceDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.BindingSource viewIndividualAttendanceBindingSource;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label4;
	}
}