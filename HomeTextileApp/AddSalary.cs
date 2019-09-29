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
	public partial class AddSalary : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public AddSalary()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int empId = Convert.ToInt32(textBox1.Text);
				var emp = db.Employees.FirstOrDefault(a => a.Emp_Id == empId);
				salariesBindingSource.Filter = "EmployeeId=" + emp.Id;
			}
			catch (Exception Ex)
			{
				salariesBindingSource.Filter = "EmployeeId=0";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.salariesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);


			MessageBox.Show("Save Sucessfully!");
		}

		private void button5_Click(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Salaries' table. You can move, or remove it, as needed.
			this.salariesTableAdapter.Fill(this.homeTextileDBDataSet2.Salaries);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

			this.salariesBindingSource.RemoveCurrent();

			
			
			this.Validate();
			this.salariesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

			MessageBox.Show("Deleted Sucessfully!");
		}

		private void AddSalary_Load(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Salaries' table. You can move, or remove it, as needed.
			this.salariesTableAdapter.Fill(this.homeTextileDBDataSet2.Salaries);
		}
	}
}
