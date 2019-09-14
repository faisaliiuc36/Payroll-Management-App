using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	class EmployeeDue
	{
		private DatabaseContext db = new DatabaseContext();
		public int Id { get; set; }


		
		public int EmployeeId { get; set; }
		

	
		public double Amount { get; set; }

		public double DueCurrent { get; set; }


		public bool Paid { get; set; }
		public bool Due { get; set; }

		public DateTime Date { get; set; }

		public double CurrentDue(DateTime dateTime)
		{
			List<EmployeeDue> dues = db.EmployeeDues.Where(a => a.Date<=dateTime && a.Due==true && a.EmployeeId==this.EmployeeId).ToList();
			List<EmployeeDue> Paids = db.EmployeeDues.Where(a => a.Date <= dateTime && a.Paid == true && a.EmployeeId == this.EmployeeId).ToList();
			double Due = dues.Sum(a => a.Amount);
			double Paid = Paids.Sum(a => a.Amount);
			return Due - Paid;
		}
	}
}
