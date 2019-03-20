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
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Page
    {
        List<student> studentList;
        public AddStudent()
        {
            InitializeComponent();
            GlobalStuff anInstance = new GlobalStuff();
            
        }

        private void View_btn_Click(object sender, RoutedEventArgs e)
        {
            ViewStudents viewStudents = new ViewStudents();
            this.NavigationService.Navigate(viewStudents);
        }

        private void Add_btn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (StudentType.SelectedItem == Athlete)
                {
                    App.studentList.Add(new athlete(Convert.ToInt32(floorBox.Text), Convert.ToInt32(rentBox.Text), Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                    MessageBox.Show("New athlete added successfully!");
                }
                else if(StudentType.SelectedItem == ScholarshipRecipient)
                {
                    
                        App.studentList.Add(new scholarshipRecipient(Convert.ToInt32(floorBox.Text), Convert.ToInt32(rentBox.Text), Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                        MessageBox.Show("New scholarship recipient added successfully!");
                    
                }
                else if (StudentType.SelectedItem == StudentWorker)
                {
                    App.studentList.Add(new worker(Convert.ToInt32(floorBox.Text), Convert.ToInt32(rentBox.Text), Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                    MessageBox.Show("New student worker added successfully!");
                }
            }
            catch
            {
                MessageBox.Show("Oops, that didn't work.");
            }
        }
    }
}
