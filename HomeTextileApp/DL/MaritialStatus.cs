using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class MaritialStatus
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Maritial Status Name Must Be Selected!")]
        [Display(Name = "Maritial Status")]
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}