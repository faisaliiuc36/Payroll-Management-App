using HomeTextileApp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	
	public partial class Loan : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public Loan()
		{
			InitializeComponent();
		}

		private void loansBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.loansBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void Loan_Load(object sender, EventArgs e)
		{
			this.loansTableAdapter.Fill(this.homeTextileDBDataSet2.Loans);
		
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Paytimes' table. You can move, or remove it, as needed.
			this.paytimesTableAdapter.Fill(this.homeTextileDBDataSet2.Paytimes);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Designations' table. You can move, or remove it, as needed.
			this.designationsTableAdapter.Fill(this.homeTextileDBDataSet2.Designations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);

			//this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Loans' table. You can move, or remove it, as needed.
			LoadLoan();
		}

		private void LoadLoan()
		{
			
			List<DL.Loan> loans = db.Loans.ToList();
			loansDataGridView.DataSource = loans;
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int EmpId = Convert.ToInt32(textBox1.Text);
				loansDataGridView.DataSource = db.Loans.Where(a => a.Employee.Emp_Id == EmpId).ToList();

			}
			catch(Exception Ex)
			{

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}
			var loan = loansDataGridView.CurrentRow;
			DL.Loan loans = (DL.Loan)loan.DataBoundItem;

			
			// Delete  Loan
			DL.Loan loanforDelete = db.Loans.Find(loans.Id);
			db.Loans.Remove(loanforDelete);
			db.SaveChanges();
			Reload();
			//Message
			MessageBox.Show("Deleted Sucessfully!");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.paytimesBindingSource.RemoveCurrent();

			this.Validate();
			this.paytimesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void SavePaytime()
		{
			try
			{
				var pT = paytimesDataGridView.DataSource;

				List<Paytime> paytimes = (List<Paytime>)pT;

				foreach (Paytime P in paytimes)
				{
					db.Entry(P).State = EntityState.Modified;
					db.SaveChanges();
				}

				Reload();
			}
			catch(Exception Ex)
			{

			}
		}

		private void Reload()
		{
			this.paytimesTableAdapter.Fill(this.homeTextileDBDataSet2.Paytimes);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Designations' table. You can move, or remove it, as needed.
			this.designationsTableAdapter.Fill(this.homeTextileDBDataSet2.Designations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);

			//this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Loans' table. You can move, or remove it, as needed.
			LoadLoan();
		}

		private void SaveLoan()
		{
			try
			{

				var loan = loansDataGridView.DataSource;

				List<DL.Loan> loans = (List<DL.Loan>)loan;

				foreach (DL.Loan L in loans)
				{
					db.Entry(L).State = EntityState.Modified;
					db.SaveChanges();
				}
				Reload();
			}
			catch(Exception Ex)
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
			try
			{
				//Loan Data Bind
				int empId = Convert.ToInt32(empIdTextBox.Text);
				var employee = db.Employees.FirstOrDefault(a => a.Emp_Id == empId);
				DL.Loan loan = new DL.Loan();

				loan.EmployeeId = employee.Id;
				loan.Installment = Convert.ToInt32(installmentTextBox.Text);
				loan.Date = Convert.ToDateTime(dateDateTimePicker.Text);
				loan.Amount = Convert.ToDouble(amountTextBox.Text);
				

				// Check Condition To Provide Loan
				
				if(loan.IsLoanHas())
				{
					MessageBox.Show("This Employee Has Lone!");
					return;
				}

				// Save Loan

				db.Loans.Add(loan);
				db.SaveChanges();

				// Save Paytime
				DateTime date = loan.Date;
				for (int i=1;i<=loan.Installment;i++)
				{
					Paytime paytime = new Paytime();
					paytime.LoanId = loan.Id;
					date = date.AddMonths(1);
					paytime.Date = date;
					paytime.Amount = loan.Amount / loan.Installment;

					db.Paytimes.Add(paytime);
					db.SaveChanges();
				}
				//Save Message
				MessageBox.Show("Save Sucessfully!");
				Reload();
				
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.paytimesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
			Reload();
		}

		private void loansDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var loan = loansDataGridView.CurrentRow;
				DL.Loan loans = (DL.Loan)loan.DataBoundItem;
				//Binding Paytime
				this.paytimesBindingSource.Filter="LoanId="+loans.Id;
				Employee employee = db.Employees.Find(loans.EmployeeId);
				empFullNameTextBox.Text = employee.EmpFullName;
				empIdTextBox.Text = employee.Emp_Id.ToString();
				//badgeNumberTextBox.Text = employee.BadgeNumber;
				designationIdComboBox.SelectedText = employee.Designation.Name;
				designationIdComboBox.SelectedValue = employee.DesignationId;


				//assign value to form
				idTextBox.Text = loans.Id.ToString();
				amountTextBox.Text = loans.Amount.ToString();
				installmentTextBox.Text = loans.Installment.ToString();
				dateDateTimePicker.Value = loans.Date;
			}
			catch (Exception Ex)
			{

			}
		}

		private void loansDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{

		}

	

		private void empIdTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int id=Convert.ToInt32(empIdTextBox.Text);
				var employee = db.Employees.FirstOrDefault(a=>a.Emp_Id==id);
				empFullNameTextBox.Text = employee.EmpFullName;
				designationIdComboBox.SelectedText = employee.Designation.Name;
				designationIdComboBox.SelectedValue = employee.DesignationId;
			
			}
			catch(Exception Ex)
			{
				empFullNameTextBox.Text ="";
				designationIdComboBox.SelectedText = "";
				designationIdComboBox.SelectedValue =0;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			
			try
			{
				var loan = loansDataGridView.CurrentRow;
				DL.Loan loans = (DL.Loan)loan.DataBoundItem;

				//DialogBox
				var emp = db.Employees.Find(loans.EmployeeId);
				DialogResult res = MessageBox.Show("Are you sure you want to update the loan of: "+emp.EmpFullName, "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

				if (res == DialogResult.Cancel)
				{
					return;
				}
				//Update Loan
				DL.Loan loanU = db.Loans.Find(loans.Id);
				loanU.Installment = Convert.ToInt32(installmentTextBox.Text);
				loanU.Amount = Convert.ToDouble(amountTextBox.Text);
				loanU.Date = Convert.ToDateTime(dateDateTimePicker.Text);

				int id = Convert.ToInt32(empIdTextBox.Text);
				var employee = db.Employees.FirstOrDefault(a => a.Emp_Id == id);

				loanU.EmployeeId = employee.Id;

				db.Entry(loanU).State = EntityState.Modified;
				db.SaveChanges();
				
				//Update Paytime

				//Delete
				List<Paytime> paytimes = db.Paytimes.Where(a => a.LoanId == loanU.Id).ToList();
				db.Paytimes.RemoveRange(paytimes);
				db.SaveChanges();

				//Save
				DateTime date = loanU.Date;
				for (int i = 1; i <= loanU.Installment; i++)
				{
					Paytime paytime = new Paytime();
					paytime.LoanId = loanU.Id;
					date = date.AddMonths(1);
					paytime.Date = date;
					paytime.Amount = loanU.Amount / loanU.Installment;

					db.Paytimes.Add(paytime);
					db.SaveChanges();
				}

				Reload();
				MessageBox.Show("Updated Sucessfully!");
			}
			catch (Exception Ex)
			{

			}
		
		}

		private void loansDataGridView_CellContentClick(object sender, EventArgs e)
		{
			try
			{
				var loan = loansDataGridView.CurrentRow;
				DL.Loan loans = (DL.Loan)loan.DataBoundItem;
				//Binding Paytime
				this.paytimesBindingSource.Filter = "LoanId=" + loans.Id;
				Employee employee = db.Employees.Find(loans.EmployeeId);
				empFullNameTextBox.Text = employee.EmpFullName;
				empIdTextBox.Text = employee.Emp_Id.ToString();
				//badgeNumberTextBox.Text = employee.BadgeNumber;
				designationIdComboBox.SelectedText = employee.Designation.Name;
				designationIdComboBox.SelectedValue = employee.DesignationId;

				//assign value to form
				idTextBox.Text = loans.Id.ToString();
				amountTextBox.Text = loans.Amount.ToString();
				installmentTextBox.Text = loans.Installment.ToString();
				dateDateTimePicker.Value = loans.Date;
			}
			catch (Exception Ex)
			{

			}
		}
	}
}
