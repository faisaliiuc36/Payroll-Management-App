using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class ViewSalarySheet
    {
        public int Emp_Id { get; set; }

        public string Name { get; set; }
        public DateTime JoiningDate { get; set; }
        public String Designation { get; set; }
        public String Grade { get; set; }

        public int SalaryDays { get; set; }//Loop

        public int Absent { get; set; }//Loop

        public int Leave { get; set; }//Loop
        public int CL { get; set; }//Loop
        public int SL { get; set; }//Loop
        public int ML { get; set; }//Loop
        public int EL { get; set; }//Loop

        public int LeavePay { get; set; }//Loop
        public double Basic { get; set; }
        public double BasicPay {
			get
			{
				return this.Basic - this.DAbsent;
			}
				}
        public double HouseRent { get; set; }
        public double Conv { get; set; }
        public double Medical { get; set; }
        public double Other { get; set; }
        public double AttendanceAllowance { get {

				if (this.Leave ==0 && this.Absent==0)
				{
					return 300;
				}
				else
				{
					return 0;
				}
					}
		}
        public double TotalPayable { get { return this.AttendanceAllowance + this.GrossPay; } }

        public double Gross { get; set; }
        public double GrossPay { get
			{
				return this.HouseRent + this.Medical + this.BasicPay;
			}
				}

        public double Bonus { get; set; }

        public double DAdvance { get; set; }//afterloop
        public double DCard { get; set; }//afterloop
        public double DLoan { get; set; }
        public double DAbsent { get; set; }//after loop
        public double DFood { get; set; }
        public double DBus { get; set; }
        public double DStamp { get; set; }
        public double DOther { get; set; }
        public double DTax { get; set; }
        public double TotalD { get { return this.DAdvance + this.DBus + this.DCard + this.DOther + this.DStamp; } }

        public double NetSalary { get { return TotalPayable - TotalD; } }//afterloop


    }
}