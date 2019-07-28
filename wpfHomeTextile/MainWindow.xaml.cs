using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace wpfHomeTextile
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{

			wpfHomeTextile.HomeTextileDBDataSet homeTextileDBDataSet = ((wpfHomeTextile.HomeTextileDBDataSet)(this.FindResource("homeTextileDBDataSet")));
			// Load data into the table SalaryGrades. You can modify this code as needed.
			wpfHomeTextile.HomeTextileDBDataSetTableAdapters.SalaryGradesTableAdapter homeTextileDBDataSetSalaryGradesTableAdapter = new wpfHomeTextile.HomeTextileDBDataSetTableAdapters.SalaryGradesTableAdapter();
			homeTextileDBDataSetSalaryGradesTableAdapter.Fill(homeTextileDBDataSet.SalaryGrades);
			System.Windows.Data.CollectionViewSource salaryGradesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("salaryGradesViewSource")));
			salaryGradesViewSource.View.MoveCurrentToFirst();
		}
	}
}
