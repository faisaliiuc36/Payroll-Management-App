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
	public partial class AdvanceDeduction : Form
	{
		DatabaseContext db = new DatabaseContext();
		public AdvanceDeduction()
		{
			InitializeComponent();
		}

		private void AdvanceDeduction_Load(object sender, EventArgs e)
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
			List<Employee> employees = employeesALL.Where(a => a.IsActive(From) && a.IsEdited == true).ToList();

			try
			{
				PopulateGrid(employees);
			}
			catch
			{

			}
		}

		private void PopulateGrid(List<Employee> employees)
		{
			DateTime From = dateTimePicker1.Value;



			List<DL.AdvanceDeduction> viewOTs = new List<DL.AdvanceDeduction>();

			if (employees.Count > 0)
			{
				foreach (Employee emp in employees)
				{
					if (emp.IsWorker == true)
					{
						DL.AdvanceDeduction viewOT = new DL.AdvanceDeduction();
						viewOT.FacCode = emp.Emp_Id.ToString();
						viewOT.FullName = emp.EmpFullName;



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


							}
						}
						catch (Exception Ex)
						{

						}









						viewOT.Gross = Gross;


						//Advance Calculate



						List<Advance> advances = db.Advances.Where(a => a.EmployeeId == emp.Id && a.Date.Month == From.Month && a.Date.Year == From.Year).ToList();
						if (advances.Count > 0)
						{
							viewOT.Advance = advances.Sum(a => a.Amount);
						}


						viewOTs.Add(viewOT);
					}

				}





				advanceDeductionDataGridView.DataSource = viewOTs.ToList();



			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var emp = advanceDeductionDataGridView.DataSource;

			List<DL.AdvanceDeduction> viewSalarySheets = (List<DL.AdvanceDeduction>)emp;


			DateTime From = dateTimePicker1.Value;
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			DL.Section section = db.Sections.Find(id);


			SalaryReportParameter salaryReportParameter = new SalaryReportParameter();
			salaryReportParameter.Unit = section.Department.Unit.Name;
			salaryReportParameter.Department = section.Department.Name;
			salaryReportParameter.Section = section.Name;
			salaryReportParameter.Date = DateTime.Now;

			using (AdvancedeductionCrystalReport salaryCrystalReport = new AdvancedeductionCrystalReport(salaryReportParameter, viewSalarySheets))
			{
				salaryCrystalReport.ShowDialog();
			}
		}
	}
}