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
	public partial class OTDateWiseCrystalReport : Form
	{
		List<ViewOT> viewSalarySheets = new List<ViewOT>();
		SalaryReportParameter SalaryReportParameter = new SalaryReportParameter();

		public OTDateWiseCrystalReport(SalaryReportParameter salaryReportParameter, List<ViewOT> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}


		private void OTDateWiseCrystalReport_Load(object sender, EventArgs e)
		{
		    oT_Daily_Report1.SetDataSource(viewSalarySheets);
			oT_Daily_Report1.SetParameterValue("Date", SalaryReportParameter.Date.ToString("dd/MM/yyyy"));
			
			oT_Daily_Report1.SetParameterValue("Department", SalaryReportParameter.Department);
			oT_Daily_Report1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			oT_Daily_Report1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = oT_Daily_Report1;
			crystalReportViewer1.Refresh();
		}
	}
}
