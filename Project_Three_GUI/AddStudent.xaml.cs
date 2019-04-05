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
                    if (Convert.ToInt32(rentBox.Text) == 1200)
                    {
                        if (Convert.ToInt32(floorBox.Text) == 4 || Convert.ToInt32(floorBox.Text) == 5 || Convert.ToInt32(floorBox.Text) == 6)
                        {

                            App.studentList.Add(new athlete(Convert.ToInt32(floorBox.Text), Convert.ToInt32(rentBox.Text), Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                            MessageBox.Show("New athlete added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Athletes can only reside on floors 4, 5, or 6.\nPlease make sure you have entered a valid floor number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Athletes rent is $1200 per month.\nThe rent will be automatically corrected.");
                        App.studentList.Add(new athlete(Convert.ToInt32(floorBox.Text), 1200, Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                        MessageBox.Show("New athlete added successfully!");
                    }
                }
                //floors 7 and 8
                else if(StudentType.SelectedItem == ScholarshipRecipient)
                {
                    if (Convert.ToInt32(rentBox.Text) == 100)
                    {
                        if (Convert.ToInt32(floorBox.Text) == 7 || Convert.ToInt32(floorBox.Text) == 7)
                        {
                            App.studentList.Add(new scholarshipRecipient(Convert.ToInt32(floorBox.Text), Convert.ToInt32(rentBox.Text), Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                            MessageBox.Show("New scholarship recipient added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Scholarship recipients can only reside on floors 7 or 8.\nPlease make sure you have entered a valid floor number.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Scholarship recipients pay a flat rate of $100 per month.\nThe rent will be automatically corrected.");
                        App.studentList.Add(new scholarshipRecipient(Convert.ToInt32(floorBox.Text), 100, Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                        MessageBox.Show("New scholarship recipient added successfully!");
                    }
                }

                //floors 1/3
                else if (StudentType.SelectedItem == StudentWorker)
                {
                    

                    if (Convert.ToInt32(floorBox.Text) == 1 || Convert.ToInt32(floorBox.Text) == 2 || Convert.ToInt32(floorBox.Text) == 3)
                    {

                        App.studentList.Add(new worker(Convert.ToInt32(floorBox.Text), Convert.ToDouble(rentBox.Text), Convert.ToInt32(idBox.Text), fnameBox.Text, lnameBox.Text, Convert.ToInt32(roomNumBox.Text)));
                        
                        MessageBox.Show("New student worker added successfully!\nThe student's rent was automatically calculated based on their hours worked.");
                    }
                    else
                    {
                        MessageBox.Show("Workers can only reside on floors 1, 2, or 3.\nPlease make sure you have entered a valid floor number.");
                    }

                }
            }
            catch
            {
                MessageBox.Show("An unknown error occured. Make sure all fields have been filled in correctly.");
            }
        }

        private void SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(StudentType.SelectedItem == ScholarshipRecipient)
            {
                rentBox.Text = "100";
            }
            else if(StudentType.SelectedItem == Athlete)
            {
                rentBox.Text = "1200";
            }
            else if(StudentType.SelectedItem == StudentWorker)
            {
                rentBlock.Text = "Hours Worked";
                
            }
            //Need to implement worker logic
        }
    }
}
