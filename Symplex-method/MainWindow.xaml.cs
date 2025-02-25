using Microsoft.Win32;
using Symplex_method.Views;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
using Utils;

namespace Symplex_method
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        private Storage storage;
        private FileWR fileWR;
        private ConditionsUC conditionsUC = new ConditionsUC();
        private SymplexUC symplexUC = new SymplexUC();
        private GraphicUC graphicUC = new GraphicUC();

        public MainWindow()
		{
			InitializeComponent();
			ConditionsButton_Click(null, null);
            storage = new Storage();
            fileWR = new FileWR(storage);
        }

		private void ConditionsButton_Click(object sender, RoutedEventArgs e)
		{
			ConditionsButton.BorderBrush = SystemColors.ActiveBorderBrush;
			SymplexMethodButton.BorderBrush = SystemColors.InactiveBorderBrush;
			GraphicButton.BorderBrush = SystemColors.InactiveBorderBrush;

            this.OutputView.Content = conditionsUC;
        }

		private void SymplexMethodButton_Click(object sender, RoutedEventArgs e)
		{
			ConditionsButton.BorderBrush = SystemColors.InactiveBorderBrush;
			SymplexMethodButton.BorderBrush = SystemColors.ActiveBorderBrush;
			GraphicButton.BorderBrush = SystemColors.InactiveBorderBrush;

            this.OutputView.Content = symplexUC;
        }

		private void GraphicButton_Click(object sender, RoutedEventArgs e)
		{
			ConditionsButton.BorderBrush = SystemColors.InactiveBorderBrush;
			SymplexMethodButton.BorderBrush = SystemColors.InactiveBorderBrush;
			GraphicButton.BorderBrush = SystemColors.ActiveBorderBrush;

            this.OutputView.Content = graphicUC;
        }

        private void OpenMenuItem_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                storage.FilePath = openFileDialog.FileName;
                if (fileWR.Read() == true)
                {
                    conditionsUC.NewLabel.Content = "Loaded";
                }
                else
                {
                    conditionsUC.NewLabel.Content = "Error 0";
                    return;
                }

                conditionsUC.showTable(storage.StartTable);
            }
        }

        private void SaveMenuItem_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == true)
            {
                storage.FilePath = saveFileDialog.FileName;
                if (fileWR.Write() == true)
                {
                    conditionsUC.NewLabel.Content = "Saved";
                }
                else
                {
                    conditionsUC.NewLabel.Content = "Error 1";
                    return;
                }
            }
        }
    }
}
