using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	public class AdvanceDeduction
	{
		public string FacCode { get; set; }
		public string FullName { get; set; }
		public double Gross { get; set; }
		public double Advance { get; set; }
		public double Payable { get
			{
				return Gross - Advance;
			}
				}
	}
}
