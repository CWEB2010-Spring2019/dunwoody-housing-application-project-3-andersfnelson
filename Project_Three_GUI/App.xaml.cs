using System;
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



        public static List<student> GetStudents()
        {
            List<student> studentList = new List<student>();
            athlete testAthlete = new athlete(4, 600, 0001, "Anders", "Nelson", 56);
            studentList.Add(testAthlete);
            return studentList;
        }
    }
}
