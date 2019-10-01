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
	public partial class RangeWiseDutyRoster : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public RangeWiseDutyRoster()
		{
			InitializeComponent();
		}

		private void RangeWiseDutyRoster_Load(object sender, EventArgs e)
		{
			LoadEmployee();
		}

		private void LoadEmployee()
		{
			DateTime date = DateTime.Now.Date;

			List<Employee> employees2 = db.Employees.Where(a => a.IsWorker == true).ToList();
			if (employees2.Count > 0)
			{
				List<Employee> employees = employees2.Where(a => a.IsActive(date) == true).ToList();
				List<DL.Shift> shifts = db.shifts.Where(a => a.IsGeneral == false && a.InActive == false).ToList();



				DataTable dt = new DataTable();//Data Table Create 
				dt.Columns.Add("Id", typeof(int));
				dt.Columns.Add("EmpId", typeof(int));
				dt.Columns.Add("Name", typeof(string));

				//Column Add To Data Table


				foreach (DL.Shift S in shifts)
				{

					dt.Columns.Add(S.Name, typeof(bool));

				}


				// Row Add to Data Table
				foreach (Employee employee in employees)
				{
					DateTime dateTime = db.Duty_Rosters.Where(a => a.EmployeeId == employee.Id).Max(a => a.Date);
					var dutyRoster = db.Duty_Rosters.First(a => a.Date == dateTime && a.EmployeeId == employee.Id);

					//Default Duty Roster
					if (dutyRoster == null)
					{
						List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == employee.Id).ToList();
						if (duty_Rosters.Count > 0)
						{
							DateTime date2 = duty_Rosters.Max(a => a.Date);
							dutyRoster = duty_Rosters.FirstOrDefault(a => a.Date == date2);
						}
					}



					DataRow dr = null;

					dr = dt.NewRow();
					dr["Id"] = employee.Id;
					dr["EmpId"] = employee.Emp_Id;
					dr["Name"] = employee.EmpFullName;
					foreach (DL.Shift shift in shifts)
					{
						if (dutyRoster != null)
						{
							if (dutyRoster.ShiftId == shift.Id)
							{
								DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();

								dr[shift.Name] = true;


							}
							else
							{
								DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();

								dr[shift.Name] = false;

							}
						}

						else
						{
							DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();


							dr[shift.Name] = false;
						}
					}

					dt.Rows.Add(dr);

				}



				dataGridView1.DataSource = dt;
				dataGridView1.Columns["Id"].Visible = false;
			}
			}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime date1 = Convert.ToDateTime(dateTimePicker1.Text);
			DateTime date2 = Convert.ToDateTime(dateTimePicker2.Text);

			do
			{


				List<DL.Shift> shifts = db.shifts.Where(a => a.IsGeneral == false && a.InActive == false).ToList();
				DataTable dataTable = (DataTable)dataGridView1.DataSource;
				for (int i = 0; i < dataTable.Rows.Count; i++)
				{
					int id = Convert.ToInt32(dataTable.Rows[i]["Id"]);


					//Delete Duty ROster
					List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == id && a.Date == date1).ToList();
					if (duty_Rosters.Count > 0)
					{
						db.Duty_Rosters.RemoveRange(duty_Rosters);
						db.SaveChanges();
					}




					// Save Duty Roster
					foreach (DL.Shift S in shifts)
					{
						if (Convert.ToBoolean(dataTable.Rows[i][S.Name]) == true)
						{
							DL.Duty_Roster duty_Roster = new DL.Duty_Roster();

							duty_Roster.EmployeeId = id;
							duty_Roster.Date = date1;
							duty_Roster.ShiftId = S.Id;


							db.Duty_Rosters.Add(duty_Roster);
							db.SaveChanges();
						}
					}
				}



				date1 =date1.AddDays(1);
			} while (date2>=date1);

			MessageBox.Show("Save Sucessfully!");
			LoadEmployee();
		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{

		}
	}
}
