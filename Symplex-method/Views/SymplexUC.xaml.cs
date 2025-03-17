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
    /// Interaction logic for SymplexUC.xaml
    /// </summary>
    public partial class SymplexUC : UserControl
    {
        public Storage storage = new Storage();

        public SymplexUC()
        {
            InitializeComponent();
        }

        public void ShowTable(StartTable table)
        {
            // for (int J = 1; J < table.J + 1; J++)
            // {
            // 	DataGridTextColumn column = new DataGridTextColumn();
            // 	column.Header = "x" + J.ToString();
            // 	ConditionsDataGrid.Columns.Add(column);
            // 
            // }

            // restrictions.Clear();
            // for (int I = 0; I < RestComboBox.SelectedIndex + 1; I++)
            // {
            //     restrictions.Add(new TableLine());
            // }
            // FunctionDataGrid.ItemsSource = lines;
            // ConditionsDataGrid.ItemsSource = restrictions;

            // ConditionsDataGrid;
        }

        private void SolveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ForwardButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
