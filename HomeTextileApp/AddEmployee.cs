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
	public partial class AddEmployee : Form
	{
		public AddEmployee()
		{
			InitializeComponent();
		}

		private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			
		}

		private void AddEmployee_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.SalaryGrades' table. You can move, or remove it, as needed.
			this.salaryGradesTableAdapter.Fill(this.homeTextileDBDataSet1.SalaryGrades);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Employees' table. You can move, or remove it, as needed.
			
		}

		private void salaryGradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.salaryGradesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet1);

		}
	}
}
