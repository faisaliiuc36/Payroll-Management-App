using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class SalarySetting
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Late Time Must Be Filled!")]
        [Display(Name = "Count Late Time")]
        public int Time { get; set; }

        [Required(ErrorMessage = "Basic Must Be Filled!")]
        [Display(Name = "Basic(% of Gross)")]
        public double Basic { get; set; }

        [Required(ErrorMessage = "House Rent Must Be Filled!")]
        [Display(Name = "House Rent(% of Gross)")]
        public double HouseRent { get; set; }

        [Required(ErrorMessage = "convenience Must Be Filled!")]
        [Display(Name = "convenience(% of Gross)")]
        public double convenience { get; set; }

        [Required(ErrorMessage = "Medical Must Be Filled!")]
        [Display(Name = "Medical(% of Gross)")]
        public double Medical { get; set; }

        [Required(ErrorMessage = "Stamp Cost Must Be Filled!")]
        [Display(Name = "Stamp Cost")]
        public double Stamp { get; set; }

        [Required(ErrorMessage = "Tax Must Be Filled!")]
        [Display(Name = "Tax(% of Gross)")]
        public double Tax { get; set; }

        [Required(ErrorMessage = "Other Must Be Filled!")]
        [Display(Name = "Others(% of Gross)")]
        public double Others { get; set; }

		[Display(Name = "Effective From")]
		[Required(ErrorMessage = "Please Select Efeective date")]
		public DateTime Date { get; set; }
	}
}