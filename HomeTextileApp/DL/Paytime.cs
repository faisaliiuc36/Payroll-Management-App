using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Paytime
    {
        public int Id { get; set; }


        [Display(Name = "Select A Loan")]
        [Required(ErrorMessage = "Please Select LoanId")]
        public int LoanId { get; set; }
        [ForeignKey("LoanId")]
        public virtual Loan Loan { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Please Select Date")]
        public DateTime Date { get; set; }

		public double Amount { get; set; }

        [Display(Name = "Is Paid?")]
        public bool Paid { get; set; }


    }
}