using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class ViewIndividualAttendance
    {
        

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public string Shift { get; set; }

        [Display(Name = "In Time")]
        public TimeSpan From { get; set; }

        [Display(Name = "Out Time")]
        public TimeSpan To { get; set; }

        public string Status { get; set; }
    }
}