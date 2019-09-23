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
	public partial class BonusCrystalReport : Form
	{
		List<ViewBonus> viewSalarySheets = new List<ViewBonus>();
		BonusCrystalPar SalaryReportParameter = new BonusCrystalPar();

		public BonusCrystalReport(BonusCrystalPar salaryReportParameter, List<ViewBonus> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}

		private void BonusCrystalReport_Load(object sender, EventArgs e)
		{
			festivalBonus1.SetDataSource(viewSalarySheets);
			festivalBonus1.SetParameterValue("Date", SalaryReportParameter.Date);
			festivalBonus1.SetParameterValue("BonusDate", SalaryReportParameter.BonusDate);
			festivalBonus1.SetParameterValue("Festival", SalaryReportParameter.Festival);

			festivalBonus1.SetParameterValue("CTB", SalaryReportParameter.CTB);
			festivalBonus1.SetParameterValue("DTB", SalaryReportParameter.DTB);
			festivalBonus1.SetParameterValue("UTB", SalaryReportParameter.UTB);
			festivalBonus1.SetParameterValue("STB", SalaryReportParameter.STB);

			festivalBonus1.SetParameterValue("CTE", SalaryReportParameter.CTE);
			festivalBonus1.SetParameterValue("DTU", SalaryReportParameter.DTE);
			festivalBonus1.SetParameterValue("UTE", SalaryReportParameter.UTE);
			festivalBonus1.SetParameterValue("STE", SalaryReportParameter.STE);


			festivalBonus1.SetParameterValue("Departmant", SalaryReportParameter.Department);
			festivalBonus1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			festivalBonus1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = festivalBonus1;
			crystalReportViewer1.Refresh();
		}
	}
}
