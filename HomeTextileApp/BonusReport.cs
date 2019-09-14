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
	public partial class BonusReport : Form
	{
		DatabaseContext db = new DatabaseContext();
		public BonusReport()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy";
			dateTimePicker1.ShowUpDown = true;
			PopulateBonus();
		}

		private void BonusReport_Load(object sender, EventArgs e)
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

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

			PopulateBonus();
		}

		private void PopulateBonus()
		{
			try
			{
				int Year = dateTimePicker1.Value.Year;
				List<Bonus> bonus = db.Bonus.Where(a => a.Date.Year == Year).ToList();

				comboBox1.DataSource = bonus.ToList();
				comboBox1.DisplayMember = "ReasonWithDate";
				comboBox1.ValueMember = "Id";
			}
			catch
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int bonusId = Convert.ToInt32(comboBox1.SelectedValue);
			Bonus bonus = db.Bonus.Find(bonusId);


			DateTime To = bonus.Date;
			DateTime From = To.AddYears(-1);

			int id = Convert.ToInt32(comboBox4.SelectedValue);
			List<Employee> employeesALL = db.Employees.Where(a => a.SectionId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(To) && a.IsEdited == true).ToList();

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
			int bonusId = Convert.ToInt32(comboBox1.SelectedValue);
			Bonus bonus = db.Bonus.Find(bonusId);


			DateTime To = bonus.Date;
			DateTime From = To.AddYears(-1);
			

			List<ViewBonus> viewBonus = new List<ViewBonus>();

			foreach(Employee employee in employees)
			{
				

				ViewBonus view = new ViewBonus();
				try
				{

					DateTime JoiningDate = Convert.ToDateTime(employee.HireDate);
					TimeSpan timeSpan = To.Subtract(JoiningDate);
					view.Year = timeSpan.TotalDays / 365;
				}
				catch
				{

				}


				view.CompanyPercentage = bonus.Amount;
				view.Emp_Id = employee.Emp_Id;
				view.Name = employee.EmpFullName;

				if (employee.IsWorker == true)
				{
					List<WorkerDesignationHistory> workerDesignationHistories = db.WorkerDesignationHistories.Where(a => a.EmployeeId == employee.Id && a.From <= To).ToList();
					if (workerDesignationHistories.Count > 0)
					{
						DateTime maxDate = workerDesignationHistories.Max(a => a.From);

						WorkerDesignationHistory workerDesignationHistory = workerDesignationHistories.FirstOrDefault(a => a.From == maxDate);


						// Find Salary Grade At That Time
						DL.WorkerDesignation workerDesignation = db.WorkerDesignations.Find(workerDesignationHistory.WorkerDesignationId);
						List<ShadowSalaryGrade> shadowSalaryGrades = db.ShadowSalaryGrades.Where(a => a.UpdatedAt <= To && a.RoWId == workerDesignation.SalaryGrade.Id).ToList();
						DateTime D2 = DateTime.Now;
						if (shadowSalaryGrades.Count > 0)
						{
							D2 = shadowSalaryGrades.Max(a => a.UpdatedAt);
							var shadowgrade = shadowSalaryGrades.FirstOrDefault(a => a.RoWId == workerDesignation.SalaryGrade.Id && a.UpdatedAt == D2);
							view.Grade = shadowgrade.GradeName;
							view.Gross = shadowgrade.Total;
							view.Basic = shadowgrade.Salary;
						}


					}
				}
				else
				{
					List<Salary> salaries = db.Salaries.Where(a => a.EmployeeId == employee.Id && a.Date <= To).ToList();
					if (salaries.Count > 0)
					{
						DateTime maxDate = salaries.Max(a => a.Date);

						Salary salary = salaries.FirstOrDefault(a => a.Date == maxDate);

						//view.Grade = salary.;
						view.Gross = salary.Amount;


						List<SalarySetting> salarySettings = db.SalarySettings.Where(a => a.Date <= To).ToList();
						if(salarySettings.Count>0)
						{
							DateTime maxDate2 = salarySettings.Max(a => a.Date);
							SalarySetting settings = salarySettings.FirstOrDefault(a => a.Date == maxDate2);
							view.Basic = salary.Amount*(100/ settings.Basic);
						}
					}
				}


				//Count Employee attendance
				List<Emp_CheckInOut> emp_CheckInOuts = db.Emp_CheckInOuts.Where(a=>a.UserId==employee.Emp_Id).ToList();

				var DayCount = emp_CheckInOuts.Where(a => a.CHECKTIME >= From && a.CHECKTIME <= To ).GroupBy(a => a.CHECKTIME.Date).ToList();
				view.Days = DayCount.Count - 1;
				
				viewBonus.Add(view);
			}

			viewBonusDataGridView.DataSource = viewBonus.ToList();
			viewBonusDataGridView1.DataSource = viewBonus.ToList();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			int bonusId = Convert.ToInt32(comboBox1.SelectedValue);
			Bonus bonus = db.Bonus.Find(bonusId);


			DateTime To = bonus.Date;
			DateTime From = To.AddYears(-1);

			int id = Convert.ToInt32(comboBox3.SelectedValue);
			List<Employee> employeesALL = db.Employees.Where(a => a.Section.DepartmentId == id).ToList();
			List<Employee> employees = employeesALL.Where(a => a.IsActive(To) && a.IsEdited == true).ToList();

			PopulateGrid(employees);

			//try
			//{
			//	PopulateGrid(employees);
			//}
			//catch
			//{

			//}
		}
	}
}
