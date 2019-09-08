using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	class WorkerDesignationHistory
	{
		public int Id { get; set; }

		
		[Display(Name = "Select An Employee")]
		[Required(ErrorMessage = "Please Select Employee")]
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		public virtual Employee Employee { get; set; }

		[Display(Name = "Worker Designation")]
		public int? WorkerDesignationId { get; set; }
		[ForeignKey("WorkerDesignationId")]
		public virtual WorkerDesignation WorkerDesignation { get; set; }

		[Display(Name = "Technical Allowance(Worker)")]
		public double TechnicalAllowance { get; set; }

		public DateTime From { get; set; }
	}
}
