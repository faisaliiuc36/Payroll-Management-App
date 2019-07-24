using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTextileApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			try 
				{
				Bitmap B = new Bitmap(pictureBox1.Image);
				string p = DateTime.Now.Year.ToString()+ DateTime.Now.Month.ToString()+ DateTime.Now.Hour.ToString()+ DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString()+ DateTime.Now.Millisecond.ToString();
				string path= Path.GetDirectoryName(Application.StartupPath).Replace(@"\bin", string.Empty);
				B.Save(path + @"\EmployeeImage\" + p);
				imagePathTextBox.Text =p;
			}
			catch ( Exception E)
			{
				MessageBox.Show(E.ToString());
			}
			
		
			this.Validate();
			this.employeesBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.homeTextileDBDataSet);

		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.Genders' table. You can move, or remove it, as needed.
			this.gendersTableAdapter.Fill(this.homeTextileDBDataSet.Genders);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.Designations' table. You can move, or remove it, as needed.
			this.designationsTableAdapter.Fill(this.homeTextileDBDataSet.Designations);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.MaritialStatus' table. You can move, or remove it, as needed.
			this.maritialStatusTableAdapter.Fill(this.homeTextileDBDataSet.MaritialStatus);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.Religions' table. You can move, or remove it, as needed.
			this.religionsTableAdapter.Fill(this.homeTextileDBDataSet.Religions);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.BloodGroups' table. You can move, or remove it, as needed.
			this.bloodGroupsTableAdapter.Fill(this.homeTextileDBDataSet.BloodGroups);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.Sections' table. You can move, or remove it, as needed.
			this.sectionsTableAdapter.Fill(this.homeTextileDBDataSet.Sections);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.Companies' table. You can move, or remove it, as needed.
			this.companiesTableAdapter.Fill(this.homeTextileDBDataSet.Companies);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.EmployeeTypes' table. You can move, or remove it, as needed.
			this.employeeTypesTableAdapter.Fill(this.homeTextileDBDataSet.EmployeeTypes);
			// TODO: This line of code loads data into the 'homeTextileDBDataSet.Employees' table. You can move, or remove it, as needed.
			this.employeesTableAdapter.Fill(this.homeTextileDBDataSet.Employees);

		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog opnfd = new OpenFileDialog();
			opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
			if (opnfd.ShowDialog() == DialogResult.OK)
			{

			
				pictureBox1.Image = new Bitmap(opnfd.FileName);
			}
		}
		private Image GetCompressedBitmap(Bitmap bmp, long quality)
		{
			using (var mss = new MemoryStream())
			{
				EncoderParameter qualityParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
				ImageCodecInfo imageCodec = ImageCodecInfo.GetImageEncoders().FirstOrDefault(o => o.FormatID == ImageFormat.Jpeg.Guid);
				EncoderParameters parameters = new EncoderParameters(1);
				parameters.Param[0] = qualityParam;
				bmp.Save(mss, imageCodec, parameters);
				return Image.FromStream(mss);
			}
		}

		private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
		{

		}

		private void employeesBindingSource_CurrentChanged(object sender, EventArgs e)
		{

		}
	}
}
