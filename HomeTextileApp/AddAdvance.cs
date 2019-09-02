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
	public partial class AddAdvance : Form
	{
		private DatabaseContext db = new DatabaseContext();
		private DatabaseContext db2 = new DatabaseContext();
		public AddAdvance()
		{
			InitializeComponent();
		}

		private void advancesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			

		}

		private void AddAdvance_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			
			//// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			//this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			//// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Advances' table. You can move, or remove it, as needed.
			//this.advancesTableAdapter.Fill(this.homeTextileDBDataSet2.Advances);

			//this.advanceBindingSource.DataSource = db.Advances.ToList();
			this.advanceDataGridView.DataSource = db.Advances.ToList();


			this.employeeBindingSource.DataSource = db.Employees.ToList();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int empId = Convert.ToInt32(textBox1.Text);
				var emp = db.Employees.FirstOrDefault(a => a.Emp_Id == empId);
				advanceDataGridView.DataSource = db.Advances.Where(a => a.EmployeeId== emp.Id).ToList();

			}
			catch (Exception Ex)
			{
				
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				DateTime date = dateTimePicker1.Value;
				DateTime date2 = new DateTime(date.Year, date.Month, 1);
				String.Format("{0:yyyy-MM-dd} 00:00:00", date2);
				advanceDataGridView.DataSource = db.Advances.Where(a => a.Date.Month == date.Month && a.Date.Year == date.Year).ToList();
				
			}
			catch (Exception Ex)
			{

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

			Advance advanceU = new Advance();
		

			try
			{
			
				advanceU = db.Advances.Find(Convert.ToInt32(idTextBox.Text));
			}
			catch
			{

			}
		
			if ( advanceU.Id != 0)
			{

				db.Advances.Remove(advanceU);

				db.SaveChanges();
			}

			else
			{
				MessageBox.Show("Can not Delete!");
				db = new DatabaseContext();
				this.advanceDataGridView.DataSource = db.Advances.ToList();
				return;
			}



			MessageBox.Show("Deleted Sucessfully!");
			db = new DatabaseContext();
			this.advanceDataGridView.DataSource = db.Advances.ToList();


		}

		private void SaveAll()
		{


			//this.Validate();
			//this.advancesBindingSource.EndEdit();
			//this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
			Advance advances = new Advance();

			try
			{
				advances.Id = Convert.ToInt32(idTextBox.Text);
			}
			catch
			{

			}
			advances.EmployeeId = Convert.ToInt32(employeeIdComboBox.SelectedValue);
			advances.Amount = Convert.ToDouble(amountTextBox.Text);
			advances.Date = Convert.ToDateTime(dateDateTimePicker.Text);

			
				if(advances.IsAbleToTakeAdvance())
				{
					db.Advances.Add(advances);
					
					db.SaveChanges();
				}
				
				else
				{
					MessageBox.Show("Employee can not take advance for this month!");
				db = new DatabaseContext();
				this.advanceDataGridView.DataSource = db.Advances.ToList();
				return;
				}
				

			
			MessageBox.Show("Save Sucessfully!");
			//this.advanceBindingSource.DataSource = db.Advances.ToList();
			db = new DatabaseContext();
			this.advanceDataGridView.DataSource = db.Advances.ToList();



		}

		private void button5_Click(object sender, EventArgs e)
		{
			//// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			//this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			//// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Advances' table. You can move, or remove it, as needed.
			//this.advancesTableAdapter.Fill(this.homeTextileDBDataSet2.Advances);

			DialogResult res = MessageBox.Show("Are you sure you want to Update", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

			Advance advances = new Advance();
			Advance advanceU = new Advance();

			try
			{
				advances.Id = Convert.ToInt32(idTextBox.Text);
				advanceU = db.Advances.Find(advances.Id);
			}
			catch
			{

			}
			advanceU.EmployeeId = Convert.ToInt32(employeeIdComboBox.SelectedValue);
			advanceU.Amount = Convert.ToDouble(amountTextBox.Text)- advanceU.Amount ;
			advanceU.Date = Convert.ToDateTime(dateDateTimePicker.Text);


			if (advanceU.IsAbleToTakeAdvance() && advanceU.Id != 0)
			{
				advanceU.Amount = Convert.ToDouble(amountTextBox.Text);
				db.Entry(advanceU).State=EntityState.Modified;

				db.SaveChanges();
			}

			else
			{
				MessageBox.Show("Employee can not take advance for this month!");
				db = new DatabaseContext();
				db = new DatabaseContext();
				this.advanceDataGridView.DataSource = db.Advances.ToList();
				return;
			}



			MessageBox.Show("Save Sucessfully!");
			db = new DatabaseContext();
			db = new DatabaseContext();
			this.advanceDataGridView.DataSource = db.Advances.ToList();


			//this.advanceBindingSource.DataSource = db.Advances.ToList();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveAll();
		
		}

		private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
		{

		}

		private void advanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var loan = advanceDataGridView.CurrentRow;
				Advance advance = (Advance)loan.DataBoundItem;
				
			
				

				//assign value to form
				idTextBox.Text = advance.Id.ToString();
				dateDateTimePicker.Value =Convert.ToDateTime(advance.Date);
				amountTextBox.Text = advance.Amount.ToString();
				employeeIdComboBox.SelectedValue = advance.EmployeeId;
				employeeIdComboBox.SelectedItem = advance.Employee.NameWithId.ToString();
				
			}
			catch (Exception Ex)
			{

			}
		}

		private void advanceDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				var loan = advanceDataGridView.CurrentRow;
				Advance advance = (Advance)loan.DataBoundItem;




				//assign value to form
				idTextBox.Text = advance.Id.ToString();
				dateDateTimePicker.Value = Convert.ToDateTime(advance.Date);
				amountTextBox.Text = advance.Amount.ToString();
				employeeIdComboBox.SelectedValue = advance.EmployeeId;
				employeeIdComboBox.SelectedItem = advance.Employee.NameWithId.ToString();

			}
			catch (Exception Ex)
			{

			}
		}
	}
}
