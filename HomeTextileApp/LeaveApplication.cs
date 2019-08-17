using HomeTextileApp.DL;
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
	public partial class LeaveApplication : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public LeaveApplication()
		{
			InitializeComponent();
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = "yyyy";
			dateTimePicker1.ShowUpDown = true;
		}

		private void leavesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.leavesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void LeaveApplication_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet2.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Departments' table. You can move, or remove it, as needed.
			this.departmentsTableAdapter.Fill(this.homeTextileDBDataSet2.Departments);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Units' table. You can move, or remove it, as needed.
			this.unitsTableAdapter.Fill(this.homeTextileDBDataSet2.Units);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet2.Companies);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.LeaveTypes' table. You can move, or remove it, as needed.
			this.leaveTypesTableAdapter.Fill(this.homeTextileDBDataSet2.LeaveTypes);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Leaves' table. You can move, or remove it, as needed.
			this.leavesTableAdapter.Fill(this.homeTextileDBDataSet2.Leaves);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SaveLeave();
		}

		private void SaveLeave()
		{
			try
			{

				this.Validate();
				this.leavesBindingSource.EndEdit();
				this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);
				MessageBox.Show("Save Sucessfully!");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.leavesBindingSource.RemoveCurrent();
			SaveLeave();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
		{
			BindLeavesBinding();
		}

		private void BindLeavesBinding()
		{
			int value = Convert.ToInt32(comboBox4.SelectedValue);
			int Year = dateTimePicker1.Value.Year;



			List<Leave> leaves2 = new List<Leave>();
			List<Leave> leaves = db.Leaves.ToList();

			foreach (Leave L in leaves)
			{
				var CHeck = db.Employees.FirstOrDefault(a => a.Emp_Id == L.EmployeeId && a.SectionId == value);
				if (CHeck != null && L.From.Year == Year)
				{
					leaves2.Add(L);
				}

			}




			leavesDataGridView.DataSource = leaves2.ToList();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				int EmpId = Convert.ToInt32(textBox1.Text);

				leavesBindingSource.Filter = "EmployeeId=" + EmpId;
				GetLeaveHistory();
			}
			catch(Exception)
			{

			}
		}

		private void GetLeaveHistory()
		{
			int EMpID = Convert.ToInt32(textBox1.Text);
			Employee employee = db.Employees.FirstOrDefault(a => a.Emp_Id == EMpID);
			int EndYear = dateTimePicker1.Value.Year;
			DateTime date = Convert.ToDateTime(employee.HireDate);
			int StartYear = date.Year;


			List<LeaveType> leaveIncrementals = db.LeaveTypes.Where(a => a.IsIncremental == true).ToList();
			List<LeaveType> leaveNormal = db.LeaveTypes.Where(a => a.IsIncremental == false).ToList();
			List<LeaveHistory> leaveHistories = new List<LeaveHistory>();
			// Loop For Incremental Leave
			if (leaveIncrementals.Count > 0)
			{
				foreach (LeaveType L in leaveIncrementals)
				{
					LeaveHistory leaveHistory = new LeaveHistory();
					leaveHistory.Leave = L.Tags;
					//Count
					for (int i = StartYear; i <= EndYear; i++)
					{

						//Manual CHeck
						var leaveStore = db.LeaveStores.FirstOrDefault(a => a.LeaveTypeId == L.Id && a.EmployeeId == employee.Emp_Id && a.Year == i);
						if (leaveStore != null)
						{
							leaveHistory.Count = leaveHistory.Count + leaveStore.Count;
						}
						//Auto CHeck
						else
						{
							var leaveStore2 = db.LeaveStores.FirstOrDefault(a => a.LeaveTypeId == L.Id && a.IsSingleEmployee == false && a.Year == i);
							if (leaveStore2 != null)
							{
								leaveHistory.Count = leaveHistory.Count + leaveStore2.Count;
							}
						}

					}

					//Spent
					List<Leave> leaves = db.Leaves.Where(a => a.From.Year >= StartYear && a.From.Year <= EndYear && a.LeaveTypeId == L.Id && a.EmployeeId == employee.Emp_Id).ToList();
					leaveHistory.Spent = leaves.Sum(a => a.Count);
					leaveHistory.NotSpent = leaveHistory.Count - leaveHistory.Spent;
					leaveHistories.Add(leaveHistory);
				}

				// Leave Not Spent Count
				int leaveNotSpent = leaveHistories.Sum(a => a.Count) - leaveHistories.Sum(a => a.Spent);
				label7.Text = "Paid Leave Not Spent:"+leaveNotSpent.ToString()+" Day(s)";


			}
			// Loop For Normal Leave
			if (leaveNormal.Count > 0)
			{
				foreach (LeaveType L in leaveNormal)
				{
					LeaveHistory leaveHistory = new LeaveHistory();
					leaveHistory.Leave = L.Tags;
					//Count

					//Manual CHeck
					var leaveStore = db.LeaveStores.FirstOrDefault(a => a.LeaveTypeId == L.Id && a.EmployeeId == employee.Emp_Id && a.Year == EndYear);
					if (leaveStore != null)
					{
						leaveHistory.Count = leaveHistory.Count + leaveStore.Count;
					}
					//Auto CHeck
					else
					{
						var leaveStore2 = db.LeaveStores.FirstOrDefault(a => a.LeaveTypeId == L.Id && a.IsSingleEmployee == false && a.Year == EndYear);
						if (leaveStore2 != null)
						{
							leaveHistory.Count = leaveHistory.Count + leaveStore2.Count;
						}
					}



					//Spent
					List<Leave> leaves = db.Leaves.Where(a => a.From.Year == EndYear && a.LeaveTypeId == L.Id && a.EmployeeId == employee.Emp_Id).ToList();
					leaveHistory.Spent = leaves.Sum(a => a.Count);
					leaveHistory.NotSpent = leaveHistory.Count - leaveHistory.Spent;
					leaveHistories.Add(leaveHistory);
				}
			}

			// Total Count And Spent
			LeaveHistory leaveHistoryTotal = new LeaveHistory();
			leaveHistoryTotal.Leave = "Total";
			leaveHistoryTotal.Count = leaveHistories.Sum(a => a.Count);
			leaveHistoryTotal.Spent = leaveHistories.Sum(a => a.Spent);
			leaveHistoryTotal.NotSpent = leaveHistoryTotal.Count - leaveHistoryTotal.Spent;
			leaveHistories.Add(leaveHistoryTotal);

			dataGridView1.DataSource = leaveHistories.ToList();


		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				GetLeaveHistory();
				BindLeavesBinding();
			}
			catch(Exception)
			{

			}
			
			//leavesBindingSource.Filter = String.Format("From == '{0:yyyy}'", dateTimePicker1.Value.Date.ToString("yyyy"));
		}

		private void companyComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
