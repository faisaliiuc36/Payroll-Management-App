using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
    public class Company
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Company Name Must Be Selected!")]
        [Display(Name = "Company Name")]
        public string Name { get; set; }

        public virtual List<Unit> Units { get; set; }
    }
}