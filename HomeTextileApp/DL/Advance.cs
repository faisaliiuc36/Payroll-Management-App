using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	class Advance
	{
		private DatabaseContext db = new DatabaseContext();
		public int Id { get; set; }


		[Display(Name = "Select An Employee")]
		[Required(ErrorMessage = "Please Select Employee")]
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		public virtual Employee Employee { get; set; }

		[Display(Name = "Amount")]
		[Required(ErrorMessage = "Please Select Amount")]
		public double Amount { get; set; }


		public int Installment { get; set; }

		[Display(Name = "Date")]
		[Required(ErrorMessage = "Please Select Date")]
		public DateTime Date { get; set; }



		public bool IsAbleToTakeAdvance()
		{
			List<Advance> advances = db.Advances.Where(a => a.EmployeeId == this.EmployeeId && a.Date.Year == this.Date.Year && a.Date.Month == this.Date.Month).ToList();
			double advTotal = this.Amount;
			if(advances.Count>0)
			{
				advTotal = advTotal+advances.Sum(a => a.Amount);
			}

			Employee employee = db.Employees.Find(this.EmployeeId);
			double grossSalary = 0;

			if(employee.IsWorker==true)
			{
				List<WorkerDesignationHistory> workerDesignationHistories = db.WorkerDesignationHistories.Where(a => a.EmployeeId == this.EmployeeId && a.From <= this.Date).ToList();
				if (workerDesignationHistories.Count > 0)
				{
					DateTime maxDate = workerDesignationHistories.Max(a => a.From);

					WorkerDesignationHistory workerDesignationHistory = workerDesignationHistories.FirstOrDefault(a => a.From == maxDate);


					// Find Salary Grade At That Time
					DL.WorkerDesignation workerDesignation = db.WorkerDesignations.Find(workerDesignationHistory.WorkerDesignationId);
					List<ShadowSalaryGrade> shadowSalaryGrades = db.ShadowSalaryGrades.Where(a => a.UpdatedAt <= this.Date && a.RoWId == workerDesignation.SalaryGrade.Id).ToList();
					DateTime D2 = DateTime.Now;
					if (shadowSalaryGrades.Count > 0)
					{
						D2 = shadowSalaryGrades.Max(a => a.UpdatedAt);
						var shadowgrade = shadowSalaryGrades.FirstOrDefault(a => a.RoWId == workerDesignation.SalaryGrade.Id && a.UpdatedAt == D2);
						grossSalary = shadowgrade.Total;
					}

					
				}
			}
			else
			{
				List<Salary> salaries = db.Salaries.Where(a => a.EmployeeId == this.EmployeeId && a.Date <= this.Date).ToList();
				if(salaries.Count>0)
				{
					DateTime maxDate = salaries.Max(a => a.Date);

					Salary salary = salaries.FirstOrDefault(a => a.Date == maxDate);

					grossSalary = salary.Amount;
				}
			}

			if (advTotal<=grossSalary)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
