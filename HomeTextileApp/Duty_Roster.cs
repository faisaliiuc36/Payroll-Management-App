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
	
	public partial class Duty_Roster : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public Duty_Roster()
		{
			InitializeComponent();
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			if(comboBox1.Text=="Worker")
			{
				SetGridView();
			}
			else
			{
				SetGridViewForEmployee();
			}
		
		}

		private void SetGridViewForEmployee()
		{
			dataGridView1.DataSource = null;
			DateTime date = Convert.ToDateTime(dateTimePicker1.Text);

			List<Employee> employees2 = db.Employees.Where(a => a.IsWorker == false).ToList();
			if (employees2.Count > 0)
			{
				List<Employee> employees = employees2.Where(a => a.IsActive(date) == true).ToList();
				List<DL.Shift> shifts = db.shifts.Where(a => a.IsGeneral == true && a.InActive == false).ToList();



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
					var dutyRoster = db.Duty_Rosters.FirstOrDefault(a => a.Date == date && a.EmployeeId == employee.Id);
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
		private void SetGridView()
		{
			dataGridView1.DataSource = null;
			DateTime date = Convert.ToDateTime(dateTimePicker1.Text);

			List<Employee> employees2 = db.Employees.Where(a=> a.IsWorker == true).ToList();
			if(employees2.Count>0)
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
					var dutyRoster = db.Duty_Rosters.FirstOrDefault(a => a.Date == date && a.EmployeeId==employee.Id);
					DataRow dr = null;

					dr = dt.NewRow();
					dr["Id"] = employee.Id;
					dr["EmpId"] = employee.Emp_Id;
					dr["Name"] = employee.EmpFullName;
					foreach (DL.Shift shift in shifts)
					{
						if(dutyRoster!=null)
						{
							if (dutyRoster.ShiftId == shift.Id)
							{
								DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
								
								dr[shift.Name] = true;


							}
							else
							{
								DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
							
								dr[shift.Name] =false;

							}
						}
						
						else
						{
							DataGridViewCheckBoxCell chk = new DataGridViewCheckBoxCell();
							

							dr[shift.Name] =false;
						}
					}

					dt.Rows.Add(dr);

				}



				dataGridView1.DataSource = dt;
				dataGridView1.Columns["Id"].Visible = false;
			}

		}

		private void Duty_Roster_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			DateTime date =Convert.ToDateTime(dateTimePicker1.Text);


			List<DL.Shift> shifts = new List<DL.Shift>();
			if(comboBox1.Text=="Worker")
			{
				shifts = db.shifts.Where(a => a.InActive == false && a.IsGeneral==false).ToList();
			}
			else
			{
				shifts = db.shifts.Where(a => a.InActive == false && a.IsGeneral == true).ToList();
			}

			 
			DataTable dataTable = (DataTable)dataGridView1.DataSource;
			for (int i = 0; i < dataTable.Rows.Count; i++)
			{
				int id = Convert.ToInt32(dataTable.Rows[i]["Id"]);


				//Delete Duty ROster
				List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == id && a.Date == date).ToList();
				if(duty_Rosters.Count>0)
				{
					db.Duty_Rosters.RemoveRange(duty_Rosters);
					db.SaveChanges();
				}
				



				// Save Duty Roster
				foreach (DL.Shift S in shifts)
				{
					if (Convert.ToBoolean(dataTable.Rows[i][S.Name])== true)
					{
						DL.Duty_Roster duty_Roster = new DL.Duty_Roster();

						duty_Roster.EmployeeId = id;
						duty_Roster.Date = date;
						duty_Roster.ShiftId = S.Id;


						db.Duty_Rosters.Add(duty_Roster);
						db.SaveChanges();
					}
				}
			}
			MessageBox.Show("Save Sucessfully!");
			if (comboBox1.Text == "Worker")
			{
				SetGridView();
			}
			else
			{
				SetGridViewForEmployee();
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.Text == "Worker")
			{
				SetGridView();
			}
			else
			{
				SetGridViewForEmployee();
			}
		}
	}
}
