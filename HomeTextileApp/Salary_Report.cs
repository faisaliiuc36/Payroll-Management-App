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
	public partial class Salary_Report : Form
	{
		DatabaseContext db = new DatabaseContext();
		public Salary_Report()
		{
			InitializeComponent();
		}

		private void Salary_Report_Load(object sender, EventArgs e)
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

		private void button2_Click(object sender, EventArgs e)
		{
			DGVPrinter printer = new DGVPrinter();

			printer.Title = "Salary Report";
			printer.SubTitle = "Saad Musa Group of Industries";

			printer.SubTitle = string.Format("Date:{0}", dateTimePicker1.Value.Date);

			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |

										  StringFormatFlags.NoClip;

			printer.PageNumbers = true;

			printer.PageNumberInHeader = false;
			printer.PrintMargins.Left = 10;
			printer.PrintMargins.Right = 10;
			printer.PorportionalColumns = true;

			printer.HeaderCellAlignment = StringAlignment.Near;

			printer.Footer = "Saad Musa-Home Textile";

			printer.FooterSpacing = 15;

			printer.PageSettings.Landscape = true;

			printer.PrintDataGridView(viewSalarySheetDataGridView);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime From = dateTimePicker1.Value;
			int id = Convert.ToInt32(comboBox4.SelectedValue);


			List<ViewSalarySheet> viewSalarySheets = new List<ViewSalarySheet>();
			List<Employee> employeesALL = db.Employees.Where(a => a.SectionId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From)).ToList();

			if (employees.Count > 0)
			{
				foreach (Employee emp in employees)
				{
					ViewSalarySheet viewSalarySheet = new ViewSalarySheet();
					viewSalarySheet.Emp_Id = emp.Emp_Id;
					viewSalarySheet.Name = emp.EmpFullName;
					if(emp.IsWorker ==false)
					{
						List<Salary> salaries = db.Salaries.Where(a => a.Date <= From && a.EmployeeId == emp.Id).ToList();
						DateTime D = DateTime.Now;
						if (salaries.Count > 0)
						{
							D = salaries.Max(a => a.Date);
						}

						var salary = db.Salaries.FirstOrDefault(a => a.EmployeeId == emp.Id && a.Date == D);

						var salarySetting = db.SalarySettings.FirstOrDefault();
						if (salary != null)
						{
							//Other
							viewSalarySheet.Other = salary.TechnicalAllowance + salary.Amount * (salarySetting.Others / 100);
							//Gross
							viewSalarySheet.Gross = salary.Amount + salary.TechnicalAllowance;
							//Basic
							viewSalarySheet.Basic = salary.Amount * (salarySetting.Basic / 100);
							//HouseRent
							viewSalarySheet.HouseRent = salary.Amount * (salarySetting.HouseRent / 100);
							//Convenience
							viewSalarySheet.Conv = salary.Amount * (salarySetting.convenience / 100);
							//Medical
							viewSalarySheet.Medical = salary.Amount * (salarySetting.Medical / 100);
							////Bonus
							//var Bonus = db.Bonus.FirstOrDefault(a => a.Date.Month == From.Month && a.Date.Year == From.Year);
							//if (Bonus != null && emp.IsTrainee != true)
							//{
							//	viewSalarySheet.Bonus = salary.Amount * (Bonus.Amount / 100);
							//}
							//DFood
							viewSalarySheet.DFood = 0;
							//DTax
							viewSalarySheet.DTax = salary.Amount * (salarySetting.Tax / 100);
							//DSTamp
							viewSalarySheet.DStamp = salarySetting.Stamp;
							//Dloan
							var loanPayment = db.Paytimes.FirstOrDefault(a => a.Date.Month == From.Month && a.Date.Year == From.Year && a.Loan.EmployeeId == emp.Id);
							if (loanPayment != null)
							{
								//List<Paytime> ptimes = db.Paytimes.Where(a => a.LoanId == loanPayment.LoanId).ToList();

								viewSalarySheet.DLoan = loanPayment.Loan.Amount / loanPayment.Loan.Installment;
							}

						}


						//Salary Days
						viewSalarySheet.SalaryDays = DateTime.DaysInMonth(From.Year, From.Month); ;
						//Salary Days, Absent, Leave
						DateTime NewDate = new DateTime(From.Year, From.Month, 1); ;
						do
						{

							//Leave
							var leave = db.Leaves.FirstOrDefault(a => a.From <= NewDate && a.To >= NewDate);
							var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == emp.Section.DepartmentId && a.From <= NewDate && a.To >= NewDate);
							if (leave != null)
							{
								viewSalarySheet.Leave = viewSalarySheet.Leave + 1;
							}
							//Absent
							int Late = 0;



							//Employee Count


							List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsManual != true && a.IsAbsent !=true).ToList();



							//Manual Check
							List<Emp_CheckInOut> Emp_CheckInOutManual = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsManual == true && a.UserId == emp.Emp_Id).ToList();
							List<Emp_CheckInOut> Emp_CheckInOutAbsent = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsAbsent == true && a.UserId == emp.Emp_Id).ToList();
							
							 if (Emp_CheckInOutAbsent.Count>0)
							{
								viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
							}
							else if (Emp_CheckInOutManual.Count <= 0 && NewDate.DayOfWeek.ToString() != "Friday" && leave == null && Holiday==null)
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


												List<Emp_CheckInOut> emp_CheckInOuts2 = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day >= NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.CHECKTIME.Day <= NewDate.Day + 1 && a.IsAbsent != true && a.IsManual !=true).ToList();
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
														viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

													}

													else if (Min > InForStatus && Max >= OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min <= InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min > InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}


												}
												else
												{
		
														viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

													
												}

											}
											else
											{


												DateTime In = NewDate.Date + duty_Roster.Shift.From;
												DateTime Out = NewDate.Date +duty_Roster.Shift.To;


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
														viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

													}

													else if (Min > InForStatus && Max >= OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min <= InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min > InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}


												}
												else
												{
													
														viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

													
												}

											}



										}
										else
										{

										
												viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

											
										}
									}




								}
								else
								{
									
										viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

									
								}
							}








							NewDate = NewDate.AddDays(1);
						} while (From.Month == NewDate.Month);

						viewSalarySheet.DAbsent = (viewSalarySheet.Gross / viewSalarySheet.SalaryDays) * viewSalarySheet.Absent;
						viewSalarySheet.NetSalary = viewSalarySheet.Gross + viewSalarySheet.Bonus - (viewSalarySheet.DAbsent + viewSalarySheet.DAdvance + viewSalarySheet.DFood + viewSalarySheet.DLoan + viewSalarySheet.DStamp + viewSalarySheet.DTax);
						viewSalarySheets.Add(viewSalarySheet);

					}
					else
					{
						////List<SalaryGrade> salaries = db.SalaryGrades.Where(a => a.EffectiveFrom <= From && a. == emp).ToList();
						//DateTime D = DateTime.Now;
						//if (salaries.Count > 0)
						//{
						//	D = salaries.Max(a => a.Date);
						//}

						//var salary = db.Salaries.FirstOrDefault(a => a.EmployeeId == emp.Id && a.Date == D);

						var salarySetting = db.SalarySettings.FirstOrDefault();

						List<WorkerDesignationHistory> workerDesignationHistories = db.WorkerDesignationHistories.Where(a => a.EmployeeId == emp.Id && a.From <= From).ToList();
						if (workerDesignationHistories.Count > 0)
						{
							DateTime maxDate = workerDesignationHistories.Max(a => a.From);

							WorkerDesignationHistory workerDesignationHistory = workerDesignationHistories.FirstOrDefault(a => a.From == maxDate);


							// Find Salary Grade At That Time
							DL.WorkerDesignation workerDesignation = db.WorkerDesignations.Find(workerDesignationHistory.WorkerDesignationId);
							List<ShadowSalaryGrade> shadowSalaryGrades = db.ShadowSalaryGrades.Where(a => a.UpdatedAt <= From && a.RoWId == workerDesignation.SalaryGrade.Id).ToList();
							DateTime D2 = DateTime.Now;
							if (shadowSalaryGrades.Count > 0)
							{
								D2 = shadowSalaryGrades.Max(a => a.UpdatedAt);
								var shadowgrade = shadowSalaryGrades.FirstOrDefault(a => a.RoWId == workerDesignation.SalaryGrade.Id && a.UpdatedAt == D2);

								//Other
								viewSalarySheet.Other = workerDesignationHistory.TechnicalAllowance;
								//Gross
								viewSalarySheet.Gross = shadowgrade.Total;
								//Basic
								viewSalarySheet.Basic = shadowgrade.Salary;
								//HouseRent
								viewSalarySheet.HouseRent = shadowgrade.HouseRent;
								//Medical
								viewSalarySheet.Medical = shadowgrade.MedicalAllowance;
								//Bonus
								var Bonus = db.Bonus.FirstOrDefault(a => a.Date.Month == From.Month && a.Date.Year == From.Year);
								if (Bonus != null && emp.IsTrainee != true)
								{
									viewSalarySheet.Bonus = shadowgrade.Total * (Bonus.Amount / 100);
								}
								//DFood
								viewSalarySheet.DFood = shadowgrade.FoodAllowance;
								//DTax
								//viewSalarySheet.DTax = salary.Amount * (salarySetting.Tax / 100);
								//DSTamp
								viewSalarySheet.DStamp = salarySetting.Stamp;
								//Dloan
								var loanPayment = db.Paytimes.FirstOrDefault(a => a.Date.Month == From.Month && a.Date.Year == From.Year && a.Loan.EmployeeId == emp.Id);
								if (loanPayment != null)
								{
									//List<Paytime> ptimes = db.Paytimes.Where(a => a.LoanId == loanPayment.LoanId).ToList();

									viewSalarySheet.DLoan = loanPayment.Loan.Amount / loanPayment.Loan.Installment;
								}



							}


						}



							


						//Salary Days
						viewSalarySheet.SalaryDays = DateTime.DaysInMonth(From.Year, From.Month); ;
						//Salary Days, Absent, Leave
						DateTime NewDate = new DateTime(From.Year, From.Month, 1); ;
						do
						{

							//Leave
							var leave = db.Leaves.FirstOrDefault(a => a.From <= NewDate && a.To >= NewDate);
							var Holiday = db.Holidays.FirstOrDefault(a => a.DepartmentId == emp.Section.DepartmentId && a.From <= NewDate && a.To >= NewDate);
							if (leave != null)
							{
								viewSalarySheet.Leave = viewSalarySheet.Leave + 1;
							}
							//Absent
							int Late = 0;



							//Employee Count


							List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsManual != true && a.IsAbsent != true).ToList();



							//Manual Check
							List<Emp_CheckInOut> Emp_CheckInOutManual = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsManual == true && a.UserId == emp.Emp_Id).ToList();
							List<Emp_CheckInOut> Emp_CheckInOutAbsent = db.Emp_CheckInOuts.Where(a => a.CHECKTIME.Day == NewDate.Day && a.CHECKTIME.Year == NewDate.Year && a.CHECKTIME.Month == NewDate.Month && a.IsAbsent == true && a.UserId == emp.Emp_Id).ToList();

							if (Emp_CheckInOutAbsent.Count > 0)
							{
								viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
							}
							else if (Emp_CheckInOutManual.Count <= 0 && NewDate.DayOfWeek.ToString() != "Friday" && leave == null && Holiday==null)
							{


								//EMployee CheckInOuts
								if (emp_CheckInOuts != null)
								{
									var duty_Roster = db.Duty_Rosters.FirstOrDefault(a => a.Date == From && a.EmployeeId == emp.Id);
									// Default Assign
									if (duty_Roster == null && emp.IsWorker == false)
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
														viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

													}

													else if (Min > InForStatus && Max >= OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min <= InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min > InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}


												}
												else
												{

													viewSalarySheet.Absent = viewSalarySheet.Absent + 1;


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
														viewSalarySheet.Absent = viewSalarySheet.Absent + 1;

													}

													else if (Min > InForStatus && Max >= OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min <= InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}

													else if (Min > InForStatus && Max < OutForStatus)
													{
														Late = Late + 1;
														if (Late == 5)
														{
															viewSalarySheet.Absent = viewSalarySheet.Absent + 1;
															Late = 0;

														}
													}


												}
												else
												{

													viewSalarySheet.Absent = viewSalarySheet.Absent + 1;


												}

											}



										}
										else
										{


											viewSalarySheet.Absent = viewSalarySheet.Absent + 1;


										}
									}




								}
								else
								{

									viewSalarySheet.Absent = viewSalarySheet.Absent + 1;


								}
							}








							NewDate = NewDate.AddDays(1);
						} while (From.Month == NewDate.Month);

						viewSalarySheet.DAbsent = (viewSalarySheet.Gross / viewSalarySheet.SalaryDays) * viewSalarySheet.Absent;
						viewSalarySheet.NetSalary = viewSalarySheet.Gross + viewSalarySheet.Bonus - (viewSalarySheet.DAbsent + viewSalarySheet.DAdvance + viewSalarySheet.DFood + viewSalarySheet.DLoan + viewSalarySheet.DStamp + viewSalarySheet.DTax);
						viewSalarySheets.Add(viewSalarySheet);

					}

				}
			}






			viewSalarySheetDataGridView.DataSource = viewSalarySheets;
		}
	}
}
