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

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {

            foreach (UIElement element in MainGrid.Children)
            {
                if (element is Button btn)
                {
                    MainGrid.Children.Remove(btn);
                    break;
                }

            }
            Button button = new Button

            {
                Content = $"Row, {RowInput.Text} Column, {ColumnInput.Text}",
                Background = Brushes.LightGreen
            };

            if (!string.IsNullOrEmpty(RowInput.Text) && !string.IsNullOrEmpty(ColumnInput.Text))
            {
                
                Grid.SetRow(button, Convert.ToInt32(RowInput.Text));
                Grid.SetColumn(button, Convert.ToInt32(ColumnInput.Text));
                
            }
            else
            {
                MessageBox.Show("Please write both Row and Column!", "Invalid Row and Column");
            }

            MainGrid.Children.Add(button);
            RowInput.Clear();
            ColumnInput.Clear();

        }
    }
}
