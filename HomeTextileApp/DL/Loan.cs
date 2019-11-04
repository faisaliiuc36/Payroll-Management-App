using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Loan
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

        public virtual List<Paytime> Paytimes { get; set; }

		public bool IsLoanHas()
		{
			var paytime = db.Paytimes.FirstOrDefault(a => a.Loan.EmployeeId == this.EmployeeId && a.Date >= DateTime.Now);
			if(paytime==null)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool IsLoanPaid(DateTime dateTime)
		{
			var paytime = db.Paytimes.FirstOrDefault(a => a.Date >= dateTime && a.LoanId==this.Id);
			if(paytime == null)
			{
				return false;
			}
			return true;

		}
    }
}