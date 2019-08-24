using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class ViewAttendanceHistory
    {
        [Display(Name = "Emp_Id")]
        public int Emp_Id { get; set; }

        [Display(Name = "Name")]
        public string EmpFullName { get; set; }


        [Display(Name = "Late")]
        public int Late { get; set; }

        [Display(Name = "D/R Not Assign")]
        public int Roster { get; set; }

        [Display(Name = "Early Leave")]
        public int EarlyLeave { get; set; }

        public int Present { get; set; }

        public int Absent { get; set; }

        public int Leave { get; set; }

        public int Manuel { get; set; }
        

        public int Holiday { get; set; }

    

        public int Invalid { get; set; }
        public int Weekend { get; set; }
        



    }
}