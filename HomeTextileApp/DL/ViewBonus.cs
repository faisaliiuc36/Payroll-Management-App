using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	public class ViewBonus
	{
		public int Emp_Id { get; set; }
		public string Grade { get; set; }
		public string Name { get; set; }
		public double Days { get; set; }


		public double Gross { get; set; }
		public double Year { get; set; }

		public double Basic { get; set; }
		public double BonusC
		{
			get
			{
				if (this.Year < 1)
				{
					return 0;
				}
				else
				{
					return this.Basic;
				}
			}
		}

		public double CompanyPercentage { get; set; }


		public double Bonus
		{
			get
			{
				if(this.Year<1)
				{
					return 0;
				}
				else if (this.Days >= 213)
				{
					return this.Gross * (100 / this.CompanyPercentage);
				}
				else if (this.Days >= 115)
				{
					return this.Gross * (200 / this.CompanyPercentage);
				}
				else
				{
					return 0;
				}
			}
		}


	}
}
