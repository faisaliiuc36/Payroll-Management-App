using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Leave
    {
        public int Id { get; set; }


        [Display(Name = "Select An Employee")]
        [Required(ErrorMessage = "Please Select Employee")]
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [Display(Name = "Select A LeaveType")]
        [Required(ErrorMessage = "Please Select LeaveType")]
        public int LeaveTypeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        public virtual LeaveType LeaveType { get; set; }

        [Display(Name = "From")]
        [Required(ErrorMessage = "Please Select Date")]
        public DateTime From { get; set; }

        [Display(Name = "To")]
        [Required(ErrorMessage = "Please Select Date")]
        public DateTime To { get; set; }
    }
}