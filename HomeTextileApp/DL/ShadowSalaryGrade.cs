using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	class ShadowSalaryGrade
	{
		public int Id { get; set; }

		public int RoWId { get; set; }
		public DateTime UpdatedAt { get; set; }

		public int? HTAdminId { get; set; }
		[ForeignKey("HTAdminId")]
		public virtual HTAdmins HTAdmins { get; set; }

		public int GradeId { get; set; }

		public string GradeName { get; set; }

		public string Description { get; set; }

		public float Salary { get; set; }

		public float YearlyIncrement { get; set; }

		public float HouseRent { get; set; }

		public float MedicalAllowance { get; set; }

		public float TransportAllowance { get; set; }

		public float FoodAllowance { get; set; }

		public float Total { get; set; }

		public DateTime EffectiveFrom { get; set; }

		internal void AssignFromOriginal(SalaryGrade salaryGrade)
		{
			this.RoWId = salaryGrade.Id;

			this.HTAdminId = LoginInfo.UserID;

			this.GradeId = salaryGrade.GradeId;

			this.GradeName = salaryGrade.GradeName;

			this.Description = salaryGrade.Description;

			this.Salary = salaryGrade.Salary;

			this.YearlyIncrement = salaryGrade.YearlyIncrement;

			this.HouseRent = salaryGrade.HouseRent;

			this.MedicalAllowance = salaryGrade.MedicalAllowance;

			this.TransportAllowance = salaryGrade.TransportAllowance;

			this.FoodAllowance = salaryGrade.FoodAllowance;

			this.Total = salaryGrade.Total;

			this.EffectiveFrom = salaryGrade.EffectiveFrom;
			this.UpdatedAt = salaryGrade.EffectiveFrom;
		}
	}
}
