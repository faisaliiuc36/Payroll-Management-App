using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	public class WorkerDesignation
	{
		public int Id { get; set; }


		[Display(Name = "Salary Grade")]
		public int? SalaryGradeId { get; set; }
		[ForeignKey("SalaryGradeId")]
		public virtual SalaryGrade SalaryGrade { get; set; }


		public string Name { get; set; }

		public DateTime EffectiveDate { get; set; }
	}
}
