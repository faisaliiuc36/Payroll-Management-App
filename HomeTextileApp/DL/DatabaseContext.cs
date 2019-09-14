using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTextileApp.DL
{
	class DatabaseContext : DbContext
	{
		public DatabaseContext() : base(@"Data Source=DESKTOP-UPLFCN1\SQLEXPRESS;Initial Catalog=HomeTextileDB;Integrated Security=True")
		{

		}
		public virtual DbSet<HTAdmins> HTAdmins { get; set; }
		public virtual DbSet<Bonus> Bonus { get; set; }
		public virtual DbSet<ShadowEmployee> ShadowEmployees { get; set; }
		public virtual DbSet<ShadowSalaryGrade> ShadowSalaryGrades { get; set; }


		public virtual DbSet<Emp_CheckInOut> Emp_CheckInOuts { get; set; }
		public virtual DbSet<EmployeeDue> EmployeeDues { get; set; }
		public virtual DbSet<Employee> Employees { get; set; }
		public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }
		public virtual DbSet<Company> Companies { get; set; }
		public virtual DbSet<Unit> Units { get; set; }
		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<Section> Sections { get; set; }
		public virtual DbSet<BloodGroup> BloodGroups { get; set; }
		public virtual DbSet<Religion> Religions { get; set; }
		public virtual DbSet<MaritialStatus> MaritialStatus { get; set; }
		public virtual DbSet<Designation> Designation { get; set; }
		public virtual DbSet<Gender> Gender { get; set; }
		public virtual DbSet<Shift> shifts { get; set; }
		public virtual DbSet<Duty_Roster> Duty_Rosters { get; set; }
		public virtual DbSet<Paytime> Paytimes { get; set; }
		public virtual DbSet<Loan> Loans { get; set; }
		public virtual DbSet<Leave> Leaves { get; set; }
		public virtual DbSet<Holiday> Holidays { get; set; }
		public virtual DbSet<SalarySetting> SalarySettings { get; set; }
		public virtual DbSet<LeaveType> LeaveTypes { get; set; }
		public virtual DbSet<LeaveStore> LeaveStores { get; set; }
	
		

		public virtual DbSet<Salary> Salaries { get; set; }
		public virtual DbSet<InActiveHistory> InActiveHistories  { get; set; }
		public virtual DbSet<WorkerDesignation> WorkerDesignations { get; set; }
		public virtual DbSet<SalaryGrade> SalaryGrades { get; set; }
		public virtual DbSet<Advance> Advances { get; set; }
		public virtual DbSet<WorkerDesignationHistory> WorkerDesignationHistories { get; set; }
	}
}
