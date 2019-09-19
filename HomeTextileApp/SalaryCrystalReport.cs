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
	public partial class SalaryCrystalReport : Form
	{
		List<ViewSalarySheet> viewSalarySheets = new List<ViewSalarySheet>();
		SalaryReportParameter SalaryReportParameter = new SalaryReportParameter();

		public SalaryCrystalReport(SalaryReportParameter salaryReportParameter, List<ViewSalarySheet> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}

		private void crystalReportViewer1_Load(object sender, EventArgs e)
		{

		}

		private void SalaryCrystalReport_Load(object sender, EventArgs e)
		{
			salaryReport1.SetDataSource(viewSalarySheets);
			salaryReport1.SetParameterValue("Date", SalaryReportParameter.Date.ToString("dd/MM/yyyy"));
			salaryReport1.SetParameterValue("Days", SalaryReportParameter.Days);
			salaryReport1.SetParameterValue("Weekend", SalaryReportParameter.Weekend);
			salaryReport1.SetParameterValue("Holiday", SalaryReportParameter.Holiday);
			salaryReport1.SetParameterValue("Dept", SalaryReportParameter.Department);
			salaryReport1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			salaryReport1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = salaryReport1;
			crystalReportViewer1.Refresh();
		}
	}
}
