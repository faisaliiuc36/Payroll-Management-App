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
	public partial class BonusCrystalReportCom : Form
	{

		List<ViewBonus> viewSalarySheets = new List<ViewBonus>();
		BonusCrystalPar SalaryReportParameter = new BonusCrystalPar();

		public BonusCrystalReportCom(BonusCrystalPar salaryReportParameter, List<ViewBonus> vS)
		{
			InitializeComponent();
			viewSalarySheets = vS;
			SalaryReportParameter = salaryReportParameter;
		}

		private void BonusCrystalReportCom_Load(object sender, EventArgs e)
		{
			festivalBonusCom1.SetDataSource(viewSalarySheets);
			festivalBonusCom1.SetParameterValue("Date", SalaryReportParameter.Date);
			festivalBonusCom1.SetParameterValue("BonusDate", SalaryReportParameter.BonusDate);
			festivalBonusCom1.SetParameterValue("Festival", SalaryReportParameter.Festival);

			festivalBonusCom1.SetParameterValue("CTB", SalaryReportParameter.CTB);
			festivalBonusCom1.SetParameterValue("DTB", SalaryReportParameter.DTB);
			festivalBonusCom1.SetParameterValue("UTB", SalaryReportParameter.UTB);
			festivalBonusCom1.SetParameterValue("STB", SalaryReportParameter.STB);

			festivalBonusCom1.SetParameterValue("CTE", SalaryReportParameter.CTE);
			festivalBonusCom1.SetParameterValue("DTU", SalaryReportParameter.DTE);
			festivalBonusCom1.SetParameterValue("UTE", SalaryReportParameter.UTE);
			festivalBonusCom1.SetParameterValue("STE", SalaryReportParameter.STE);


			festivalBonusCom1.SetParameterValue("Departmant", SalaryReportParameter.Department);
			festivalBonusCom1.SetParameterValue("Unit", SalaryReportParameter.Unit);
			festivalBonusCom1.SetParameterValue("Section", SalaryReportParameter.Section);
			crystalReportViewer1.ReportSource = festivalBonusCom1;
			crystalReportViewer1.Refresh();
		}
	}
}
