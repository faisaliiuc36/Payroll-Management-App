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
	public partial class AddEarnLeave : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public AddEarnLeave()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy";
			dateTimePicker1.ShowUpDown = true;
		}

		private void AddEarnLeave_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//Check Last Year
			//if(DateTime.Now.Year-1!=dateTimePicker1.Value.Year)
			//{
			//	MessageBox.Show("Earn leave only can add for last year!");
			//	return;
			//}
			//Check Any EL Exist

			var leaveStore = db.LeaveStores.FirstOrDefault(a => a.Year == dateTimePicker1.Value.Year && a.LeaveType.Tags=="EL");
			if(leaveStore !=null)
			{
				MessageBox.Show("Earn leave already Exist for this year!");
				return;
			}

			// Employee Collection
			List<Employee> employeesALL = db.Employees.ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(DateTime.Now) && a.IsEdited == true).ToList();
			List<ViewYearlyLeave> viewYearlyLeaves = new List<ViewYearlyLeave>();


			double month = 0;
			foreach (Employee employee in employees)
			{
				// Check is employee eligible for EL
				try
				{

					DateTime JoiningDate = Convert.ToDateTime(employee.HireDate);
					DateTime date = new DateTime(dateTimePicker1.Value.Year, 12,31);
					TimeSpan timeSpan = date.Subtract(JoiningDate);
					 month= (timeSpan.Days / 365)*12;
				}
				catch
				{

				}
				if(month>=6)
				{
					ViewYearlyLeave viewYearlyLeave = new ViewYearlyLeave();

					// Count Total Present
					List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.UserId == employee.Emp_Id).ToList();

					var DayCount = emp_CheckInOuts.Where(a => a.CHECKTIME.Year == dateTimePicker1.Value.Year).GroupBy(a => a.CHECKTIME.Date).ToList();
					viewYearlyLeave.PresentDays = DayCount.Count - 1;

					// Days Count
					viewYearlyLeave.DaysCount =viewYearlyLeave.PresentDays / Convert.ToInt32(numericUpDown1.Value);

					// Employee Id
					viewYearlyLeave.Emp_Id = employee.Emp_Id;

					// Year

					viewYearlyLeave.Year = dateTimePicker1.Value.Year;

					viewYearlyLeaves.Add(viewYearlyLeave);
			
				}




			}

			viewYearlyLeaveDataGridView.DataSource = null;
			viewYearlyLeaveDataGridView.DataSource = viewYearlyLeaves.ToList();

			}

		private void button2_Click(object sender, EventArgs e)
		{

			DialogResult res = MessageBox.Show("Are you sure you want to Add EL", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

			var view = viewYearlyLeaveDataGridView.DataSource;
			List<ViewYearlyLeave> viewYearlyLeaves = (List<ViewYearlyLeave>)view;

			LeaveType leaveType = db.LeaveTypes.FirstOrDefault(a => a.Tags == "EL");
			if(leaveType !=null)
			{
				foreach (ViewYearlyLeave V in viewYearlyLeaves)
				{
					LeaveStore leave = new LeaveStore();

					leave.EmployeeId = V.Emp_Id;
					leave.Count = V.DaysCount;
					leave.IsSingleEmployee = true;
					leave.LeaveTypeId = leaveType.Id;
					leave.Year = V.Year;

					db.LeaveStores.Add(leave);
					db.SaveChanges();


				}

				MessageBox.Show("Saved Sucessfully!");
			}
			else
			{
				MessageBox.Show("There is no EL in Leave Type!");
			}
			
		}
	}
}
