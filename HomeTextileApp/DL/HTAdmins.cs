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

		[Display(Name = "Attendance(Import,Salary Generate)")]
		public bool Attendance { get; set; }

		[Display(Name = "Search Attendance")]
		public bool SearchAttendance { get; set; }

		[Display(Name = "Manual Attendance")]
		public bool Manual { get; set; }

		[Display(Name = "Employee Settings")]
		public bool Setting { get; set; }

		[Display(Name = "Leave")]
		public bool Leave { get; set; }

		[Display(Name = "Import Employee")]
		public bool Import { get; set; }

		[Display(Name = "Employee")]
		public bool Employee { get; set; }

		[Display(Name = "Loan")]
		public bool Loan { get; set; }

		[Display(Name = "Holiday")]
		public bool Holiday { get; set; }

		[Display(Name = "Duty Roster")]
		public bool DutyRoster { get; set; }

		[Display(Name = "ShiftSetting")]
		public bool Shift { get; set; }

		[Display(Name = "SalarySetting")]
		public bool Salary { get; set; }

		[Display(Name = "Bonus")]
		public bool Bonus { get; set; }
	}
}
