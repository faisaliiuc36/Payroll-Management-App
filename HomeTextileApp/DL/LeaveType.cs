using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class LeaveType
    {
        public int Id { get; set; }

        [Display(Name = "Leave Type")]
        [Required(ErrorMessage = "Please Input Type")]
        public string Type { get; set; }

        [Display(Name = "Leave Description")]
        [Required(ErrorMessage = "Please Input Description")]
        public string Description { get; set; }

        [Display(Name = "Tags")]
        [Required(ErrorMessage = "Please Input Tags")]
        public string Tags { get; set; }

        [Display(Name = "Yearly Count")]
        [Required(ErrorMessage = "Please Input Yearly Count")]
        public int Count { get; set; }

        [Display(Name = "Paid?")]
        public bool Paid { get; set; }


        public virtual List<Leave> Leaves { get; set; }
        public virtual List<LeaveStore> LeaveStores { get; set; }

    }
}