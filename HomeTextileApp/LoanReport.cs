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
	public partial class LoanReport : Form
	{
		DatabaseContext db = new DatabaseContext();
		public LoanReport()
		{
			InitializeComponent();
		}

		private void LoanReport_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet2.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			int id = Convert.ToInt32(comboBox4.SelectedValue);
			List<DL.Loan> loans = db.Loans.Where(a => a.Employee.SectionId == id).ToList();
			List<DL.Loan> currentLone = loans.Where(a=>a.IsLoanPaid(dateTime)).ToList();

			List<ViewLoan> viewLoans = GetLoanList(currentLone,dateTime);

			viewLoanDataGridView.DataSource = null;
			viewLoanDataGridView.DataSource = viewLoans;


			DL.Section section = db.Sections.Find(id);
			label5.Text = "Unit:" + section.Department.Unit.Name + ", Department:" + section.Department.Name + ", Section:" + section.Name;
		}

		private List<ViewLoan> GetLoanList(List<DL.Loan> currentLone, DateTime dateTime)
		{
			List<ViewLoan> viewLoans = new List<ViewLoan>();

			foreach (DL.Loan loan in currentLone)
			{
				List<Paytime> paytimesPaid = db.Paytimes.Where(a => a.LoanId == loan.Id && a.Date < dateTime).ToList();
				List<Paytime> paytimesPayable = db.Paytimes.Where(a => a.LoanId == loan.Id && a.Date >= dateTime).ToList();

				ViewLoan viewLoan = new ViewLoan();
				viewLoan.EmployeeId = loan.Employee.Emp_Id;
				viewLoan.EmployeeName = loan.Employee.EmpFullName;
				viewLoan.Amount = loan.Amount;

				viewLoan.Paid = paytimesPaid.Sum(a => a.Amount);
				viewLoan.PaidInstallment = paytimesPaid.Count;

				viewLoan.Payable = paytimesPayable.Sum(a => a.Amount);
				viewLoan.PayableInstallment = paytimesPayable.Count;


				viewLoans.Add(viewLoan);
			}
			//Total
			ViewLoan viewLoanT = new ViewLoan();
			
			viewLoanT.EmployeeName = "Total";
			viewLoanT.Amount =viewLoans.Sum(a=>a.Amount);

			viewLoanT.Paid = viewLoans.Sum(a => a.Paid);
			viewLoanT.PaidInstallment = viewLoans.Sum(a => a.PaidInstallment);

			viewLoanT.Payable = viewLoans.Sum(a => a.Payable);
			viewLoanT.PayableInstallment = viewLoans.Sum(a => a.PayableInstallment);


			viewLoans.Add(viewLoanT);




			return viewLoans;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DateTime dateTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
			int id = Convert.ToInt32(comboBox3.SelectedValue);
			List<DL.Loan> loans = db.Loans.Where(a => a.Employee.Section.DepartmentId == id).ToList();
			List<DL.Loan> currentLone = loans.Where(a => a.IsLoanPaid(dateTime)).ToList();

			List<ViewLoan> viewLoans = GetLoanList(currentLone, dateTime);

			viewLoanDataGridView.DataSource = null;
			viewLoanDataGridView.DataSource = viewLoans;

			DL.Department section = db.Departments.Find(id);
			label5.Text = "Unit:" + section.Unit.Name + ", Department:" + section.Name ;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			DGVPrinter printer = new DGVPrinter();

			printer.Title = "Saad Musa-Home Textile";
			printer.SubTitle = "Loan Report" + Environment.NewLine + "Date-" + DateTime.Now.ToString("dd/MM/yyyy") + Environment.NewLine + label5.Text.ToString() + Environment.NewLine + " ";
			printer.SubTitleFormatFlags = StringFormatFlags.LineLimit |
										  StringFormatFlags.NoClip;

			printer.PageNumbers = true;

			printer.PageNumberInHeader = false;
			printer.PrintMargins.Left = 10;
			printer.PrintMargins.Right = 10;
			printer.PorportionalColumns = true;

			printer.HeaderCellAlignment = StringAlignment.Near;

			printer.Footer = "Saad Musa-IT Department";

			printer.FooterSpacing = 15;



			printer.PrintDataGridView(viewLoanDataGridView);
		}
	}
}
