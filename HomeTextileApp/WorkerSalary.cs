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
	public partial class WorkerSalary : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public WorkerSalary()
		{
			InitializeComponent();
		}

		private void workerDesignationHistoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.workerDesignationHistoriesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void WorkerSalary_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignationHistories' table. You can move, or remove it, as needed.
			this.workerDesignationHistoriesTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignationHistories);

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int id = Convert.ToInt32(textBox1.Text);

				Employee employee = db.Employees.FirstOrDefault(a=>a.Emp_Id==id);
				workerDesignationHistoriesBindingSource.Filter = "EmployeeId=" + employee.Id;
			}
			catch(Exception Ex)
			{
				
				workerDesignationHistoriesBindingSource.Filter = "EmployeeId=0";
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{

			DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

			this.workerDesignationHistoriesBindingSource.RemoveCurrent();

			SaveAll();
			MessageBox.Show("Deleted Sucessfully!");
		}

		private void SaveAll()
		{
			this.Validate();
			this.workerDesignationHistoriesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignationHistories' table. You can move, or remove it, as needed.
			this.workerDesignationHistoriesTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignationHistories);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveAll();
			MessageBox.Show("Saved Sucessfully!");
		}
	}
}
