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
	public partial class AddEmployeeDue : Form
	{
		DatabaseContext db = new DatabaseContext();
		public AddEmployeeDue()
		{
			InitializeComponent();
		}

		private void AddEmployeeDue_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter1.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.EmployeeDues' table. You can move, or remove it, as needed.
			this.employeeDuesTableAdapter.Fill(this.homeTextileDBDataSet2.EmployeeDues);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet3.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet3.Employees);

			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet2.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime From = DateTime.Now ;
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			List<Employee> employeesALL = db.Employees.Where(a => a.SectionId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From) && a.IsEdited == true).ToList();

			try
			{
				PopulateGrid(employees);
			}
			catch
			{

			}

		}

		private void PopulateGrid(List<Employee> employees)
		{
			List<EmployeeDue> employeeDues = new List<EmployeeDue>();
			foreach(Employee employee in employees)
			{
				EmployeeDue employeeDue = new EmployeeDue();
				employeeDue.EmployeeId = employee.Emp_Id;
				employeeDue.DueCurrent = employeeDue.CurrentDue(DateTime.Now);

				employeeDues.Add(employeeDue);

			}
			employeeDueDataGridView.DataSource = null;
			employeeDueDataGridView.DataSource = employeeDues.ToList();


		}

		private void button3_Click(object sender, EventArgs e)
		{
			DateTime From = DateTime.Now;
			int id = Convert.ToInt32(comboBox3.SelectedValue);
			List<Employee> employeesALL = db.Employees.Where(a => a.Section.DepartmentId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From) && a.IsEdited == true).ToList();

			try
			{
				PopulateGrid(employees);
			}
			catch
			{

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				var emp = employeeDueDataGridView.DataSource;

				List<EmployeeDue> emp_CheckInOuts = (List<EmployeeDue>)emp;
				List<EmployeeDue> emp_CheckInOuts2 = emp_CheckInOuts.Where(a => a.Due == true || a.Paid == true).ToList();


				db.EmployeeDues.AddRange(emp_CheckInOuts2);
				db.SaveChanges();

				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.EmployeeDues' table. You can move, or remove it, as needed.
				this.employeeDuesTableAdapter.Fill(this.homeTextileDBDataSet2.EmployeeDues);

				MessageBox.Show("Saved Sucessfully!");
			}
			catch(Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}
		}

		private void employeeDueDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var emp = employeeDueDataGridView.CurrentRow;
			EmployeeDue employee = (EmployeeDue)emp.DataBoundItem;

			employeeDuesBindingSource.Filter = "EmployeeId=" + employee.EmployeeId;
			employeeDuesBindingSource.Sort = "Date";
		}

		private void employeeDueDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var emp = employeeDueDataGridView.CurrentRow;
			EmployeeDue employee = (EmployeeDue)emp.DataBoundItem;

			employeeDuesBindingSource.Filter = "EmployeeId=" + employee.EmployeeId;
			employeeDuesBindingSource.Sort = "Date";
		}

		private void employeeDueDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var emp = employeeDueDataGridView.CurrentRow;
				EmployeeDue employee = (EmployeeDue)emp.DataBoundItem;

				employeeDuesBindingSource.Filter = "EmployeeId=" + employee.EmployeeId;
				employeeDuesBindingSource.Sort = "Date";
			}
			catch
			{

			}
		}

		private void employeeDueDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var emp = employeeDueDataGridView.CurrentRow;
				EmployeeDue employee = (EmployeeDue)emp.DataBoundItem;

				employeeDuesBindingSource.Filter = "EmployeeId=" + employee.EmployeeId;
				employeeDuesBindingSource.Sort = "Date";
			}
			catch
			{

			}
		}
	}
}
