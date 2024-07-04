﻿using PagesPractice.Pages;
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

namespace PagesPractice
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Page1 FirstPage;
        public Page2 SecondPage;

        public MainWindow()
        {
            InitializeComponent();

            FirstPage = new Page1();
            SecondPage = new Page2();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = FirstPage;
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainWindowFrame.Content = SecondPage;
        }
    }
}
