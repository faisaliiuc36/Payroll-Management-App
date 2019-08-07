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
	public partial class OtherSettings : Form
	{
		public OtherSettings()
		{
			InitializeComponent();
		}

		private void bloodGroupsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bloodGroupsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void OtherSettings_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Religions' table. You can move, or remove it, as needed.
			this.religionsTableAdapter.Fill(this.homeTextileDBDataSet2.Religions);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.MaritialStatus' table. You can move, or remove it, as needed.
			this.maritialStatusTableAdapter.Fill(this.homeTextileDBDataSet2.MaritialStatus);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.MaritialStatus' table. You can move, or remove it, as needed.
			this.maritialStatusTableAdapter.Fill(this.homeTextileDBDataSet2.MaritialStatus);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Genders' table. You can move, or remove it, as needed.
			this.gendersTableAdapter.Fill(this.homeTextileDBDataSet2.Genders);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Designations' table. You can move, or remove it, as needed.
			this.designationsTableAdapter.Fill(this.homeTextileDBDataSet2.Designations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.BloodGroups' table. You can move, or remove it, as needed.
			this.bloodGroupsTableAdapter.Fill(this.homeTextileDBDataSet2.BloodGroups);

		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				this.bloodGroupsBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
				MessageBox.Show("Save Sucessfully");
			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}
			
		}

		private void button6_Click(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Religions' table. You can move, or remove it, as needed.
			this.religionsTableAdapter.Fill(this.homeTextileDBDataSet2.Religions);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.MaritialStatus' table. You can move, or remove it, as needed.
			this.maritialStatusTableAdapter.Fill(this.homeTextileDBDataSet2.MaritialStatus);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.MaritialStatus' table. You can move, or remove it, as needed.
			this.maritialStatusTableAdapter.Fill(this.homeTextileDBDataSet2.MaritialStatus);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Genders' table. You can move, or remove it, as needed.
			this.gendersTableAdapter.Fill(this.homeTextileDBDataSet2.Genders);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Designations' table. You can move, or remove it, as needed.
			this.designationsTableAdapter.Fill(this.homeTextileDBDataSet2.Designations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.BloodGroups' table. You can move, or remove it, as needed.
			this.bloodGroupsTableAdapter.Fill(this.homeTextileDBDataSet2.BloodGroups);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.bloodGroupsBindingSource.RemoveCurrent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.designationsBindingSource.RemoveCurrent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.gendersBindingSource.RemoveCurrent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.religionsBindingSource.RemoveCurrent();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			this.maritialStatusBindingSource.RemoveCurrent();
		}
	}
}
