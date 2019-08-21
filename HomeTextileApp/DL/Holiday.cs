using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Holiday
    {
        public int Id { get; set; }


        [Display(Name = "Select A Department")]
        [Required(ErrorMessage = "Please Select Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

		public String HolidayReasons { get; set; }

		[Display(Name = "From")]
        [Required(ErrorMessage = "Please Select Date")]
        public DateTime From { get; set; }

		[Display(Name = "To")]
		[Required(ErrorMessage = "Please Select Date")]
		public DateTime To { get; set; }
	}
}