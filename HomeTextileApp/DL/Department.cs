using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Unit Id  Must Be Selected!")]
        [Display(Name = "Unit Id")]
        public int UnitId { get; set; }
        [ForeignKey("UnitId")]
        public virtual Unit Unit { get; set; }

        [Required(ErrorMessage = "Department Name Must Be Selected!")]
        [Display(Name = "Department Name")]
        public string Name { get; set; }

        public virtual List<Section> Section { get; set; }
        public virtual List<Holiday> Holidays { get; set; }
    }
}