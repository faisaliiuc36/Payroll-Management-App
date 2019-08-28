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
	public partial class Login_Form : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public Login_Form()
		{
			InitializeComponent();
			notMatchedLabel.Text = "";
		}

		private void hTAdminsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.hTAdminsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void Login_Form_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.HTAdmins' table. You can move, or remove it, as needed.
			this.hTAdminsTableAdapter.Fill(this.homeTextileDBDataSet2.HTAdmins);

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			string userName = userNameTextBox.Text.ToString();
			string password = passwordTextBox.Text.ToString();

			var IsUserExist = db.HTAdmins.FirstOrDefault(a => a.UserName == userName && a.Password == password);

			if(IsUserExist ==null)
			{
				notMatchedLabel.Text = "Not Match!";
			}

			else
			{
				LoginInfo.UserID = IsUserExist.Id;
				LoginInfo.UserName = IsUserExist.UserName;

				this.Hide();
				Layout layout = new Layout();
				layout.Show();
				
			}
		}

	}
}
