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
	public partial class ImportAttendance : Form
	{
		private DatabaseContext db = new DatabaseContext();
		public ImportAttendance()
		{
			InitializeComponent();
		}

		private void emp_CheckInOutBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.emp_CheckInOutBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet2);

		}

		private void ImportAttendance_Load(object sender, EventArgs e)
		{
			GetEmployeeCheckInOut();
		}

		private void GetEmployeeCheckInOut()
		{
			List<Emp_CheckInOut> emp_CheckInOuts = new List<Emp_CheckInOut>();
			List<Emp_CheckInOut> emp_CheckInOuts2 = new List<Emp_CheckInOut>();





			string connectionString = @"Data Source=10.10.0.84\SQLEXPRESS;Initial Catalog=SecurityAttendanceDB;Persist Security Info=True;User ID=sa;Password=SM3xpress20";
			SqlConnection connection = new SqlConnection(connectionString);

			string query = "select userid, checktime, logid, machineid from SaadMusaAttendance.dbo.CHECKINOUT where SaadMusaAttendance.dbo.CHECKINOUT.LOGID not in (select logid from Emp_CheckInOut) And SaadMusaAttendance.dbo.CHECKINOUT.USERID in (select Emp_Id from Employees)";


			SqlCommand command = new SqlCommand(query, connection);

			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					Emp_CheckInOut emp_CheckInOut = new Emp_CheckInOut();
					emp_CheckInOut.UserId = (int)reader["userid"];
					emp_CheckInOut.CHECKTIME = Convert.ToDateTime(reader["checktime"]);
					emp_CheckInOut.LOGID = (int)reader["logid"];
					//emp_CheckInOut.MACHINEID =(int?) reader["MachineId"];


					emp_CheckInOut.UpdatedBy = "Machine";
					emp_CheckInOuts.Add(emp_CheckInOut);



				}
			}

			reader.Close();
			connection.Close();






			emp_CheckInOutDataGridView.DataSource = emp_CheckInOuts;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var emp = emp_CheckInOutDataGridView.DataSource;

			List<Emp_CheckInOut> emp_CheckInOuts = (List<Emp_CheckInOut>)emp;


			db.Emp_CheckInOuts.AddRange(emp_CheckInOuts);
			db.SaveChanges();

			GetEmployeeCheckInOut();
		}
	}
}
