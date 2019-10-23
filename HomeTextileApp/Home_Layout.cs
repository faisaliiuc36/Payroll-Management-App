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
	public partial class Home_Layout : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public Home_Layout()
		{
			InitializeComponent();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void homeButton_Click(object sender, EventArgs e)
		{
			sidePanel.Height = homeButton.Height;
			sidePanel.Top = homeButton.Top;
			panel6.Controls.Clear();
			InvisibleAllSubPanel();
		}

		private void InvisibleAllSubPanel()
		{
			empSubPanel2.Visible = false;
			settingsSubPanel.Visible = false;
			LAHPanel.Visible = false;
			attendancePanel.Visible = false;
			reportPanel.Visible = false;
		}

		private void Layout_Load(object sender, EventArgs e)
		{
			AllButtonDisable();
			ProvidePermisssion();

		}

		private void ProvidePermisssion()
		{
			var user = db.HTAdmins.FirstOrDefault(a => a.Id == LoginInfo.UserID);

			if (user.Employee == true)
			{
				button6.Enabled = true;
			}
			if (user.Settings == true)
			{
				settingsButton.Enabled = true;
			}
			if (user.LeaveAndHoliday == true)
			{
				button1.Enabled = true;
			}
			if (user.Report == true)
			{
				button13.Enabled = true;
			}
			
			if (user.Attendance == true)
			{
				button17.Enabled = true;
			}
		}

		private void AllButtonDisable()
		{
			button6.Enabled = false;
			settingsButton.Enabled = false;
			button1.Enabled = false;
			button17.Enabled = false;
			button13.Enabled = false;
			
		}

		private void button6_Click(object sender, EventArgs e)
		{
			sidePanel.Height = pictureBox2.Height;
			sidePanel.Top = pictureBox2.Top;

			if (empSubPanel2.Visible)
			{
				InvisibleAllSubPanel();


			}
			else
			{
				InvisibleAllSubPanel();
				empSubPanel2.Visible = true;

				empSubPanel2.BringToFront();
			}

		}

		private void empListButton_Click(object sender, EventArgs e)
		{
			empSubPanel2.Visible = false;

			//Form Load
			panel6.Controls.Clear();
			EmployeeList objForm = new EmployeeList();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();

			//employeeControl1.BringToFront();
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			sidePanel.Height = pictureBox3.Height;
			sidePanel.Top = pictureBox3.Top;


			if (settingsSubPanel.Visible == true)
			{
				InvisibleAllSubPanel();

			}
			else
			{
				InvisibleAllSubPanel();
				settingsSubPanel.Visible = true;


			}
		}

		private void workerDesignationButton_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			WorkerDesignation objForm = new WorkerDesignation();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void upadteEmployeeButton_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();

			//Form Load
			panel6.Controls.Clear();
			EmployeeUpdate objForm = new EmployeeUpdate();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			ImportEmployee objForm = new ImportEmployee();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AddSalary objForm = new AddSalary();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			empSubPanel2.Visible = false;
			//Form Load
			panel6.Controls.Clear();
			Loan objForm = new Loan();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button10_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Section objForm = new Section();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button12_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			OtherSettings objForm = new OtherSettings();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button11_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			StaffSalarySetting objForm = new StaffSalarySetting();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			sidePanel.Height = button4.Height;
			sidePanel.Top = button4.Top;


			if (LAHPanel.Visible == true)
			{
				InvisibleAllSubPanel();

			}
			else
			{
				InvisibleAllSubPanel();
				LAHPanel.Visible = true;
			}
		}

		private void button15_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			LeaveApplication objForm = new LeaveApplication();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button14_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			LeaveSettings objForm = new LeaveSettings();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button17_Click(object sender, EventArgs e)
		{
			sidePanel.Height = button2.Height;
			sidePanel.Top = button2.Top;


			if (attendancePanel.Visible == true)
			{
				InvisibleAllSubPanel();

			}
			else
			{
				InvisibleAllSubPanel();
				attendancePanel.Visible = true;
			}
		}

		private void button13_Click(object sender, EventArgs e)
		{
			sidePanel.Height = button3.Height;
			sidePanel.Top = button3.Top;


			if (reportPanel.Visible == true)
			{
				InvisibleAllSubPanel();

			}
			else
			{
				InvisibleAllSubPanel();
				reportPanel.Visible = true;
			}
		}

		private void button16_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AddHolidays objForm = new AddHolidays();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button20_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			ImportAttendance objForm = new ImportAttendance();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button19_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Shift objForm = new Shift();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button18_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Duty_Roster objForm = new Duty_Roster();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button24_Click(object sender, EventArgs e)
		{

			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Manuel_Attendance objForm = new Manuel_Attendance();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button25_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			RangeWiseDutyRoster objForm = new RangeWiseDutyRoster();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button23_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Individual_Attendance objForm = new Individual_Attendance();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button22_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Daily_Attendance objForm = new Daily_Attendance();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button21_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AttendanceHistory objForm = new AttendanceHistory();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button26_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Salary_Report objForm = new Salary_Report();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button27_Click(object sender, EventArgs e)
		{

			this.Hide();
			Login_Form login_Form = new Login_Form();
			login_Form.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button27_Click_1(object sender, EventArgs e)
		{
			this.Hide();
			Login_Form login_Form = new Login_Form();
			login_Form.Show();
		}

		private void button28_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AddEmployeeDue objForm = new AddEmployeeDue();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button29_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AddAdvance objForm = new AddAdvance();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button30_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			EmpBonusReport objForm = new EmpBonusReport();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button31_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			OTDateWisePayment objForm = new OTDateWisePayment();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button32_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			OTPayment objForm = new OTPayment();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button33_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AdvanceDeduction objForm = new AdvanceDeduction();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button34_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			WorkerSalary objForm = new WorkerSalary();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button35_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			TransferHoliday objForm = new TransferHoliday();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button36_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AddEarnLeave objForm = new AddEarnLeave();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button37_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			AddBonus objForm = new AddBonus();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void empSubPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{

		}

		private void sidePanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button4_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}

	

		private void panel3_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel4_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void settingsSubPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void empSubPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button34_Click_1(object sender, EventArgs e)
		{

		}

		private void panel6_Paint(object sender, PaintEventArgs e)
		{

		}

		private void LAHPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label4_Click(object sender, EventArgs e)
		{

		}

		private void attendancePanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void reportPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button23_Click_1(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			Individual_Attendance objForm = new Individual_Attendance();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			//objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void homeButton_Click_1(object sender, EventArgs e)
		{
			sidePanel.Height = homeButton.Height;
			sidePanel.Top = homeButton.Top;
			panel6.Controls.Clear();
			InvisibleAllSubPanel();
		}

		private void button8__Click(object sender, EventArgs e)
		{

		}
	}
}
