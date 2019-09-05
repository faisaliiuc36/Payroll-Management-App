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
	public partial class Manuel_Attendance : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public Manuel_Attendance()
		{
			InitializeComponent();
		}

		private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.employeesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void Manuel_Attendance_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GetManuel();
		}

		private void GetManuel()
		{
			int UserId = Convert.ToInt32(emp_IdTextBox.Text);
			DateTime date = Convert.ToDateTime(cHECKTIMEDateTimePicker.Text);
			DateTime NewDate = new DateTime(date.Year, date.Month, 1);

			var emp = db.Employees.FirstOrDefault(a => a.Emp_Id == UserId);
			if (emp != null)
			{
				label1.Text = "Name: " + emp.EmpFullName;
				// Make a List of Manual Attendance
				List<Emp_CheckInOut> emp_CheckInOuts = new List<Emp_CheckInOut>();
				do
				{
					Emp_CheckInOut emCO = new Emp_CheckInOut();

					emCO.CHECKTIME = NewDate;
					emCO.UserId = emp.Emp_Id;
					//emCO.UpdatedBy = LoginInfo.UserName;



					var empCheckInOut = db.Emp_CheckInOuts.FirstOrDefault(a => a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.CHECKTIME.Day == NewDate.Day && a.IsManual == true && a.UserId==emp.Emp_Id);

					if (empCheckInOut != null)
					{
						emCO = (Emp_CheckInOut)empCheckInOut;
						
					}
					
					emp_CheckInOuts.Add(emCO);
					NewDate = NewDate.AddDays(1);
				} while (date.Month == NewDate.Month);

				emp_CheckInOutDataGridView.DataSource = null;
				emp_CheckInOutDataGridView.DataSource = emp_CheckInOuts.ToList();

				GetInOutTime();


			}
			else
			{
				MessageBox.Show("Employee Not Found");
			}
		}

		private void GetInOutTime()
		{
			
				for (int i = 0; i < emp_CheckInOutDataGridView.Rows.Count; i++)
				{
					DateTime date =Convert.ToDateTime(emp_CheckInOutDataGridView.Rows[i].Cells[2].Value.ToString());
				List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Month == date.Month && a.CHECKTIME.Year == date.Year && a.CHECKTIME.Day == date.Day && a.IsManual==false).ToList();
				if(emp_CheckInOuts.Count>0)
				{
					//In Time Calculation

					DateTime emp = emp_CheckInOuts.Min(a => a.CHECKTIME);
					emp_CheckInOutDataGridView.Rows[i].Cells[8].Value = emp.TimeOfDay;

					//Out Time Calculation
					DateTime emp2 = emp_CheckInOuts.Max(a => a.CHECKTIME);
					emp_CheckInOutDataGridView.Rows[i].Cells[9].Value = emp2.TimeOfDay;

				}
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{

			DeletePreviousData();
			var emp = emp_CheckInOutDataGridView.DataSource;

			List<Emp_CheckInOut> emp_CheckInOuts = (List<Emp_CheckInOut>)emp;

			foreach(Emp_CheckInOut E in emp_CheckInOuts)
			{
				if(E.IsManual==true)
				{
					E.UpdatedBy = LoginInfo.UserName;
					db.Emp_CheckInOuts.Add(E);
					db.SaveChanges();
				}
			}
			MessageBox.Show("Save Sucessfully!");
			GetManuel();

		}

		private void DeletePreviousData()
		{
			int UserId = Convert.ToInt32(emp_IdTextBox.Text);
			DateTime date = Convert.ToDateTime(cHECKTIMEDateTimePicker.Text);

			List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.IsManual == true && a.CHECKTIME.Year == date.Year && a.CHECKTIME.Month == date.Month).ToList();
			db.Emp_CheckInOuts.RemoveRange(emp_CheckInOuts);
			db.SaveChanges();
		}
	}
}
