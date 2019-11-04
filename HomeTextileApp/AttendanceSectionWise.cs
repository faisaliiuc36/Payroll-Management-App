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
	public partial class AttendanceSectionWise : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public AttendanceSectionWise()
		{
			InitializeComponent();
		}

		private void AttendanceSectionWise_Load(object sender, EventArgs e)
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
			DateTime From = dateTimePicker1.Value;
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			List<Employee> employeesALL = db.Employees.Where(a => a.SectionId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From)).ToList();

			PopulateGrid(employees);

			DL.Section section = db.Sections.Find(id);
			label5.Text="U: "+section.Department.Unit.Name+ ";  D: "+section.Department.Name+";  S: "+ section.Name;
		}

		private void PopulateGrid(List<Employee> employees)
		{
			DateTime From = dateTimePicker1.Value;
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == From.Day && a.CHECKTIME.Year == From.Year && a.CHECKTIME.Month == From.Month && a.IsAbsent != true && a.IsManual != true).ToList();

			List<ViewAttendance> viewAttendances = new List<ViewAttendance>();


			//Employee Count
			if (employees.Count > 0)
			{
				foreach (Employee emp in employees)
				{
					ViewAttendance VW = new ViewAttendance();
					VW.EmpFullName = emp.EmpFullName;
					VW.Emp_Id = emp.Emp_Id;
					//Manual Check
					List<Emp_CheckInOut> Emp_CheckInOutManual = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == From.Day && a.CHECKTIME.Year == From.Year && a.CHECKTIME.Month == From.Month && a.IsManual == true && a.IsAbsent==false && a.UserId == emp.Emp_Id).ToList();
					List<Emp_CheckInOut> Emp_CheckInOutAbsent = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == From.Day && a.CHECKTIME.Year == From.Year && a.CHECKTIME.Month == From.Month && a.IsAbsent == true && a.UserId == emp.Emp_Id).ToList();

					var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == emp.Section.DepartmentId && a.From <= From && a.To >= From);
					var LeaveDay = db.Leaves.FirstOrDefault(a => a.EmployeeId == emp.Id && a.From >= From && a.To <= From);

					if (Emp_CheckInOutManual.Count > 0)
					{
						VW.Status = "Manual!";
						var duty_Rosterformanual = db.Duty_Rosters.FirstOrDefault(a => a.Date == From && a.EmployeeId == emp.Id );
						// Default Assign
						if (duty_Rosterformanual == null)
						{
							List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == emp.Id && a.Date < From).ToList();
							if (duty_Rosters.Count > 0)
							{
								DateTime date = duty_Rosters.Max(a => a.Date);
								duty_Rosterformanual = duty_Rosters.FirstOrDefault(a => a.Date == date);
							}
						}

						if (duty_Rosterformanual != null)
						{
							VW.From = duty_Rosterformanual.Shift.From;

							DateTime dateTime = DateTime.Now.Date + duty_Rosterformanual.Shift.To;
							
							dateTime = dateTime.AddHours(Emp_CheckInOutManual[0].OT);
							

							VW.To = dateTime.TimeOfDay;

						}

					}
					else if (From.DayOfWeek.ToString() == "Friday")
					{
						VW.Status = "Weekend";
					}
					else if (Holiday != null)
					{
						VW.Status = "Holiday";
					}

					else if (LeaveDay != null)
					{
						VW.Status = "Leave";
					}
					else if (Emp_CheckInOutAbsent.Count > 0)
					{
						VW.Status = "Absent";

					}
					else
					{
						//EMployee CheckInOuts
						if (emp_CheckInOuts != null)
						{
							var duty_Roster = db.Duty_Rosters.FirstOrDefault(a => a.Date == From && a.EmployeeId == emp.Id);
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

							var salarySetting = db.SalarySettings.FirstOrDefault();
							// Is Duty Roster Has
							if (duty_Roster != null)
							{

								VW.Shift = duty_Roster.Shift.Name;
								List<Emp_CheckInOut> empindividual = emp_CheckInOuts.Where(a => a.UserId == emp.Emp_Id).ToList();
								//Employee Wise Check in out
								if (empindividual.Count > 0)
								{

									//For C Shift
									if (duty_Roster.Shift.IsDayToNight == true)
									{
										DateTime In = From.Date + duty_Roster.Shift.From;
										DateTime Out = From.Date + duty_Roster.Shift.To;

										Out = Out.AddDays(1);

										DateTime OutCheck = Out.AddHours(2);
										DateTime InCheck = In.AddHours(-2);


										List<Emp_CheckInOut> emp_CheckInOuts2 = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day >= From.Day && a.CHECKTIME.Year == From.Year && a.CHECKTIME.Month == From.Month && a.CHECKTIME.Day <= From.Day + 1 && a.IsManual != true && a.IsAbsent == false).ToList();
										List<Emp_CheckInOut> empindividual2 = emp_CheckInOuts2.Where(a => a.UserId == emp.Emp_Id).ToList();

										List<Emp_CheckInOut> empIndividualforshift = empindividual2.Where(a => a.CHECKTIME >= InCheck && a.CHECKTIME <= OutCheck).ToList();

										//Shiftwise CheckinOut
										if (empIndividualforshift.Count > 0)
										{
											DateTime Min = (from d in empIndividualforshift select d.CHECKTIME).Min();
											DateTime Max = (from d in empIndividualforshift select d.CHECKTIME).Max();

											VW.From = Min.TimeOfDay;
											VW.To = Max.TimeOfDay;

											//Status Calculation
											DateTime InForStatus = In.AddMinutes(salarySetting.Time);
											DateTime OutForStatus = Out.AddMinutes(-1 * salarySetting.Time);
											if (Min == Max)
											{
												VW.Status = "Invalid";
											}
											else if (Min <= InForStatus && Max >= OutForStatus)
											{
												VW.Status = "Present";
											}
											else if (Min > InForStatus && Max >= OutForStatus)
											{
												VW.Status = "Late";
											}

											else if (Min <= InForStatus && Max < OutForStatus)
											{
												VW.Status = "Early Leave";
											}

											else if (Min > InForStatus && Max < OutForStatus)
											{
												VW.Status = "Early Leave+ Late";
											}


										}
										else
										{

											VW.Status = "Absent";

										}

									}
									else
									{


										DateTime In = From.Date + duty_Roster.Shift.From;
										DateTime Out = From.Date + duty_Roster.Shift.To;


										DateTime OutCheck = Out.AddHours(2);
										DateTime InCheck = In.AddHours(-2);

										List<Emp_CheckInOut> empIndividualforshift = empindividual.Where(a => a.CHECKTIME >= InCheck && a.CHECKTIME <= OutCheck).ToList();
										//Shift Wise Check In Out
										if (empIndividualforshift.Count > 0)
										{
											DateTime Min = (from d in empIndividualforshift select d.CHECKTIME).Min();
											DateTime Max = (from d in empIndividualforshift select d.CHECKTIME).Max();

											VW.From = Min.TimeOfDay;
											VW.To = Max.TimeOfDay;

											//Status Calculation
											DateTime InForStatus = In.AddMinutes(salarySetting.Time);
											DateTime OutForStatus = Out.AddMinutes(-1 * salarySetting.Time);
											if (Min == Max)
											{
												VW.Status = "Invalid";
											}
											else if (Min <= InForStatus && Max >= OutForStatus)
											{
												VW.Status = "Present";
											}
											else if (Min > InForStatus && Max >= OutForStatus)
											{
												VW.Status = "Late";
											}

											else if (Min <= InForStatus && Max < OutForStatus)
											{
												VW.Status = "Early Leave";
											}

											else if (Min > InForStatus && Max < OutForStatus)
											{
												VW.Status = "Early Leave+ Late";
											}


										}
										else
										{
											VW.Status = "Absent";

										}

									}



								}
								else
								{

									VW.Status = "Absent";


								}
							}
							else
							{
								VW.Status = "Duty Roster Not Assign";
							}


						}
						else
						{
							VW.Status = "Absent";
						}
					}

					viewAttendances.Add(VW);
				}

			}
			viewAttendanceDataGridView.DataSource = viewAttendances.ToList();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DGVPrinter printer = new DGVPrinter();

			printer.Title = "Saad Musa-Home Textile";
			printer.SubTitle = "Daily Attendance Report"+Environment.NewLine+ "Date-"+ dateTimePicker1.Value.ToString("dd/MM/yyyy")+Environment.NewLine+label5.Text.ToString()+Environment.NewLine+" ";
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


			printer.PrintDataGridView(viewAttendanceDataGridView);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DateTime From = dateTimePicker1.Value;
			int id = Convert.ToInt32(comboBox3.SelectedValue);
			List<Employee> employeesALL = db.Employees.Where(a => a.Section.DepartmentId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From)).ToList();

			PopulateGrid(employees);

			DL.Department section = db.Departments.Find(id);
			label5.Text = "U: " + section.Unit.Name + ";  D: " + section.Name ;
		}
	}
}
