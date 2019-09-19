using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	public class SalaryReportParameter
	{
		public DateTime Date { get; set; }
		public int Days { get; set; }
		public int Weekend { get; set; }
		public int Holiday { get; set; }
		public string Unit { get; set; }
		public string Department { get; set; }
		public string Section { get; set; }
	}
}
