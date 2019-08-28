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
	public partial class Admin : Form
	{
		public Admin()
		{
			InitializeComponent();
		}

		private void hTAdminsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.hTAdminsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void Admin_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.HTAdmins' table. You can move, or remove it, as needed.
			this.hTAdminsTableAdapter.Fill(this.homeTextileDBDataSet2.HTAdmins);

		}
	}
}
