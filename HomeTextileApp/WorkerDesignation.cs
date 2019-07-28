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
	public partial class WorkerDesignation : Form
	{
		public WorkerDesignation()
		{
			InitializeComponent();
		}

		private void salaryGradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.salaryGradesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet);

		}

		private void WorkerDesignation_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet.WorkerDesignations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.SalaryGrades' table. You can move, or remove it, as needed.
			this.salaryGradesTableAdapter.Fill(this.homeTextileDBDataSet.SalaryGrades);

		}
	}
}
