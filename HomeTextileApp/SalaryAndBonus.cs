using HomeTextileApp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class SalaryAndBonus : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public SalaryAndBonus()
		{
			InitializeComponent();
		}

		private void salariesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.salariesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void SalaryAndBonus_Load(object sender, EventArgs e)
		{
				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Salaries' table. You can move, or remove it, as needed.
			this.salariesTableAdapter.Fill(this.homeTextileDBDataSet2.Salaries);
		
		}

		private void LoadAll()
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Salaries' table. You can move, or remove it, as needed.
			this.salariesTableAdapter.Fill(this.homeTextileDBDataSet2.Salaries);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveAll();
			MessageBox.Show("Save Sucessfully!");
		}

		private void SaveAll()
		{
		
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
			

		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

			this.salariesBindingSource.RemoveCurrent();

			SaveAll();
			MessageBox.Show("Deleted Sucessfully!");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SaveAll();
			MessageBox.Show("Save Sucessfully!");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

		

			SaveAll();
			MessageBox.Show("Deleted Sucessfully!");
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int empId = Convert.ToInt32(textBox1.Text);
				var emp = db.Employees.FirstOrDefault(a => a.Emp_Id == empId);
				salariesBindingSource.Filter = "EmployeeId=" + emp.Id;
			}
			catch(Exception Ex)
			{
				salariesBindingSource.Filter = "EmployeeId=0" ;
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
		}

		private void button5_Click(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Salaries' table. You can move, or remove it, as needed.
			this.salariesTableAdapter.Fill(this.homeTextileDBDataSet2.Salaries);

		}

		private void button6_Click(object sender, EventArgs e)
		{
			
		}
	}
}
