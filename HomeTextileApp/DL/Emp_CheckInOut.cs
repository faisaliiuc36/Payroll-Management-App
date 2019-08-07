using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Emp_CheckInOut
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "User Id Must Be Filled!")]
        [Display(Name = "User Id")]
        public int UserId { get; set;}
        
        public DateTime  CHECKTIME { get; set; }
        public int LOGID { get; set; }
        public int? MACHINEID { get; set; }

		public bool IsManual { get; set; } 
		public bool IsAbsent { get; set; } 
		

		public String UpdatedBy { get; set; }

    }
}