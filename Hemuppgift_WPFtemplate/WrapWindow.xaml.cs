﻿using System;
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
    /// Interaction logic for WrapWindow.xaml
    /// </summary>
    public partial class WrapWindow : Window
    {
        public WrapWindow()
        {
            InitializeComponent();
        }

        private void btnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            WPOrientation.Orientation = Orientation.Horizontal;
        }

        private void btnVertical_Click(object sender, RoutedEventArgs e)
        {
            WPOrientation.Orientation = Orientation.Vertical;
        }
    }
}
