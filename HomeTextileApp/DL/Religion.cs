using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Religion
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Religion Name Must Be Selected!")]
        [Display(Name = "Religion Name")]
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}