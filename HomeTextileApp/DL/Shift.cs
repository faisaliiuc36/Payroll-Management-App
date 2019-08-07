using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
	public class Shift
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Please enter Name")]
		public string Name { get; set; }

		[Display(Name = "Start From")]
		[Required(ErrorMessage = "Please Select Time")]
		public TimeSpan From { get; set; }
		[Display(Name = "Finished At")]
		[Required(ErrorMessage = "Please Select Time")]
		public TimeSpan To { get; set; }


		public bool IsGeneral { get; set; }

		public bool IsDayToNight { get; set; }

		public DateTime EffectiveDate { get; set; }


		public bool InActive {get;set;}

        public virtual List<Duty_Roster> Duty_Rosters { get; set; }
    }
}