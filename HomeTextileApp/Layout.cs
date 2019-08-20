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
	public partial class Layout : Form
	{
		public Layout()
		{
			InitializeComponent();
		}

		private void home1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
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
		}

		private void Layout_Load(object sender, EventArgs e)
		{
			//home1.BringToFront();
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
			EmployeeList objForm =new EmployeeList();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			InvisibleAllSubPanel();
			//Form Load
			panel6.Controls.Clear();
			SalaryAndBonus objForm = new SalaryAndBonus();
			objForm.TopLevel = false;
			panel6.Controls.Add(objForm);
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
			objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			objForm.Dock = DockStyle.Fill;
			objForm.Show();
		}
	}
}
                                                                                  