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
	public partial class TransferHoliday : Form
	{
		DatabaseContext db = new DatabaseContext();
		public TransferHoliday()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime From = dateTimePicker1.Value;
			int id = Convert.ToInt32(comboBox4.SelectedValue);

			List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == From.Day && a.CHECKTIME.Month == From.Month && a.CHECKTIME.Year==From.Year).ToList();
			List<Emp_CheckInOut> emp_CheckInOutsForTransfer =new List<Emp_CheckInOut>();
			foreach(Emp_CheckInOut emp_CheckInOut in emp_CheckInOuts)
			{
				var Employee = db.Employees.FirstOrDefault(a => a.Emp_Id == emp_CheckInOut.UserId && a.SectionId == id);
				if(Employee != null)
				{
					emp_CheckInOutsForTransfer.Add(emp_CheckInOut);
				}
			}

			emp_CheckInOutDataGridView.DataSource = emp_CheckInOutsForTransfer.ToList();

		}

		private void button3_Click(object sender, EventArgs e)
		{
			DateTime From = dateTimePicker1.Value;
			int id = Convert.ToInt32(comboBox3.SelectedValue);
			List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == From.Day && a.CHECKTIME.Month == From.Month && a.CHECKTIME.Year == From.Year).ToList();
			List<Emp_CheckInOut> emp_CheckInOutsForTransfer = new List<Emp_CheckInOut>();
			foreach (Emp_CheckInOut emp_CheckInOut in emp_CheckInOuts)
			{
				var Employee = db.Employees.FirstOrDefault(a => a.Emp_Id == emp_CheckInOut.UserId && a.Section.DepartmentId == id);
				if (Employee != null)
				{
					emp_CheckInOutsForTransfer.Add(emp_CheckInOut);
				}
			}
			emp_CheckInOutDataGridView.DataSource = emp_CheckInOutsForTransfer.ToList();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DateTime To = dateTimePicker2.Value;


			var emp = emp_CheckInOutDataGridView.DataSource;

			List<Emp_CheckInOut> emp_CheckInOuts = (List<Emp_CheckInOut>)emp;


			foreach (Emp_CheckInOut emp_CheckInOut in emp_CheckInOuts)
			{
				DateTime date = To.Date + emp_CheckInOut.CHECKTIME.TimeOfDay;
				emp_CheckInOut.CHECKTIME = date;

				db.Entry(emp_CheckInOut).State = System.Data.Entity.EntityState.Modified;
				db.SaveChanges();
			}

			MessageBox.Show("Transfered Sucessfully!");
		}

		private void TransferHoliday_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet2.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
		}
	}
}
