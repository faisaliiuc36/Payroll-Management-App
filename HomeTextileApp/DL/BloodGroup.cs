using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
    public class BloodGroup
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "BloodGroup Name Must Be Selected!")]
        [Display(Name = "BloodGroup Name")]
        public string Name { get; set; }

        public virtual List<Employee> Employees { get; set; }
    }
}