using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Duty_Roster
    {
        public int Id { get; set; }


        [Display(Name = "Select An Employee")]
        [Required(ErrorMessage = "Please Select Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Please Select Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Shift")]
        public int ShiftId { get; set; }
        [ForeignKey("ShiftId")]
        public virtual Shift Shift { get; set; }
    }
}