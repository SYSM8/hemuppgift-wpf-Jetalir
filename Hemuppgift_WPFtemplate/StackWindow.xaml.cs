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
    /// Interaction logic for StackWindow.xaml
    /// </summary>
    public partial class StackWindow : Window
    {
        public StackWindow()
        {
            InitializeComponent();
        }

        private void btnHorizontal_Click(object sender, RoutedEventArgs e)
        {
            SPOrientation.Orientation = Orientation.Horizontal;
        }

        private void btnVertical_Click(object sender, RoutedEventArgs e)
        {
            SPOrientation.Orientation = Orientation.Vertical;
        }
    }
}
