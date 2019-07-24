using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Section
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department Id  Must Be Selected!")]
        [Display(Name = "Department Id")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }


        [Required(ErrorMessage = "Section Name Must Be Selected!")]
        [Display(Name = "Section Name")]
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}