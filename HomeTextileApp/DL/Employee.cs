using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	public class Employee
	{
		private DatabaseContext db = new DatabaseContext();
		[Key]
		public int Id { get; set; }



		[Display(Name = "Employee Id")]
		public int Emp_Id { get; set; }


		


		[Display(Name = "Employee Type ")]
		public int? EmployeeTypeId { get; set; }
		[ForeignKey("EmployeeTypeId")]
		public virtual EmployeeType EmployeeType { get; set; }



		




		[Display(Name = "Section")]
		public int? SectionId { get; set; }
		[ForeignKey("SectionId")]
		public virtual Section Section { get; set; }



		[Display(Name = "Employee Full Name")]
		public string EmpFullName { get; set; }

		[Display(Name = "Badge Number")]
		public string BadgeNumber { get; set; }


		[Display(Name = "Date of Birth")]
		public DateTime? DateOfBirth { get; set; }


		
		public string NationalId { get; set; }

		[Display(Name = "Blood Group")]
		public int? BloodGroupId { get; set; }
		[ForeignKey("BloodGroupId")]
		public virtual BloodGroup BloodGroup { get; set; }

		[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		[Display(Name = "Hire Date")]
		public DateTime? HireDate { get; set; }





		[Display(Name = "Religion")]
		public int? ReligionId { get; set; }
		[ForeignKey("ReligionId")]
		public virtual Religion Religion { get; set; }


		[Display(Name = "Maritial Status")]
		public int? MaritialStatusId { get; set; }
		[ForeignKey("MaritialStatusId")]
		public virtual MaritialStatus MaritialStatus { get; set; }


		[Display(Name = "IsWorker")]
		public bool IsWorker { get; set; }



		[Display(Name = "Address")]
		public string Address { get; set; }


		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }




		[Display(Name = "Email")]
		public string Email { get; set; }


		[Display(Name = "Active Status")]
		public bool ActiveStatus { get; set; }

		[Display(Name = "Is Edited?")]
		public bool IsEdited {
			get
			{
				if(this.EmpFullName=="" || this.GenderId==null || this.SectionId==null || this.PhoneNumber=="" || this.MaritialStatusId==null || this.DateOfBirth ==null || this.BloodGroupId==null || this.Address=="")
				{
					return false;
				}
				else
				{
					return true;
				}
			}
			
				
							}



		[Display(Name = "Designation")]
		public int? DesignationId { get; set; }
		[ForeignKey("DesignationId")]
		public virtual Designation Designation { get; set; }


		[Display(Name = "Worker Designation")]
		public int? WorkerDesignationId { get; set; }
		[ForeignKey("WorkerDesignationId")]
		public virtual WorkerDesignation WorkerDesignation { get; set; }

		[Display(Name = "Technical Allowance(Worker)")]
		public double TechnicalAllowance { get; set; }

		[Display(Name = "First Name")]
		public string FirstName { get; set; }


		[Display(Name = "Last Name")]
		public string LastName { get; set; }


		[Display(Name = "Middle Name")]
		public string MiddleName { get; set; }


		[Display(Name = "Emergency Contact")]
		public string EmergencyContact { get; set; }



		[Display(Name = "Gender")]
		public int? GenderId { get; set; }
		[ForeignKey("GenderId")]
		public virtual Gender Gender { get; set; }

		[Display(Name = "Is Trainee?")]
		public bool IsTrainee { get; set; }


		[Display(Name = "Permanent From")]
		public DateTime? Permanent { get; set; }

		[Display(Name = "End Date")]
		public DateTime? EndDate { get; set; }


		[Display(Name = "Insert Date")]
		public DateTime? InsertDate { get; set; }

		public string ImagePath { get; set; }
		public string ImageFile { get; set; }

		public virtual List<Duty_Roster> Duty_Rosters { get; set; }
		public virtual List<Holiday> Holidays { get; set; }
		public virtual List<Leave> Leaves { get; set; }
		public virtual List<Loan> Loans { get; set; }
		
		public virtual List<InActiveHistory> InActiveHistories { get; set; }

		public string NameWithId
		{
			get
			{
				return String.Format("{0}-{1}", EmpFullName, Emp_Id);
			}
		}

		public string Password { get; set; }
		

		public bool IsActive(DateTime d)
		{
			
				var ActiveHistory = db.InActiveHistories.FirstOrDefault(a => a.EmployeeId == this.Id && a.From >= d && a.To <= d);
				if (ActiveHistory == null)
				{
					return true;
				}
				else
					return false;
					
			
			
		}
	}
}
