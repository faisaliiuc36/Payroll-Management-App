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

        public int SalaryDays { get; set; }//Loop

        public int Absent { get; set; }//Loop

        public int Leave { get; set; }//Loop

        public double Basic { get; set; }
        public double HouseRent { get; set; }
        public double Conv { get; set; }
        public double Medical { get; set; }
        public double Other { get; set; }

        public double Gross { get; set; }

        public double Bonus { get; set; }

        public double DAdvance { get; set; }//afterloop
        public double DLoan { get; set; }
        public double DAbsent { get; set; }//after loop
        public double DFood { get; set; }
        public double DStamp { get; set; }
        public double DTax { get; set; }

        public double NetSalary { get; set; }//afterloop


    }
}