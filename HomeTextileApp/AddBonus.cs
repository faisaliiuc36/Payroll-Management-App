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
	public partial class AddBonus : Form
	{
		public AddBonus()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy";
			dateTimePicker1.ShowUpDown = true;
		}

		private void AddBonus_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Bonus' table. You can move, or remove it, as needed.
			this.bonusTableAdapter.Fill(this.homeTextileDBDataSet2.Bonus);

		}

		private void bonusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bonusBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.bonusBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
			MessageBox.Show("Save Sucessfully!");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show("Are you sure you want to Delete", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

			if (res == DialogResult.Cancel)
			{
				return;
			}

			this.bonusBindingSource.RemoveCurrent();



			this.Validate();
			this.bonusBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

			MessageBox.Show("Deleted Sucessfully!");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Bonus' table. You can move, or remove it, as needed.
			this.bonusTableAdapter.Fill(this.homeTextileDBDataSet2.Bonus);

		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				
				//Filter
				DateTime date = new DateTime(dateTimePicker1.Value.Year, 1, 1);
				DateTime date2 = new DateTime(dateTimePicker1.Value.Year, 12, 31);
				String.Format("{0:yyyy-MM-dd} 00:00:00", date);


				bonusBindingSource.Filter = String.Format("Date >= '{0:yyyy-MM-dd}' AND Date < '{1:yyyy-MM-dd}'" , date, date2);


			}
			catch (Exception)
			{

				
			}
		}
	}
}
