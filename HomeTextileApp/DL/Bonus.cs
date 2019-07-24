using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{ 
	public class Bonus
    {
        public int Id { get; set; }

        [Display(Name = "Date")]
        [Required(ErrorMessage = "Please Select Date")]
        public DateTime Date { get; set; }

       
        [Required(ErrorMessage = "Please Input Bonus")]
        [Display(Name = "Bonus(%)")]
        public int Amount { get; set; }
    }
}