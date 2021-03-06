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

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            this.NavigationService.Navigate(addStudent);
        }

        private void ViewButton_Click(object sender, RoutedEventArgs e)
        {
            ViewStudents viewStudents = new ViewStudents();
            this.NavigationService.Navigate(viewStudents);
        }
    }
}
