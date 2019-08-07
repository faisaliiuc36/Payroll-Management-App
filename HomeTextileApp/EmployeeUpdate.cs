using HomeTextileApp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class EmployeeUpdate : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public EmployeeUpdate()
		{
			InitializeComponent();
		}

		private void EmployeeUpdate_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Genders' table. You can move, or remove it, as needed.
			this.gendersTableAdapter.Fill(this.homeTextileDBDataSet2.Genders);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Designations' table. You can move, or remove it, as needed.
			this.designationsTableAdapter.Fill(this.homeTextileDBDataSet2.Designations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Religions' table. You can move, or remove it, as needed.
			this.religionsTableAdapter.Fill(this.homeTextileDBDataSet2.Religions);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet2.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.BloodGroups' table. You can move, or remove it, as needed.
			this.bloodGroupsTableAdapter.Fill(this.homeTextileDBDataSet2.BloodGroups);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.MaritialStatus' table. You can move, or remove it, as needed.
			this.maritialStatusTableAdapter.Fill(this.homeTextileDBDataSet2.MaritialStatus);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.EmployeeTypes' table. You can move, or remove it, as needed.
			this.employeeTypesTableAdapter.Fill(this.homeTextileDBDataSet2.EmployeeTypes);
			LoadEmployee();
			
		}

		private void LoadEmployee()
		{
			List<Employee> employees = db.Employees.ToList();
			List<Employee> newemployees=employees.Where(a => a.IsEdited == false).ToList();

	
			employeesBindingSource.DataSource = newemployees;


		}

		private void LoadCompany()
		{
			List<DL.Company> companies = db.Companies.ToList();

			comboBox1.DataSource = null;
			comboBox1.DataSource = companies.ToList();
			comboBox1.DisplayMember = "Name";
			comboBox1.ValueMember = "Id";
			comboBox1.Text = "Select";
		}

		private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			

		}

		private void DataBindEmployee(Employee employee)
		{
			employee.Address = Convert.ToString(addressTextBox.Text);
			employee.BloodGroupId = Convert.ToInt32(bloodGroupIdComboBox.SelectedValue);
			if (employee.BloodGroupId == 0)
			{
				employee.BloodGroupId = null;
			}
			employee.DesignationId = Convert.ToInt32(designationIdComboBox.SelectedValue);

			if (employee.DesignationId == 0)
			{
				employee.DesignationId = null;
			}


			employee.Email = Convert.ToString(emailTextBox.Text);
			employee.EmergencyContact = Convert.ToString(emergencyContactTextBox.Text);
			employee.EmployeeTypeId = Convert.ToInt32(employeeTypeIdComboBox.SelectedValue);

			if (employee.EmployeeTypeId == 0)
			{
				employee.EmployeeTypeId = null;
			}

			employee.EndDate = Convert.ToDateTime(endDateDateTimePicker.Text);
			employee.FirstName = Convert.ToString(firstNameTextBox.Text);
			employee.LastName = Convert.ToString(lastNameTextBox.Text);
			employee.MaritialStatusId = Convert.ToInt32(maritialStatusIdComboBox.SelectedValue);
			if (employee.MaritialStatusId == 0)
			{
				employee.MaritialStatusId = null;
			}


			employee.MiddleName = Convert.ToString(middleNameTextBox.Text);
			employee.NationalId = Convert.ToString(nationalIdTextBox.Text);


			employee.PhoneNumber = Convert.ToString(phoneNumberTextBox.Text);
			employee.ReligionId = Convert.ToInt32(religionIdComboBox.SelectedValue);
			if (employee.ReligionId == 0)
			{
				employee.ReligionId = null;
			}
			employee.SectionId = Convert.ToInt32(sectionIdComboBox.SelectedValue);
			if (employee.SectionId == 0)
			{
				employee.SectionId = null;
			}
			employee.TechnicalAllowance = Convert.ToDouble(technicalAllowanceTextBox.Text);
			employee.WorkerDesignationId = Convert.ToInt32(workerDesignationIdComboBox.SelectedValue);
			if (employee.WorkerDesignationId == 0)
			{
				employee.WorkerDesignationId = null;
			}
			employee.GenderId = Convert.ToInt32(genderIdComboBox.SelectedValue);
			if (employee.GenderId == 0)
			{
				employee.GenderId = null;
			}
		}

		private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}

		private void employeesBindingNavigator_RefreshItems(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorSeparator_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorCountItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorSeparator1_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorSeparator2_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{

		}

		private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
		{

		}

		private void employeesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void emp_IdLabel_Click(object sender, EventArgs e)
		{

		}

		private void emp_IdTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void employeeTypeIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void employeeTypeIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void sectionIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void sectionIdTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void empFullNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void empFullNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void badgeNumberLabel_Click(object sender, EventArgs e)
		{

		}

		private void badgeNumberTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void dateOfBirthLabel_Click(object sender, EventArgs e)
		{

		}

		private void dateOfBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void bloodGroupIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void bloodGroupIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void hireDateLabel_Click(object sender, EventArgs e)
		{

		}

		private void hireDateDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void religionIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void addressLabel_Click(object sender, EventArgs e)
		{

		}

		private void addressTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void phoneNumberLabel_Click(object sender, EventArgs e)
		{

		}

		private void phoneNumberTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void emailLabel_Click(object sender, EventArgs e)
		{

		}

		private void emailTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void activeStatusLabel_Click(object sender, EventArgs e)
		{

		}

		private void activeStatusCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void firstNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void firstNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void lastNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void lastNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void middleNameLabel_Click(object sender, EventArgs e)
		{

		}

		private void middleNameTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void emergencyContactLabel_Click(object sender, EventArgs e)
		{

		}

		private void emergencyContactTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void genderIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void isTraineeLabel_Click(object sender, EventArgs e)
		{

		}

		private void isTraineeCheckBox_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void endDateLabel_Click(object sender, EventArgs e)
		{

		}

		private void endDateDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void passwordLabel_Click(object sender, EventArgs e)
		{

		}

		private void passwordTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void permanentLabel_Click(object sender, EventArgs e)
		{

		}

		private void permanentDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void workerDesignationIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void workerDesignationIdTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void technicalAllowanceLabel_Click(object sender, EventArgs e)
		{

		}

		private void technicalAllowanceTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void nationalIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void nationalIdTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void religionIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			
		}

		private void maritialStatusIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void maritialStatusIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void designationIdLabel_Click(object sender, EventArgs e)
		{

		}

		private void designationIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void genderIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void isWorkerTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void isWorkerLabel_Click(object sender, EventArgs e)
		{

		}

		private void imageFileTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void imageFileLabel_Click(object sender, EventArgs e)
		{

		}

		private void imagePathTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void imagePathLabel_Click(object sender, EventArgs e)
		{

		}

		private void insertDateDateTimePicker_ValueChanged(object sender, EventArgs e)
		{

		}

		private void insertDateLabel_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label5_Click(object sender, EventArgs e)
		{

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label6_Click(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void textBox4_TextChanged(object sender, EventArgs e)
		{

		}

		private void label8_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{

		}

		private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void label10_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label11_Click(object sender, EventArgs e)
		{

		}

		private void label12_Click(object sender, EventArgs e)
		{

		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void label13_Click(object sender, EventArgs e)
		{

		}

		private void textBox6_TextChanged(object sender, EventArgs e)
		{

		}

		private void label14_Click(object sender, EventArgs e)
		{

		}

		private void textBox7_TextChanged(object sender, EventArgs e)
		{

		}

		private void label15_Click(object sender, EventArgs e)
		{

		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label16_Click(object sender, EventArgs e)
		{

		}

		private void textBox8_TextChanged(object sender, EventArgs e)
		{

		}

		private void label17_Click(object sender, EventArgs e)
		{

		}

		private void textBox9_TextChanged(object sender, EventArgs e)
		{

		}

		private void label18_Click(object sender, EventArgs e)
		{

		}

		private void textBox10_TextChanged(object sender, EventArgs e)
		{

		}

		private void label19_Click(object sender, EventArgs e)
		{

		}

		private void textBox11_TextChanged(object sender, EventArgs e)
		{

		}

		private void label20_Click(object sender, EventArgs e)
		{

		}

		private void label21_Click(object sender, EventArgs e)
		{

		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void label22_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label23_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label24_Click(object sender, EventArgs e)
		{

		}

		private void textBox12_TextChanged(object sender, EventArgs e)
		{

		}

		private void label25_Click(object sender, EventArgs e)
		{

		}

		private void textBox13_TextChanged(object sender, EventArgs e)
		{

		}

		private void label26_Click(object sender, EventArgs e)
		{

		}

		private void textBox14_TextChanged(object sender, EventArgs e)
		{

		}

		private void label27_Click(object sender, EventArgs e)
		{

		}

		private void textBox15_TextChanged(object sender, EventArgs e)
		{

		}

		private void label28_Click(object sender, EventArgs e)
		{

		}

		private void dateTimePicker5_ValueChanged(object sender, EventArgs e)
		{

		}

		private void label29_Click(object sender, EventArgs e)
		{

		}

		private void textBox16_TextChanged(object sender, EventArgs e)
		{

		}

		private void label30_Click(object sender, EventArgs e)
		{

		}

		private void textBox17_TextChanged(object sender, EventArgs e)
		{

		}

		private void label31_Click(object sender, EventArgs e)
		{

		}

		private void textBox18_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			LoadCombobox2();


		}

		private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			try
			{
				int value = Convert.ToInt32(comboBox2.SelectedValue);
				List<Department> departments = db.Departments.Where(a => a.UnitId == value).ToList();

				comboBox3.DataSource = null;
				comboBox3.DataSource = departments.ToList();
				comboBox3.DisplayMember = "Name";
				comboBox3.ValueMember = "Id";
				comboBox3.Text = "Select";
			}
			catch(Exception)
			{
				
			}

			
		}

		private void comboBox3_SelectedIndexChanged_1(object sender, EventArgs e)
		{
			try
			{
				int value = Convert.ToInt32(comboBox3.SelectedValue);
				List<DL.Section> sections = db.Sections.Where(a => a.DepartmentId == value).ToList();

				sectionIdComboBox.DataSource = null;
				sectionIdComboBox.DataSource = sections.ToList();
				sectionIdComboBox.DisplayMember = "Name";
				sectionIdComboBox.ValueMember = "Id";
				sectionIdComboBox.Text = "Select";
			}
			catch (Exception E)
			{
				
			}
			
		}

		private void employeesDataGridView_CellContentClick(object sender, EventArgs e)
		{
			try
			{
				var emp = employeesDataGridView.CurrentRow;
			Employee emp2= (Employee)emp.DataBoundItem;
			Employee employee = db.Employees.Find(emp2.Id);
			
			if (employee.SectionId != null)
			{
				DL.Section section = db.Sections.Find(employee.SectionId);
				LoadCompany();
				comboBox1.SelectedItem = section.Department.Unit.Company.Name;
				//LoadCombobox2();

				comboBox2.SelectedItem = section.Department.Unit.Name;
				comboBox3.SelectedItem = section.Department.Name;
				sectionIdComboBox.SelectedValue = section.Id;

				//Display image
				
				
			}
			else
			{
				LoadCompany();
			}

			
				pictureBox1.Image = null;
				pictureBox1.Image = new Bitmap(employee.ImagePath);
				checkBox1.Checked = false;
			}
			catch(Exception)
			{
				
			}
		}

		private void LoadCombobox2()
		{
			try
			{
				int value = Convert.ToInt32(comboBox1.SelectedValue);
				if (value != 0)
				{
					List<Unit> units = db.Units.Where(a => a.CompanyId == value).ToList();

					comboBox2.DataSource = null;

					comboBox2.DataSource = units.ToList();

					comboBox2.DisplayMember = "Name";
					comboBox2.ValueMember = "Id";
					comboBox2.Text = "Select";
				}
			}
			catch (Exception Ex)
			{

			}

		}

		private void imagePathLabel_Click_1(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{


				pictureBox1.Image = new Bitmap(opnfd.FileName);
				checkBox1.Checked = true;
			}
		}

		private Image GetCompressedBitmap(Bitmap bmp, long quality)
		{
			using (var mss = new MemoryStream())
			{
				EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
				ImageCodecInfo imageCodec = ImageCodecInfo.GetImageEncoders().FirstOrDefault(o => o.FormatID == ImageFormat.Jpeg.Guid);
				EncoderParameters parameters = new EncoderParameters(1);
				parameters.Param[0] = qualityParam;
				bmp.Save(mss, imageCodec, parameters);
				return Image.FromStream(mss);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{








			var emp = employeesDataGridView.CurrentRow;

			Employee employee = (Employee)emp.DataBoundItem;
			DataBindEmployee(employee);
			employee.DateOfBirth = Convert.ToDateTime(dateOfBirthDateTimePicker.Text);




			try
			{
				//Image Save
				if (checkBox1.Checked == true)
				{
					Bitmap B = new Bitmap(pictureBox1.Image);
					string p = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Millisecond.ToString();
					string path = Path.GetDirectoryName(Application.StartupPath).Replace(@"\bin", string.Empty);
					B.Save(path + @"\EmployeeImage\" + p);
					employee.ImagePath = path + @"\EmployeeImage\" + p;
				}
				else
				{
					checkBox1.Checked = false;
				}

			}
			catch (Exception)
			{

			}









			db.Entry(employee).State = EntityState.Modified;
			db.SaveChanges();

			LoadEmployee();
			MessageBox.Show("Save Sucessfully!");

			//this.Validate();
			//this.employeesBindingSource.EndEdit();
			//this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}
	}
}
