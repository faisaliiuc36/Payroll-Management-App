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
	public partial class StaffSalarySetting : Form
	{
		public StaffSalarySetting()
		{
			InitializeComponent();
		}

		private void salarySettingsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.salarySettingsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void StaffSalarySetting_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.SalarySettings' table. You can move, or remove it, as needed.
			this.salarySettingsTableAdapter.Fill(this.homeTextileDBDataSet2.SalarySettings);

		}
	}
}
