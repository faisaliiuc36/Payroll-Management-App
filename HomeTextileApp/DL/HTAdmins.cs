using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	public class HTAdmins
	{
		public int Id { get; set; }


		[Display(Name = "User Name")]
		public string UserName { get; set; }


		[Display(Name = "Password")]
		public string Password { get; set; }

		[Display(Name = "Admin")]
		public bool Admin { get; set; }

		
		public bool Attendance { get; set; }

		public bool Employee { get; set; }
		public bool Settings { get; set; }
		public bool LeaveAndHoliday { get; set; }
		public bool Report { get; set; }
		
	}
}
