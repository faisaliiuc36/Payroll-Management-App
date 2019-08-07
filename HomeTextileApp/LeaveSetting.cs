using HomeTextileApp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class LeaveSetting : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public LeaveSetting()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy";
			dateTimePicker1.ShowUpDown = true;
			leaveStoresBindingSource.Filter="Year="+dateTimePicker1.Value.Year;
		}

		private void leaveTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.Validate();
				this.leaveTypesBindingSource.EndEdit();
				this.leaveStoresBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);


				
				
			}
			catch (Exception)
			{

			}
			var Leave = this.leaveStoresBindingSource.DataSource;
			
			

			List<LeaveStore> leaveStores = (List<LeaveStore>)Leave;
			foreach (LeaveStore L in leaveStores)
			{
				db.Entry(L).State = EntityState.Modified;
				db.SaveChanges();
			}

		}

		private void LeaveSetting_Load(object sender, EventArgs e)
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
	}
}
