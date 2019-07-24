using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Salary
    {
        public int Id { get; set; }


        [Display(Name = "Select An Employee")]
        [Required(ErrorMessage = "Please Select Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Display(Name = "Gross Salary")]
        [Required(ErrorMessage = "Please Select Gross Salary")]
        public double Amount { get; set; }

        [Display(Name = "Technical Allowance")]
        [Required(ErrorMessage = "Please Select Extra Salary")]
        public double TechnicalAllowance { get; set; }

		[Display(Name = "Effective From")]
		[Required(ErrorMessage = "Please Select Efeective date")]
		public DateTime Date { get; set; }
	}
}