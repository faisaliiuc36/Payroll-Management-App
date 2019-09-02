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
				grossSalary = employee.WorkerDesignation.SalaryGrade.Total;
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
