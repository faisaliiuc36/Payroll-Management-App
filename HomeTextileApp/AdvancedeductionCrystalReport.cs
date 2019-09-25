using HomeTextileApp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class AdvancedeductionCrystalReport : Form
	{
		List<DL.AdvanceDeduction> viewSalarySheets = new List<DL.AdvanceDeduction>();
		SalaryReportParameter SalaryReportParameter = new SalaryReportParameter();
		public AdvancedeductionCrystalReport(SalaryReportParameter salaryReportParameter, List<DL.AdvanceDeduction> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}


		private void AdvancedeductionCrystalReport_Load(object sender, EventArgs e)
		{
			advanceDeductionReport1.SetDataSource(viewSalarySheets);
			advanceDeductionReport1.SetParameterValue("Date", SalaryReportParameter.Date);


			advanceDeductionReport1.SetParameterValue("Dept", SalaryReportParameter.Department);
			advanceDeductionReport1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			advanceDeductionReport1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = advanceDeductionReport1;
			crystalReportViewer1.Refresh();
		}
	}
}
