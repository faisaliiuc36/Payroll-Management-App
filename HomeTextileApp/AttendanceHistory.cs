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
using Dapper;

namespace HomeTextileApp
{
	public partial class AttendanceHistory : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public AttendanceHistory()
		{
			InitializeComponent();
		}

		private void AttendanceHistory_Load(object sender, EventArgs e)
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

		private void button1_Click(object sender, EventArgs e)
		{

			int id = Convert.ToInt32(comboBox4.SelectedValue);
			DateTime From = dateTimePicker1.Value;
			List<Employee> employeesALL = db.Employees.Where(a => a.SectionId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From)).ToList();
			PopulateGrid(employees);

			DL.Section section = db.Sections.Find(id);
			label7.Text="U: "+section.Department.Unit.Name+";  D: "+section.Department.Name+";  S: " + section.Name;
		}

		private void PopulateGrid(List<Employee> employees)
		{
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			DateTime From = dateTimePicker1.Value;
			DateTime To = dateTimePicker2.Value;

			List<ViewAttendanceHistory> viewAttendanceHistories = new List<ViewAttendanceHistory>();

			if (employees.Count > 0)
			{
				foreach (Employee emp in employees)
				{
					ViewAttendanceHistory viewAttendanceHistory = new ViewAttendanceHistory();
					viewAttendanceHistory.Emp_Id = emp.Emp_Id;
					viewAttendanceHistory.EmpFullName = emp.EmpFullName;
					var salarySetting = db.SalarySettings.FirstOrDefault();

					DateTime NewDate = new DateTime(From.Year, From.Month, From.Day); ;
					do
					{

						//Leave




						//Employee Count


						List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsAbsent != true && a.IsManual != true).ToList();



						//Manual Check
						List<Emp_CheckInOut> Emp_CheckInOutManual = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsManual == true && a.UserId == emp.Emp_Id).ToList();
						List<Emp_CheckInOut> Emp_CheckInOutAbsent = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsAbsent == true && a.UserId == emp.Emp_Id).ToList();
						var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == emp.Section.DepartmentId && a.From <= NewDate && a.To >= NewDate);
						var LeaveDay = db.Leaves.FirstOrDefault(a => a.EmployeeId == emp.Id && a.From >= NewDate && a.To <= NewDate);
						if (Emp_CheckInOutManual.Count > 0)
						{
							viewAttendanceHistory.Manuel = viewAttendanceHistory.Manuel + 1;
							viewAttendanceHistory.Present = viewAttendanceHistory.Present + 1;
						}
						else if (NewDate.DayOfWeek.ToString() == "Friday")
						{
							viewAttendanceHistory.Weekend = viewAttendanceHistory.Weekend + 1;
						}
						else if (Holiday != null)
						{
							viewAttendanceHistory.Holiday = viewAttendanceHistory.Holiday + 1;
						}
						else if (LeaveDay != null)
						{
							viewAttendanceHistory.Leave = viewAttendanceHistory.Leave + 1;
						}

						else if (Emp_CheckInOutAbsent.Count > 0)
						{
							viewAttendanceHistory.Absent = viewAttendanceHistory.Absent + 1;

						}

						else
						{
							//EMployee CheckInOuts
							if (emp_CheckInOuts != null)
							{
								var duty_Roster = db.Duty_Rosters.FirstOrDefault(a => a.Date == NewDate && a.EmployeeId == emp.Id);
								// Default Assign
								if (duty_Roster == null)
								{
									List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == emp.Id).ToList();
									if (duty_Rosters.Count > 0)
									{
										DateTime date = duty_Rosters.Max(a => a.Date);
										duty_Roster = duty_Rosters.FirstOrDefault(a => a.Date == date);
									}
								}


								var salarySetting2 = db.SalarySettings.FirstOrDefault();
								// Is Duty Roster Has
								if (duty_Roster != null)
								{

									List<Emp_CheckInOut> empindividual = emp_CheckInOuts.Where(a => a.UserId == emp.Emp_Id).ToList();
									//Employee Wise Check in out
									if (empindividual.Count > 0)
									{
										//For C Shift
										if (duty_Roster.Shift.IsDayToNight == true)
										{
											DateTime In = NewDate.Date + duty_Roster.Shift.From;
											DateTime Out = NewDate.Date + duty_Roster.Shift.To;

											Out = Out.AddDays(1);

											DateTime OutCheck = Out.AddHours(2);
											DateTime InCheck = In.AddHours(-2);


											List<Emp_CheckInOut> emp_CheckInOuts2 = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day >= NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.CHECKTIME.Day <= NewDate.Day + 1 && a.IsAbsent != true && a.IsManual != true).ToList();
											List<Emp_CheckInOut> empindividual2 = emp_CheckInOuts2.Where(a => a.UserId == emp.Emp_Id).ToList();

											List<Emp_CheckInOut> empIndividualforshift = empindividual2.Where(a => a.CHECKTIME >= InCheck && a.CHECKTIME <= OutCheck).ToList();

											//Shiftwise CheckinOut
											if (empIndividualforshift.Count > 0)
											{
												DateTime Min = (from d in empIndividualforshift select d.CHECKTIME).Min();
												DateTime Max = (from d in empIndividualforshift select d.CHECKTIME).Max();



												//Status Calculation
												DateTime InForStatus = In.AddMinutes(salarySetting.Time);
												DateTime OutForStatus = Out.AddMinutes(-1 * salarySetting.Time);

												if (Min == Max)
												{
													viewAttendanceHistory.Invalid = viewAttendanceHistory.Invalid + 1;
												}
												else if (Min <= InForStatus && Max >= OutForStatus)
												{
													viewAttendanceHistory.Present = viewAttendanceHistory.Present + 1;
												}
												else if (Min > InForStatus && Max >= OutForStatus)
												{
													viewAttendanceHistory.Late = viewAttendanceHistory.Late + 1;
												}

												else if (Min <= InForStatus && Max < OutForStatus)
												{
													viewAttendanceHistory.EarlyLeave = viewAttendanceHistory.EarlyLeave + 1;
												}

												else if (Min > InForStatus && Max < OutForStatus)
												{
													viewAttendanceHistory.EarlyLeave = viewAttendanceHistory.EarlyLeave + 1;
													viewAttendanceHistory.Late = viewAttendanceHistory.Late + 1;
												}


											}
											else
											{

												viewAttendanceHistory.Absent = viewAttendanceHistory.Absent + 1;


											}

										}
										else
										{


											DateTime In = NewDate.Date + duty_Roster.Shift.From;
											DateTime Out = NewDate.Date + duty_Roster.Shift.To;


											DateTime OutCheck = Out.AddHours(2);
											DateTime InCheck = In.AddHours(-2);

											List<Emp_CheckInOut> empIndividualforshift = empindividual.Where(a => a.CHECKTIME >= InCheck && a.CHECKTIME <= OutCheck).ToList();
											//Shift Wise Check In Out
											if (empIndividualforshift.Count > 0)
											{
												DateTime Min = (from d in empIndividualforshift select d.CHECKTIME).Min();
												DateTime Max = (from d in empIndividualforshift select d.CHECKTIME).Max();


												//Status Calculation
												DateTime InForStatus = In.AddMinutes(salarySetting.Time);
												DateTime OutForStatus = Out.AddMinutes(-1 * salarySetting.Time);
												if (Min == Max)
												{
													viewAttendanceHistory.Invalid = viewAttendanceHistory.Invalid + 1;
												}
												else if (Min <= InForStatus && Max >= OutForStatus)
												{
													viewAttendanceHistory.Present = viewAttendanceHistory.Present + 1;
												}
												else if (Min > InForStatus && Max >= OutForStatus)
												{
													viewAttendanceHistory.Late = viewAttendanceHistory.Late + 1;
												}

												else if (Min <= InForStatus && Max < OutForStatus)
												{
													viewAttendanceHistory.EarlyLeave = viewAttendanceHistory.EarlyLeave + 1;
												}

												else if (Min > InForStatus && Max < OutForStatus)
												{
													viewAttendanceHistory.EarlyLeave = viewAttendanceHistory.EarlyLeave + 1;
													viewAttendanceHistory.Late = viewAttendanceHistory.Late + 1;
												}


											}
											else
											{

												viewAttendanceHistory.Absent = viewAttendanceHistory.Absent + 1;


											}

										}



									}
									else
									{


										viewAttendanceHistory.Absent = viewAttendanceHistory.Absent + 1;


									}

								}
								else
								{
									viewAttendanceHistory.Roster = viewAttendanceHistory.Roster + 1;
								}



							}
							else
							{

								viewAttendanceHistory.Absent = viewAttendanceHistory.Absent + 1;



							}
						}








						NewDate = NewDate.AddDays(1);
					} while (To >= NewDate);

					viewAttendanceHistories.Add(viewAttendanceHistory);

				}
			}


			viewAttendanceHistoryDataGridView.DataSource = null;
			viewAttendanceHistoryDataGridView.DataSource = viewAttendanceHistories;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			DGVPrinter printer = new DGVPrinter();

			printer.Title = "Saad Musa-Home Textile";
			printer.SubTitle = "Attendance History" + Environment.NewLine + "Date:" + dateTimePicker1.Value.ToString("dd/MM/yyyy")+"-"+ dateTimePicker2.Value.ToString("dd/MM/yyyy") + Environment.NewLine + label7.Text.ToString() + Environment.NewLine + " ";


			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

										  StringFormatFlags.NoClip;

			printer.PageNumbers = true;

			printer.PageNumberInHeader = false;
			printer.PrintMargins.Left = 10;
			printer.PrintMargins.Right = 10;
			printer.PorportionalColumns = true;

			printer.HeaderCellAlignment = StringAlignment.Near;

			printer.Footer = "Saad Musa-IT Department";

			printer.FooterSpacing = 15;

			printer.PageSettings.Landscape = true;

			printer.PrintDataGridView(viewAttendanceHistoryDataGridView);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(comboBox3.SelectedValue);
			DateTime From = dateTimePicker1.Value;
			List<Employee> employeesALL = db.Employees.Where(a => a.Section.DepartmentId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From)).ToList();
			PopulateGrid(employees);

			DL.Department section = db.Departments.Find(id);
			label7.Text = "U: " + section.Unit.Name + ";  D: " + section.Name ;

		}
	}
}
