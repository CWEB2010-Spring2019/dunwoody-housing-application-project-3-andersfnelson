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

namespace Project_Three_GUI
{
    class GlobalStuff
    {
         public List<student> studentList;

       
    }
    /// <summary>
    /// Interaction logic for ViewStudents.xaml
    /// </summary>
    public partial class ViewStudents : Page
    {
       

        public ViewStudents()
        {
            InitializeComponent();
            //.ToString("D4")
            var _bind = from a in App.studentList
                        select new
                        {
                            idNumber = a.idNumber.ToString("D4"),
                            lastName = a.lastName,
                            firstName = a.firstName,
                            roomNumber = a.roomNumber,
                            monthlyRent = a.monthlyRent,
                            residentFloor = a.residentFloor
                        };
            StudentGrid.ItemsSource = _bind;
        }

        

        private void SearchBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchText = SearchBox.Text;
            var search =
                from a in App.studentList
                where Convert.ToString(a.idNumber) == searchText
                select new
                {
                    idNumber = a.idNumber,
                    lastName = a.lastName,
                    firstName = a.firstName,
                    roomNumber = a.roomNumber,
                    monthlyRent = a.monthlyRent,
                    residentFloor = a.residentFloor
                }; ;
            StudentGrid.ItemsSource = search;

        }

        private void SearchReset_Click(object sender, RoutedEventArgs e)
        {
            SearchBox.Text = "Search by id number (no leading zeros please)";
            var _bind = from a in App.studentList
                        select new
                        {
                            idNumber = a.idNumber.ToString("D4"),
                            lastName = a.lastName,
                            firstName = a.firstName,
                            roomNumber = a.roomNumber,
                            monthlyRent = a.monthlyRent,
                            residentFloor = a.residentFloor
                        };
            StudentGrid.ItemsSource = _bind;
           
        }
    }
}
