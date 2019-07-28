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
			home1.BringToFront();
		}

		

		private void Layout_Load(object sender, EventArgs e)
		{
			home1.BringToFront();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			settingsSubPanel.Visible = false;
			if (empSubPanel2.Visible)
			{
				empSubPanel2.Visible = false;
			
			}
			else
			{
				empSubPanel2.Visible = true;
		
				empSubPanel2.BringToFront();
			}
	
		}

		private void empListButton_Click(object sender, EventArgs e)
		{
			empSubPanel2.Visible = false;
			
			employeeControl1.BringToFront();
		}

		private void settingsButton_Click(object sender, EventArgs e)
		{
			empSubPanel2.Visible = false;
			if (settingsSubPanel.Visible)
			{
				settingsSubPanel.Visible = false;
			
			}
			else
			{
				
				settingsSubPanel.Visible = true;
				settingsSubPanel.BringToFront();
			}
		}

		private void workerDesignationButton_Click(object sender, EventArgs e)
		{
			settingsSubPanel.Visible = false;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
		}
	}
}
                                                                                  