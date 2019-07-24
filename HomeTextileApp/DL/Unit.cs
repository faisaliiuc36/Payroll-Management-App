using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class Unit
    {
        public int Id { get; set; }


		[Display(Name = "Company ")]
		public int? CompanyId { get; set; }
		[ForeignKey("CompanyId")]
		public virtual Company Company { get; set; }

		[Required(ErrorMessage = "Unit Name Must Be Selected!")]
        [Display(Name = "Unit Name")]
        public string Name { get; set; }

        public virtual List<Department> Departments { get; set; }
    }
}