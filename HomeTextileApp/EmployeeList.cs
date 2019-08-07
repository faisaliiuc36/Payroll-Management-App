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
	public partial class EmployeeList : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public EmployeeList()
		{
			InitializeComponent();
		}

		private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.employeesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void EmployeeList_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			LoadEmployee();
		}
		private void LoadEmployee()
		{
			List<Employee> employees = db.Employees.ToList();
			List<Employee> newemployees = employees.Where(a => a.IsEdited == true && a.IsActive(DateTime.Now)==true).ToList();


			employeesBindingSource.DataSource = newemployees;


		}
	}
}
