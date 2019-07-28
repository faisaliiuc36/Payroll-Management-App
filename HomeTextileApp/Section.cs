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
	public partial class Section : Form
	{
		public Section()
		{
			InitializeComponent();
		}

		private void companiesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.companiesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet1);

		}

		private void Section_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet1.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet1.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet1.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet1.Companies);

		}

		private void companiesBindingNavigator_RefreshItems(object sender, EventArgs e)
		{

		}

		private void button5_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.companiesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.unitsBindingSource.RemoveCurrent();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			this.companiesBindingSource.RemoveCurrent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.departmentsBindingSource.RemoveCurrent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.sectionsBindingSource.RemoveCurrent();
		}

		private void button6_Click(object sender, EventArgs e)
		{

			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet1.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet1.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet1.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet1.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet1.Companies);


		}
	}
}
