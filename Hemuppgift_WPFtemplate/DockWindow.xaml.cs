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
    /// Interaction logic for DockWindow.xaml
    /// </summary>
    public partial class DockWindow : Window
    {
        public DockWindow()
        {
            InitializeComponent();
        }

        private void Trophy_Click(object sender, RoutedEventArgs e)
        {
            Image newImage = new Image
            {
                Source = new BitmapImage(new Uri("C:\\Users\\artir\\source\\repos\\Newton\\Hemuppgifter\\" +
                "Hemuppgifter_WPF\\Hemuppgift_WPFtemplate\\TrophyImage.jpg")), // Det Gick inte och använda bara Trophy.png här även fast den är i samma fil
                Width = 360,
                Height = 360,
            };
            MainDock.Children.Remove(btnTrophy);
            MainDock.Children.Add(newImage);
        }
    }
}
