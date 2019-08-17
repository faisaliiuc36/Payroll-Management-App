using HomeTextileApp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class EmployeeList : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public EmployeeList()
		{
			InitializeComponent();
		}

		private void EmployeeList_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.EmployeeTypes' table. You can move, or remove it, as needed.
			this.employeeTypesTableAdapter.Fill(this.homeTextileDBDataSet2.EmployeeTypes);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.MaritialStatus' table. You can move, or remove it, as needed.
			this.maritialStatusTableAdapter.Fill(this.homeTextileDBDataSet2.MaritialStatus);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.BloodGroups' table. You can move, or remove it, as needed.
			this.bloodGroupsTableAdapter.Fill(this.homeTextileDBDataSet2.BloodGroups);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Genders' table. You can move, or remove it, as needed.
			this.gendersTableAdapter.Fill(this.homeTextileDBDataSet2.Genders);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Designations' table. You can move, or remove it, as needed.
			this.designationsTableAdapter.Fill(this.homeTextileDBDataSet2.Designations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Religions' table. You can move, or remove it, as needed.
			this.religionsTableAdapter.Fill(this.homeTextileDBDataSet2.Religions);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet2.Employees);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet2.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);

			
			LoadEmployee();
			LoadCascadingDropDown();
		}

		private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			LoadCascadingDropDown();
		}

		private void LoadCascadingDropDown()
		{
			checkBox2.Checked = false;
			try
			{
				var emp = employeesDataGridView.CurrentRow;
				Employee emp2 = (Employee)emp.DataBoundItem;
				Employee employee = db.Employees.Find(emp2.Id);
				//Is Active Status
				if(!employee.IsActive(DateTime.Now))
				{
					inActiveCheckBox.Checked = true;
					List<InActiveHistory> inActiveHistories = db.InActiveHistories.Where(a => a.EmployeeId == employee.Id).OrderBy(a => a.From).ToList();
					inActiveDateTimePicker.Value = inActiveHistories[inActiveHistories.Count - 1].From ;

				}
				else
				{
					inActiveCheckBox.Checked = false;
					inActiveDateTimePicker.Value = DateTime.Now;
				}

				DL.Section section = db.Sections.Find(employee.SectionId);

				comboBox10.SelectedText = section.Department.Unit.Company.Name;
				comboBox10.SelectedValue = section.Department.Unit.Company.Id;

				comboBox9.SelectedText = section.Department.Unit.Name;
				comboBox9.SelectedValue = section.Department.Unit.Id;

				comboBox8.SelectedText = section.Department.Name;
				comboBox8.SelectedValue = section.Department.Id;

				comboBox7.SelectedText = section.Name;
				comboBox7.SelectedValue = section.Id;


				//Image Load
				pictureBox2.Image = null;
				pictureBox2.Image = new Bitmap(employee.ImagePath);
				checkBox2.Checked = false;
			}
			catch (Exception Ex)
			{

			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{


				pictureBox2.Image = new Bitmap(opnfd.FileName);
				checkBox2.Checked = true;
			}
		}

		private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int value = Convert.ToInt32(companyComboBox.SelectedValue);

				List<Employee> employees = db.Employees.Where(a => a.Section.Department.Unit.CompanyId == value).ToList();

				employeesBindingSource.DataSource = employees.Where(a => a.IsEdited == true).ToList();
			}
			catch(Exception Ex)
			{

			}
		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int value = Convert.ToInt32(comboBox2.SelectedValue);

				List<Employee> employees = db.Employees.Where(a => a.Section.Department.UnitId == value).ToList();

				employeesBindingSource.DataSource = employees.Where(a => a.IsEdited == true).ToList();
			}
			catch (Exception Ex)
			{

			}
		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int value = Convert.ToInt32(comboBox3.SelectedValue);

				List<Employee> employees = db.Employees.Where(a => a.Section.DepartmentId == value).ToList();

				employeesBindingSource.DataSource = employees.Where(a => a.IsEdited == true).ToList();
			}
			catch (Exception Ex)
			{

			}
		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				int value = Convert.ToInt32(comboBox4.SelectedValue);

				List<Employee> employees = db.Employees.Where(a => a.SectionId == value).ToList();

				employeesBindingSource.DataSource = employees.Where(a => a.IsEdited == true).ToList();
			}
			catch (Exception Ex)
			{

			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int value = Convert.ToInt32(textBox1.Text);

				List<Employee> employees = db.Employees.Where(a => a.Emp_Id == value).ToList();

				employeesBindingSource.DataSource = employees.Where(a => a.IsEdited == true).ToList();
			}
			catch (Exception Ex)
			{

			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			


			try
			{
				var emp = employeesDataGridView.CurrentRow;

				Employee employee = (Employee)emp.DataBoundItem;
				DataBindEmployee(employee);
				employee.DateOfBirth = Convert.ToDateTime(dateOfBirthDateTimePicker.Text);

				InActiveStatusUpdate(employee);


				//Image Save
				if (checkBox2.Checked == true)
				{
					Bitmap B = new Bitmap(pictureBox2.Image);
					string p = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
					string path = Path.GetDirectoryName(Application.StartupPath).Replace(@"\bin", string.Empty);
					B.Save(path + @"\EmployeeImage\" + p);
					employee.ImagePath = path + @"\EmployeeImage\" + p;
				}
				else
				{
					checkBox2.Checked = false;
				}


				db.Entry(employee).State = EntityState.Modified;
				db.SaveChanges();

				//LoadEmployee();
				//this.Close();


				EmployeeList employeeList = new EmployeeList();
				employeeList.Refresh();


				MessageBox.Show("Save Sucessfully!");
			}
			catch (Exception)
			{
				LoadEmployee();
			}









			
		}

		private void InActiveStatusUpdate(Employee employee)
		{
			//Inactive To Active
			if (employee.IsActive(DateTime.Now)==false && inActiveCheckBox.Checked==false)
			{
				List<InActiveHistory> inActiveHistories = db.InActiveHistories.Where(a => a.EmployeeId == employee.Id).OrderBy(a=>a.From).ToList();
				InActiveHistory inActiveHistory = db.InActiveHistories.Find(inActiveHistories[inActiveHistories.Count - 1].Id); 
				
				inActiveHistory.To= Convert.ToDateTime(inActiveDateTimePicker.Text);

				db.Entry(inActiveHistory).State = EntityState.Modified;
				db.SaveChanges();
			}
			//Active To Inactive
			else if(employee.IsActive(DateTime.Now) == true && inActiveCheckBox.Checked == true)
			{
				InActiveHistory inActiveHistory = new InActiveHistory();
				inActiveHistory.EmployeeId = employee.Id;
				inActiveHistory.From = Convert.ToDateTime(inActiveDateTimePicker.Text);

				db.InActiveHistories.Add(inActiveHistory);
				db.SaveChanges();
			}
		}

		private void DataBindEmployee(Employee employee)
		{
			//employee.Address = Convert.ToString(addressTextBox.Text);
			employee.BloodGroupId = Convert.ToInt32(comboBox17.SelectedValue);
			if (employee.BloodGroupId == 0)
			{
				employee.BloodGroupId = null;
			}

			
			employee.DesignationId = Convert.ToInt32(comboBox13.SelectedValue);

			if (employee.DesignationId == 0)
			{
				employee.DesignationId = null;
			}


			//employee.Email = Convert.ToString(emailTextBox.Text);
			//employee.EmergencyContact = Convert.ToString(emergencyContactTextBox.Text);
			employee.EmployeeTypeId = Convert.ToInt32(comboBox16.SelectedValue);

			if (employee.EmployeeTypeId == 0)
			{
				employee.EmployeeTypeId = null;
			}

			employee.EndDate = Convert.ToDateTime(dateTimePicker1.Text);
			//employee.FirstName = Convert.ToString(firstNameTextBox.Text);
			//employee.LastName = Convert.ToString(lastNameTextBox.Text);
			employee.MaritialStatusId = Convert.ToInt32(comboBox14.SelectedValue);
			if (employee.MaritialStatusId == 0)
			{
				employee.MaritialStatusId = null;
			}


			//employee.MiddleName = Convert.ToString(middleNameTextBox.Text);
			//employee.NationalId = Convert.ToString(nationalIdTextBox.Text);


			//employee.PhoneNumber = Convert.ToString(phoneNumberTextBox.Text);
			employee.ReligionId = Convert.ToInt32(comboBox15.SelectedValue);
			if (employee.ReligionId == 0)
			{
				employee.ReligionId = null;
			}
			employee.SectionId = Convert.ToInt32(comboBox7.SelectedValue);
			if (employee.SectionId == 0)
			{
				employee.SectionId = null;
			}
			//employee.TechnicalAllowance = Convert.ToDouble(technicalAllowanceTextBox.Text);
			employee.WorkerDesignationId = Convert.ToInt32(comboBox11.SelectedValue);
			if (employee.WorkerDesignationId == 0)
			{
				employee.WorkerDesignationId = null;
			}
			employee.GenderId = Convert.ToInt32(comboBox12.SelectedValue);
			if (employee.GenderId == 0)
			{
				employee.GenderId = null;
			}
		}

		private void LoadEmployee()
		{
			checkBox2.Checked = false;
			List<Employee> employees = db.Employees.ToList();
			List<Employee> newemployees = employees.Where(a => a.IsEdited == true).ToList();


			this.employeesBindingSource.DataSource = newemployees;
		}

		private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
