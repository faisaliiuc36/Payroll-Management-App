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
	public partial class LeaveSettings : Form
	{
		public LeaveSettings()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy";
			dateTimePicker1.ShowUpDown = true;
			leaveStoresBindingSource.Filter = "Year=" + dateTimePicker1.Value.Year;
		}

		private void leaveTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			
		}

		private void LeaveSettings_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.LeaveStores' table. You can move, or remove it, as needed.
			this.leaveStoresTableAdapter.Fill(this.homeTextileDBDataSet2.LeaveStores);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.LeaveTypes' table. You can move, or remove it, as needed.
			this.leaveTypesTableAdapter.Fill(this.homeTextileDBDataSet2.LeaveTypes);

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			leaveStoresBindingSource.Filter = "Year=" + dateTimePicker1.Value.Year;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.leaveTypesBindingSource.RemoveCurrent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.leaveStoresBindingSource.RemoveCurrent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Save();
		}

		private void Save()
		{
			try
			{
				this.Validate();
				this.leaveTypesBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
				MessageBox.Show("Save Sucessfully");

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Save();
		}
	}
}
