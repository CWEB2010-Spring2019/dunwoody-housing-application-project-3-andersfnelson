﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static List<student> studentList = GetStudents();
       
        string searchPlaceholder = "Search by student id";


        public static List<student> GetStudents()
        {
            List<student> studentList = new List<student>();
           

            return studentList;
        }
    }
}
