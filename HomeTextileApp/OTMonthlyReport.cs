﻿using HomeTextileApp.DL;
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
	public partial class OTMonthlyReport : Form
	{
		DatabaseContext db = new DatabaseContext();
		public OTMonthlyReport()
		{
			InitializeComponent();
		}

		private void OTMonthlyReport_Load(object sender, EventArgs e)
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


		private void PopulateGrid(List<Employee> employees)
		{
			List<ViewOT> viewOTs = new List<ViewOT>();
			if (employees.Count > 0)
			{
				
				foreach (Employee emp in employees)
				{

					DateTime From = Convert.ToDateTime(dateTimePicker1.Text);
					DateTime To = Convert.ToDateTime(dateTimePicker2.Text);
				


				


					if (emp.IsWorker == true)
					{
						ViewOT viewOT = new ViewOT();
						viewOT.Emp_Id = emp.Emp_Id;
						viewOT.Name = emp.EmpFullName;
						


						double Gross = 0;


						try
						{
							// Find Employee At That Time
							List<WorkerDesignationHistory> workerDesignationHistories = db.WorkerDesignationHistories.Where(a => a.From <= From && a.EmployeeId == emp.Id).ToList();
							DateTime D = DateTime.Now;
							if (workerDesignationHistories.Count > 0)
							{
								D = workerDesignationHistories.Max(a => a.From);


								var shadowEmp = workerDesignationHistories.FirstOrDefault(a => a.EmployeeId == emp.Id && a.From == D);

								// Find Salary Grade At That Time
								DL.WorkerDesignation workerDesignation = db.WorkerDesignations.Find(shadowEmp.WorkerDesignationId);
								List<ShadowSalaryGrade> shadowSalaryGrades = db.ShadowSalaryGrades.Where(a => a.UpdatedAt <= From && a.RoWId == workerDesignation.SalaryGrade.Id).ToList();
								DateTime D2 = DateTime.Now;
								if (shadowSalaryGrades.Count > 0)
								{
									D2 = shadowSalaryGrades.Max(a => a.UpdatedAt);
									var shadowgrade = shadowSalaryGrades.FirstOrDefault(a => a.RoWId == workerDesignation.SalaryGrade.Id && a.UpdatedAt == D2);
									Gross = shadowgrade.Total;
								}

								viewOT.Grade = shadowEmp.WorkerDesignation.SalaryGrade.GradeName;
							}
						}
						catch (Exception Ex)
						{
							break;
						}









						viewOT.Gross = Gross;

						do
						{

							DateTime FromND = From.AddDays(1);
							int totalHour = 0;

							var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == emp.Section.DepartmentId && a.From <= From && a.To >= From);
							var leave = db.Leaves.FirstOrDefault(a => a.From <= From && a.To >= From);

							//Duty Roster
							var duty_Roster = db.Duty_Rosters.FirstOrDefault(a => a.Date == From && a.EmployeeId == emp.Id);
							var duty_RosterND = db.Duty_Rosters.FirstOrDefault(a => a.Date == FromND && a.EmployeeId == emp.Id);
							// Default Assign
							if (duty_Roster == null)
							{
								List<DL.Duty_Roster> duty_Rosters = db.Duty_Rosters.Where(a => a.EmployeeId == emp.Id && a.Date < From).ToList();
								if (duty_Rosters.Count > 0)
								{
									DateTime date = duty_Rosters.Max(a => a.Date);
									duty_Roster = duty_Rosters.FirstOrDefault(a => a.Date == date);
								}
							}
							// Default Assign
							if (duty_RosterND == null)
							{

								duty_RosterND = duty_Roster;

							}

							//Employee Count


							List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == From.Day && a.CHECKTIME.Year == From.Year && a.CHECKTIME.Month == From.Month && a.IsManual != true && a.IsAbsent != true).ToList();



							//Manual Check
							List<Emp_CheckInOut> Emp_CheckInOutManual = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == From.Day && a.CHECKTIME.Year == From.Year && a.CHECKTIME.Month == From.Month && a.IsManual == true && a.UserId == emp.Emp_Id).ToList();


							if (Emp_CheckInOutManual.Count > 0)
							{
								viewOT.TotalHour = viewOT.TotalHour + Emp_CheckInOutManual[0].OT;
								totalHour = Emp_CheckInOutManual[0].OT;
								if (duty_Roster != null)
								{
									viewOT.InTime = From.Date + duty_Roster.Shift.From;
									viewOT.OutTime = From.Date + duty_Roster.Shift.To;
									viewOT.OutTime = viewOT.OutTime.AddHours(Emp_CheckInOutManual[0].OT);
									if (duty_Roster.Shift.IsDayToNight == true)
									{
										viewOT.OutTime = viewOT.OutTime.AddDays(1);
									}
								}
							}
							else if (Emp_CheckInOutManual.Count <= 0 && leave == null)
							{


								//EMployee CheckInOuts
								if (emp_CheckInOuts != null)
								{


									//var salarySetting2 = db.SalarySettings.FirstOrDefault();
									// Is Duty Roster Has

									if (duty_Roster != null)
									{


										List<Emp_CheckInOut> empindividual = emp_CheckInOuts.Where(a => a.UserId == emp.Emp_Id).ToList();
										//Employee Wise Check in out
										if (empindividual.Count > 0)
										{

											DateTime In = From.Date + duty_Roster.Shift.From;
											DateTime Out = From.Date + duty_Roster.Shift.To;

											if (duty_Roster.Shift.IsDayToNight == true)
											{
												Out = Out.AddDays(1);
											}

											DateTime OutCheck = FromND.Date + duty_RosterND.Shift.From;
											OutCheck = OutCheck.AddHours(-4);
											DateTime InCheck = In.AddHours(-2);


											List<Emp_CheckInOut> emp_CheckInOuts2 = db.Emp_CheckInOuts.Where(a => a.CHECKTIME >= InCheck && a.CHECKTIME <= OutCheck && a.IsAbsent != true && a.IsManual != true).ToList();
											List<Emp_CheckInOut> empIndividualforshift = emp_CheckInOuts2.Where(a => a.UserId == emp.Emp_Id).ToList();


											//Shiftwise CheckinOut
											if (empIndividualforshift.Count > 0)
											{
												DateTime Min = (from d in empIndividualforshift select d.CHECKTIME).Min();
												DateTime Max = (from d in empIndividualforshift select d.CHECKTIME).Max();
												viewOT.InTime = Min;
												viewOT.OutTime = Out;


												Max = Max.AddMinutes(10); // Minute Consider

												// OT Calculation

												if (From.DayOfWeek.ToString() == "Friday" || Holiday != null)
												{
													TimeSpan timeSpan = Max - Min;
													viewOT.TotalHour = viewOT.TotalHour + (int)Math.Abs(timeSpan.TotalHours);
													totalHour = (int)Math.Abs(timeSpan.TotalHours);
												}
												else
												{
													TimeSpan timeSpan = Max - Out;
													viewOT.TotalHour = viewOT.TotalHour + (int)Math.Abs(timeSpan.TotalHours);
													totalHour = (int)Math.Abs(timeSpan.TotalHours);
												}

											}


										}


									}

								}




							}

							//Complience Calculate
							if (totalHour > 2)
							{
								viewOT.TotalHourC = viewOT.TotalHourC+2;
							}
							else
							{
								viewOT.TotalHourC = viewOT.TotalHourC+ totalHour;
							}








					









					From = From.AddDays(1);
				} while (From <= To) ;


						viewOTs.Add(viewOT);

					}
				
				}

	


			}
			viewOTDataGridView.DataSource = viewOTs.ToList();
			viewOTDataGridView1.DataSource = viewOTs.ToList();


		}

		private void button1_Click(object sender, EventArgs e)
		{

			DateTime From = dateTimePicker1.Value;
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

		private void button3_Click(object sender, EventArgs e)
		{
			DateTime From = dateTimePicker1.Value;
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
			var emp = viewOTDataGridView.DataSource;

			List<ViewOT> viewSalarySheets = (List<ViewOT>)emp;


			DateTime From = dateTimePicker1.Value;
			DateTime Loop = new DateTime(From.Year, From.Month, 1);
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			DL.Section section = db.Sections.Find(id);


			SalaryReportParameter salaryReportParameter = new SalaryReportParameter();
			salaryReportParameter.Unit = section.Department.Unit.Name;
			salaryReportParameter.Department = section.Department.Name;
			salaryReportParameter.Section = section.Name;
			salaryReportParameter.Date = From;
			do
			{
				salaryReportParameter.Days = salaryReportParameter.Days + 1;
				if (Loop.DayOfWeek.ToString() == "Friday")
				{
					salaryReportParameter.Weekend = salaryReportParameter.Weekend + 1;
				}

				var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == section.DepartmentId && a.From <= Loop && a.To >= Loop);
				if (Holiday != null)
				{
					salaryReportParameter.Holiday = salaryReportParameter.Holiday + 1;
				}
				Loop = Loop.AddDays(1);
			} while (Loop.Month == From.Month);


			using (OTPaymentCrystalReport salaryCrystalReport = new OTPaymentCrystalReport(salaryReportParameter, viewSalarySheets))
			{
				salaryCrystalReport.ShowDialog();
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			var emp = viewOTDataGridView.DataSource;

			List<ViewOT> viewSalarySheets = (List<ViewOT>)emp;


			DateTime From = dateTimePicker1.Value;
			DateTime Loop = new DateTime(From.Year, From.Month, 1);
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			DL.Section section = db.Sections.Find(id);


			SalaryReportParameter salaryReportParameter = new SalaryReportParameter();
			salaryReportParameter.Unit = section.Department.Unit.Name;
			salaryReportParameter.Department = section.Department.Name;
			salaryReportParameter.Section = section.Name;
			salaryReportParameter.Date = From;
			do
			{
				salaryReportParameter.Days = salaryReportParameter.Days + 1;
				if (Loop.DayOfWeek.ToString() == "Friday")
				{
					salaryReportParameter.Weekend = salaryReportParameter.Weekend + 1;
				}

				var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == section.DepartmentId && a.From <= Loop && a.To >= Loop);
				if (Holiday != null)
				{
					salaryReportParameter.Holiday = salaryReportParameter.Holiday + 1;
				}
				Loop = Loop.AddDays(1);
			} while (Loop.Month == From.Month);


			using (OTPaymentCrystalComReport salaryCrystalReport = new OTPaymentCrystalComReport(salaryReportParameter, viewSalarySheets))
			{
				salaryCrystalReport.ShowDialog();
			}
		}
	}
}
