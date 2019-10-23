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
	public partial class Individual_Attendance : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public Individual_Attendance()
		{
			InitializeComponent();
		}

		private void Individual_Attendance_Load(object sender, EventArgs e)
		{
			this.employeeBindingSource.DataSource = db.Employees.ToList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//ViewBag.EmployeeId = new SelectList(db.Employees.Where(a => a.ActiveStatus == true), "Id", "NameWithId");

			Employee employee = db.Employees.Find(Convert.ToInt32(comboBox1.SelectedValue));
			//ViewBag.From = From.ToString("dd/MM/yyyy");
			//ViewBag.From2 = From;

			//ViewBag.To = To.ToString("dd/MM/yyyy");
			//ViewBag.To2 = To;
			//ViewBag.Name = employee.EmpFullName;
			//ViewBag.Id = employee.Emp_Id;
			//ViewBag.Id2 = employee.Id;


			DateTime FromLoop = Convert.ToDateTime(dateTimePicker1.Text);
			DateTime ToLoop = Convert.ToDateTime(dateTimePicker2.Text);


			List<ViewIndividualAttendance> viewAttendances = new List<ViewIndividualAttendance>();


			//Employee Count

			do
			{
				List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == FromLoop.Day && a.CHECKTIME.Year == FromLoop.Year && a.CHECKTIME.Month == FromLoop.Month && a.IsManual == false && a.IsAbsent == false).ToList();

				ViewIndividualAttendance VW = new ViewIndividualAttendance();
				VW.Date = FromLoop;

				//Manual Check
				List<Emp_CheckInOut> Emp_CheckInOutManual = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == FromLoop.Day && a.CHECKTIME.Year == FromLoop.Year && a.CHECKTIME.Month == FromLoop.Month && a.IsManual == true && a.IsAbsent==false && a.UserId == employee.Emp_Id).ToList();
				List<Emp_CheckInOut> Emp_CheckInOutabsent = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == FromLoop.Day && a.CHECKTIME.Year == FromLoop.Year && a.CHECKTIME.Month == FromLoop.Month && a.IsAbsent == true && a.UserId == employee.Emp_Id).ToList();
				var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == employee.Section.DepartmentId && a.From <= FromLoop && a.To >= FromLoop);
				var LeaveDay = db.Leaves.FirstOrDefault(a => a.EmployeeId == employee.Id && a.From >= FromLoop && a.To <= FromLoop);

				if (Emp_CheckInOutManual.Count > 0)
				{
					VW.Status = "Manual!";


					var duty_Roster = db.Duty_Rosters.FirstOrDefault(a => a.Date == FromLoop && a.EmployeeId == employee.Id);
					// Default Assign
					if (duty_Roster == null)
					{
						List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == employee.Id).ToList();
						if (duty_Rosters.Count > 0)
						{
							DateTime date = duty_Rosters.Max(a => a.Date);
							duty_Roster = duty_Rosters.FirstOrDefault(a => a.Date == date);
						}
					}


					VW.Shift = duty_Roster.Shift.Name;
					VW.From = duty_Roster.Shift.From;
					DateTime dateTime = DateTime.Now.Date + duty_Roster.Shift.To;
					if (Emp_CheckInOutManual[0].OT>2)
					{
						dateTime = dateTime.AddHours(2);
					}
					else
					{
						dateTime = dateTime.AddHours(Emp_CheckInOutManual[0].OT);
					}

					VW.To = dateTime.TimeOfDay;
				}
				else if (Emp_CheckInOutabsent.Count > 0)
				{
					VW.Status = "Absent!";
				}
				else if (FromLoop.DayOfWeek.ToString() == "Friday")
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

				else
				{
					//EMployee CheckInOuts
					if (emp_CheckInOuts != null)
					{




						var duty_Roster = db.Duty_Rosters.FirstOrDefault(a => a.Date == FromLoop && a.EmployeeId == employee.Id);
						// Default Assign
						if (duty_Roster == null)
						{
							List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == employee.Id).ToList();
							if (duty_Rosters.Count > 0)
							{
								DateTime date = duty_Rosters.Max(a => a.Date);
								duty_Roster = duty_Rosters.FirstOrDefault(a => a.Date == date);
							}
						}


						//List<SalarySetting> salarySettings = db.SalarySettings.Where(a => a.Date <= FromLoop).ToList();
						//DateTime dateTime = salarySettings.Max(a => a.Date);
						//var salarySetting = salarySettings.FirstOrDefault(a => a.Date == dateTime);
						var salarySetting = db.SalarySettings.FirstOrDefault();


						// Is Duty Roster Has
						if (duty_Roster != null)
						{
							VW.Shift = duty_Roster.Shift.Name;
							List<Emp_CheckInOut> empindividual = emp_CheckInOuts.Where(a => a.UserId == employee.Emp_Id).ToList();
							//Employee Wise Check in out
							if (empindividual.Count > 0)
							{
								//For C Shift
								if (duty_Roster.Shift.IsDayToNight == true)
								{
									DateTime In = FromLoop.Date + duty_Roster.Shift.From;
									DateTime Out = FromLoop.Date + duty_Roster.Shift.To;

									Out = Out.AddDays(1);

									DateTime OutCheck = Out.AddHours(2);
									DateTime InCheck = In.AddHours(-2);


									List<Emp_CheckInOut> emp_CheckInOuts2 = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day >= FromLoop.Day && a.CHECKTIME.Year == FromLoop.Year && a.CHECKTIME.Month == FromLoop.Month && a.CHECKTIME.Day <= FromLoop.Day + 1 && a.IsManual == false && a.IsAbsent == false).ToList();
									List<Emp_CheckInOut> empindividual2 = emp_CheckInOuts2.Where(a => a.UserId == employee.Emp_Id).ToList();

									List<Emp_CheckInOut> empIndividualforshift = empindividual2.Where(a => a.CHECKTIME >= InCheck && a.CHECKTIME <= OutCheck).ToList();

									//Shiftwise CheckinOut
									if (empIndividualforshift.Count > 0)
									{
										DateTime Min = (from d in empIndividualforshift select d.CHECKTIME).Min();
										DateTime Max = (from d in empIndividualforshift select d.CHECKTIME).Max();

										VW.From = Min.TimeOfDay;
										TimeSpan To = Max.TimeOfDay;
										//Calculation for Complience
										TimeSpan timeSpan = To - Out.TimeOfDay;

										if (timeSpan.Hours > 2)
										{
											DateTime dateTime = Out.AddHours(2);
											VW.To = dateTime.TimeOfDay;
										}
										else
										{
											VW.To = To;
										}


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


									DateTime In = FromLoop.Date + duty_Roster.Shift.From;
									DateTime Out = FromLoop.Date + duty_Roster.Shift.To;


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


				FromLoop = FromLoop.AddDays(1);
			} while (FromLoop <= ToLoop);


			viewIndividualAttendanceDataGridView.DataSource = viewAttendances.ToList();

			label4.Text = employee.NameWithId.ToString();

		}

		private void button2_Click(object sender, EventArgs e)
		{
			DGVPrinter printer = new DGVPrinter();
			

			printer.Title = "Saad Musa-Home Textile";

			DateTime date1 = dateTimePicker1.Value;
			DateTime date2 = dateTimePicker2.Value;
			//printer.SubTitle = string.Format("Date:{0}-{0}",date1.Date,date2.Date);
			printer.SubTitle = "Individual Attendance Report" + Environment.NewLine + date1.ToString("dd/MM/yyyy") + "-" + date2.ToString("dd/MM/yyyy") + Environment.NewLine + "Employee:" + label4.Text.ToString() + Environment.NewLine + " ";

			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

										  StringFormatFlags.NoClip;

			printer.PageNumbers = true;

			printer.PageNumberInHeader = false;

			printer.PorportionalColumns = true;

			printer.HeaderCellAlignment = StringAlignment.Near;

			printer.Footer = "Developed By- Saad Musa IT Department";

			printer.FooterSpacing = 15;

			//printer.PageSettings.Landscape = true;

			printer.PrintDataGridView(viewIndividualAttendanceDataGridView);
		}
	}
}
