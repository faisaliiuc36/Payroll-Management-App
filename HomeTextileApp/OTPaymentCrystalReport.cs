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
	public partial class OTPaymentCrystalReport : Form
	{
		List<ViewOT> viewSalarySheets = new List<ViewOT>();
		SalaryReportParameter SalaryReportParameter = new SalaryReportParameter();
		public OTPaymentCrystalReport(SalaryReportParameter salaryReportParameter, List<ViewOT> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}

		private void OTPaymentCrystalReport_Load(object sender, EventArgs e)
		{
			otPaymentReport1.SetDataSource(viewSalarySheets);
			otPaymentReport1.SetParameterValue("Date", SalaryReportParameter.Date.ToString("dd/MM/yyyy"));
			otPaymentReport1.SetParameterValue("Day", SalaryReportParameter.Days);

		
			otPaymentReport1.SetParameterValue("Department", SalaryReportParameter.Department);
			otPaymentReport1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			otPaymentReport1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = otPaymentReport1;
			crystalReportViewer1.Refresh();
		}
	}
}
