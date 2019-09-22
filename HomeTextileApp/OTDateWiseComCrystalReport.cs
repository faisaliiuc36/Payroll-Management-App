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
	public partial class OTDateWiseComCrystalReport : Form
	{
		List<ViewOT> viewSalarySheets = new List<ViewOT>();
		SalaryReportParameter SalaryReportParameter = new SalaryReportParameter();

		public OTDateWiseComCrystalReport(SalaryReportParameter salaryReportParameter, List<ViewOT> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}

		private void OTDateWiseComCrystalReport_Load(object sender, EventArgs e)
		{
			oT_Daily_Rep_Com1.SetDataSource(viewSalarySheets);
			oT_Daily_Rep_Com1.SetParameterValue("Date", SalaryReportParameter.Date.ToString("dd/MM/yyyy"));

			oT_Daily_Rep_Com1.SetParameterValue("Department", SalaryReportParameter.Department);
			oT_Daily_Rep_Com1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			oT_Daily_Rep_Com1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = oT_Daily_Rep_Com1;
			crystalReportViewer1.Refresh();
		}
	}
}
