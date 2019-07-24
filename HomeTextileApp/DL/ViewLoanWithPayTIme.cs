using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeTextileApp.DL
{
    public class ViewLoanWithPayTIme
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        public string PayTime { get; set; }
    }
}