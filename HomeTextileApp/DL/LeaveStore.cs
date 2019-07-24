using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class LeaveStore
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

        [Display(Name = "Yearly Count")]
        [Required(ErrorMessage = "Please Input Yearly Count")]
        public int Count { get; set; }

        public int Spent { get; set; }

        public int LeaveId { get; set; }

        public bool IsManual { get; set; }

    }
}