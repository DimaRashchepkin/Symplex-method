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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Utils;

namespace Symplex_method.Views
{
	/// <summary>
	/// Interaction logic for ConditionsUC.xaml
	/// </summary>
	public partial class ConditionsUC : UserControl
	{
		public ConditionsUC()
		{
			InitializeComponent();
		}

		private void SaveButton_Click(object sender, RoutedEventArgs e)
		{

		}

		public void showTable(StartTable table)
		{
			for (int j = 1; j < table.J + 1; j++)
			{
				DataGridTextColumn column = new DataGridTextColumn();
				column.Header = "x" + j.ToString();
				ConditionsDataGrid.Columns.Add(column);

			}

			for (int i = 0; i <= table.I; i++)
			{
				DataGridRow row = new DataGridRow();
				row.Header = "f" + i.ToString();
			}

			ConditionsDataGrid.ItemsSource = new List<double[]> { table.Function };
		}
	}
}
