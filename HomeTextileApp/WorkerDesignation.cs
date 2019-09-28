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
	public partial class WorkerDesignation : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public WorkerDesignation()
		{
			InitializeComponent();
		}

		private void workerDesignationsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.workerDesignationsBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void salaryGradesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.salaryGradesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void WorkerDesignation_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.SalaryGrades' table. You can move, or remove it, as needed.
			this.salaryGradesTableAdapter.Fill(this.homeTextileDBDataSet2.SalaryGrades);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);

		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{

				this.Validate();
				this.salaryGradesBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
				Save_Shadow_SalaryGrade();

				MessageBox.Show("Save Sucessfully!");

			}
			catch (Exception Ex)
			{
				MessageBox.Show(Ex.ToString());
			}

		}

		private void Save_Shadow_SalaryGrade()
		{
			List<SalaryGrade> salaryGrades = db.SalaryGrades.ToList();
			if (salaryGrades.Count > 0)
			{
				foreach (SalaryGrade salaryGrade in salaryGrades)
				{
					ShadowSalaryGrade shadowSalaryGrade2 = db.ShadowSalaryGrades.FirstOrDefault(a => a.EffectiveFrom.Month == salaryGrade.EffectiveFrom.Month && a.EffectiveFrom.Year == salaryGrade.EffectiveFrom.Year && a.RoWId == salaryGrade.Id);
					if(shadowSalaryGrade2 != null)
					{
						//Update
						ShadowSalaryGrade shadowSalaryGrade = db.ShadowSalaryGrades.Find(shadowSalaryGrade2.Id);

						shadowSalaryGrade.AssignFromOriginal(salaryGrade);

						db.Entry(shadowSalaryGrade).State=EntityState.Modified;
						db.SaveChanges();
					}
					else
					{
						// New
						ShadowSalaryGrade shadowSalaryGrade = new ShadowSalaryGrade();
						shadowSalaryGrade.AssignFromOriginal(salaryGrade);

						db.ShadowSalaryGrades.Add(shadowSalaryGrade);
						db.SaveChanges();
					}
					

					


				}
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.SalaryGrades' table. You can move, or remove it, as needed.
			this.salaryGradesTableAdapter.Fill(this.homeTextileDBDataSet2.SalaryGrades);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.WorkerDesignations' table. You can move, or remove it, as needed.
			this.workerDesignationsTableAdapter.Fill(this.homeTextileDBDataSet2.WorkerDesignations);


		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.salaryGradesBindingSource.RemoveCurrent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.workerDesignationsBindingSource.RemoveCurrent();
		}

		private void salaryGradesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
		{
			this.Validate();
			this.salaryGradesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}
	}
}
