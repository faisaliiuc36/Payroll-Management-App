using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	public class InActiveHistory
	{
		public int Id { get; set; }

		[Display(Name = "Select An Employee")]
		[Required(ErrorMessage = "Please Select Employee")]
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		public virtual Employee Employee { get; set; }

		public DateTime From { get; set; }

		public DateTime? To { get; set; }


		public DateTime CalculateTo
		{
			get
			{
				if (this.To == null)
				{
					return DateTime.Now;
				}
				else
					return Convert.ToDateTime(this.To);
			}
		}
	}
}
