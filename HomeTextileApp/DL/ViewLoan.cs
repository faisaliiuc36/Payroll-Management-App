using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	class ViewLoan
	{
		public string EmployeeName { get; set; }
		public int EmployeeId { get; set; }
		public double Amount { get; set; }
		public double Paid { get; set; }
		public int PaidInstallment { get; set; }
		public double Payable { get; set; }
		public int PayableInstallment { get; set; }
	}
}
