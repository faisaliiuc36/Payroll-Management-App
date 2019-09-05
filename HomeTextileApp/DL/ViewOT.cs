using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	class ViewOT
	{
		public int Emp_Id { get; set; }
		public string Grade { get; set; }
		public string Name { get; set; }
		public DateTime InTime { get; set; }
		public DateTime OutTime { get; set; }

		public int TotalHour { get; set; }
		public double Amount
		{
			get
			{
				double PerMonthOT = (this.Gross - 1850) / 1.5;
				double PerDayOT  =PerMonthOT / 26;
				double PerHourOTSingle = PerDayOT / 8;
				double PerHourOT = Math.Round(PerHourOTSingle * 2);
				return TotalHour * PerHourOT;
			}

		}
		public double Gross { get; set; }

		public int TotalHourC { get; set; }
		public double AmountC {
			get
			{
				double PerMonthOT = (this.Gross - 1850) / 1.5;
				double PerDayOT = PerMonthOT / 26;
				double PerHourOTSingle = PerDayOT / 8;
				double PerHourOT = Math.Round(PerHourOTSingle * 2);
				return TotalHourC * PerHourOT;
			}

		}
	}
}
