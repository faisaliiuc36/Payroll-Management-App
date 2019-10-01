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
	public partial class Shift : Form
	{
		public Shift()
		{
			InitializeComponent();
		}

		private void shiftsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.shiftsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void Shift_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Shifts' table. You can move, or remove it, as needed.
			this.shiftsTableAdapter.Fill(this.homeTextileDBDataSet2.Shifts);
		}
	}
}
