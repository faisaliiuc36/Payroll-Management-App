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
	public partial class AddHolidays : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public AddHolidays()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy";
			dateTimePicker1.ShowUpDown = true;
		}

		private void holidaysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.holidaysBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void AddHolidays_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Holidays' table. You can move, or remove it, as needed.
			this.holidaysTableAdapter.Fill(this.homeTextileDBDataSet2.Holidays);

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			FilterHolidays();
		}

		private void FilterHolidays()
		{
			try
			{
				int id = Convert.ToInt32(comboBox3.SelectedValue);

				//Filter Holidays
				DateTime date = new DateTime(dateTimePicker1.Value.Year, 1, 1);
				DateTime date2 = new DateTime(dateTimePicker1.Value.Year, 12, 31);
				String.Format("{0:yyyy-MM-dd} 00:00:00", date);

				holidaysBindingSource.Filter = String.Format("From >= '{0:yyyy-MM-dd}' AND From < '{1:yyyy-MM-dd}' And DepartmentId=" + id, date, date2);
			}
			catch (Exception Ex)
			{

			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			FilterHolidays();
		}

		private void idLabel_Click(object sender, EventArgs e)
		{

		}

		private void idTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void departmentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void holidaysDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
				this.departmentsBindingSource2.DataSource = this.homeTextileDBDataSet2;
				this.departmentsBindingSource2.DataMember = "Departments";

				int Id =Convert.ToInt32 (departmentIdComboBox.SelectedValue);
				Department department = db.Departments.Find(Id);

				comboBox4.SelectedText = department.Unit.Company.Name;
				comboBox4.SelectedValue = department.Unit.CompanyId;

				comboBox1.SelectedText = department.Unit.Name;
				comboBox1.SelectedValue = department.UnitId;
			}
			catch(Exception Ex)
			{

			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult res = MessageBox.Show("Are you sure you want to Update", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

				if (res == DialogResult.Cancel)
				{
					return;
				}
				this.Validate();
				this.holidaysBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
				MessageBox.Show("Updated Sucessfullty!");
			}
			catch(Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

				if (res == DialogResult.Cancel)
				{
					return;
				}

				this.holidaysBindingSource.RemoveCurrent();
				this.Validate();
				this.holidaysBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);


				MessageBox.Show("Deleted Sucessfully!");
		
			}
			catch(Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				
				Holiday holiday = new Holiday();
				holiday.DepartmentId = Convert.ToInt32(departmentIdComboBox.SelectedValue);
				holiday.From = fromDateTimePicker.Value;
				holiday.To = toDateTimePicker.Value;
				holiday.HolidayReasons = holidayReasonsTextBox.Text.ToString();

				db.Holidays.Add(holiday);
				db.SaveChanges();

				MessageBox.Show("Save Sucessfullty!");

				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
				this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
				this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
				this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Holidays' table. You can move, or remove it, as needed.
				this.holidaysTableAdapter.Fill(this.homeTextileDBDataSet2.Holidays);

			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}
		}

		private void holidaysDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
				this.departmentsBindingSource2.DataSource = this.homeTextileDBDataSet2;
				this.departmentsBindingSource2.DataMember = "Departments";

				int Id = Convert.ToInt32(departmentIdComboBox.SelectedValue);
				Department department = db.Departments.Find(Id);

				comboBox4.SelectedText = department.Unit.Company.Name;
				comboBox4.SelectedValue = department.Unit.CompanyId;

				comboBox1.SelectedText = department.Unit.Name;
				comboBox4.SelectedValue = department.UnitId;
			}
			catch (Exception Ex)
			{

			}
		}

		private void button4_Click(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Holidays' table. You can move, or remove it, as needed.
			this.holidaysTableAdapter.Fill(this.homeTextileDBDataSet2.Holidays);

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			departmentsBindingSource2.Filter = "UnitId=" + Convert.ToInt32(comboBox1.SelectedValue);
		}
	}
}
