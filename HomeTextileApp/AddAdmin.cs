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
	public partial class AddAdmin : Form
	{
		public AddAdmin()
		{
			InitializeComponent();
		}

		private void hTAdminsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			
		}

		private void AddAdmin_Load(object sender, EventArgs e)
		{
				// TODO: This line of code loads data into the 'homeTextileDBDataSet2.HTAdmins' table. You can move, or remove it, as needed.
			this.hTAdminsTableAdapter1.Fill(this.homeTextileDBDataSet2.HTAdmins);
			
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Save();

		}

		private void Save()
		{
			try
			{
				this.Validate();
				this.hTAdminsBindingSource1.EndEdit();
				this.tableAdapterManager1.UpdateAll(this.homeTextileDBDataSet2);
			}
			catch(Exception E)
			{
				MessageBox.Show(E.ToString());
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.hTAdminsBindingSource1.RemoveCurrent();
			Save();
		}

		private void button6_Click(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.HTAdmins' table. You can move, or remove it, as needed.
			this.hTAdminsTableAdapter1.Fill(this.homeTextileDBDataSet2.HTAdmins);

		}
	}
}
