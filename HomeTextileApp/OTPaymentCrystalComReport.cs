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
	public partial class OTPaymentCrystalComReport : Form
	{
		List<ViewOT> viewSalarySheets = new List<ViewOT>();
		SalaryReportParameter SalaryReportParameter = new SalaryReportParameter();

		public OTPaymentCrystalComReport(SalaryReportParameter salaryReportParameter, List<ViewOT> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}

		private void OTPaymentCrystalComReport_Load(object sender, EventArgs e)
		{
			otPaymentReprtCom1.SetDataSource(viewSalarySheets);
			otPaymentReprtCom1.SetParameterValue("Date", SalaryReportParameter.Date.ToString("dd/MM/yyyy"));
			otPaymentReprtCom1.SetParameterValue("Day", SalaryReportParameter.Days);


			otPaymentReprtCom1.SetParameterValue("Department", SalaryReportParameter.Department);
			otPaymentReprtCom1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			otPaymentReprtCom1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = otPaymentReprtCom1;
			crystalReportViewer1.Refresh();
		}
	}
}
