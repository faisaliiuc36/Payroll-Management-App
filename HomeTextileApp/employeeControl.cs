using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class employeeControl : UserControl
	{
		public employeeControl()
		{
			InitializeComponent();
		}

		private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.employeesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet);

		}

		private void employeesBindingNavigator_RefreshItems(object sender, EventArgs e)
		{

		}
	}
}
