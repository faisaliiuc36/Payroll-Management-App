using HomeTextileApp.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class ImportEmployee : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public ImportEmployee()
		{
			InitializeComponent();
		}

		private void ImportEmployee_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet2.Employees' table. You can move, or remove it, as needed.

			GetEmployee();
		}

		private void GetEmployee()
		{
			List<Employee> employees = new List<Employee>();





			string connectionString = @"Data Source=10.10.0.84\SQLEXPRESS;Initial Catalog=SaadMusaAttendance;Persist Security Info=True;User ID=sa;Password=SM3xpress20";
			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select userid,badgenumber, name from userinfo where Reject= 0";

			SqlCommand command = new SqlCommand(query, connection);

			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					Employee emp = new Employee();
					emp.Emp_Id = (int)reader["userid"];
					emp.BadgeNumber = reader["badgenumber"].ToString();
					emp.EmpFullName = reader["name"].ToString();
					emp.InsertDate = DateTime.Now;


					//Check UserId

					var IsEmployeeExist = db.Employees.FirstOrDefault(a => a.Emp_Id == emp.Emp_Id);

					//var ISUserIdExist

					if (IsEmployeeExist == null)
					{
						employees.Add(emp);
					}

				}
			}

			reader.Close();
			connection.Close();




			List<Employee> employees2 = employees.Where(a => a.BadgeNumber.StartsWith("100000")).ToList();



			employeesDataGridView.DataSource = employees2.ToList();
			employeesDataGridView1.DataSource = db.Employees.ToList();

		}

		private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.employeesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void employeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(e.ColumnIndex==33)
			{

				//MessageBox.Show(this.employeesDataGridView.CurrentRow.Cells[1].Value.ToString());
				var emp =employeesDataGridView.CurrentRow;

				Employee employee= (Employee)emp.DataBoundItem;


				db.Employees.Add(employee);
				db.SaveChanges();

				GetEmployee();
				
			}
		}
	}
}
