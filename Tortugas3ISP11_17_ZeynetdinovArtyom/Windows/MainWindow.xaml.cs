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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tortugas3ISP11_17_ZeynetdinovArtyom.Windows;
using Menu = Tortugas3ISP11_17_ZeynetdinovArtyom.Windows.Menu;

namespace Tortugas3ISP11_17_ZeynetdinovArtyom
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Table1_Click(object sender, RoutedEventArgs e)
        {
            Menu mainWindow = new Menu();
            mainWindow.Show();
            this.Close();
        }

        private void Table2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table5_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table6_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table7_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table9_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table8_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table9_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Table11_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Table10_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
