using System;
using static System.Console;
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

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for Login_Window.xaml
    /// </summary>
    public partial class Login_Window : Window
    {
        

        public Login_Window()
        {
            InitializeComponent();
            
                
                athlete testAthlete = new athlete(5, 600, 0001, "Chris", "Fulton", 56);
                App.studentList.Add(testAthlete);
                worker staticWorker = new worker(1, 1245, 0002, "John", "Doe", 12);
                App.studentList.Add(staticWorker);
                
            

        }

      

        public string Username;
        public string UserPassword;
        public string CorrectUsername = "home";
        public string CorrectPassword = "1234";

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            Username = UsernameBox.Text;
            UserPassword = PasswordBox.Text;
            if (Username == CorrectUsername && UserPassword == CorrectPassword)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
            else
            {
                Message.Visibility = Visibility.Visible;
            }
            
        }
        private void uBoxClick(object sender, RoutedEventArgs e)
        {
            UsernameBox.Text = "";
        }

        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void PasswordBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            PasswordBox.Text = "";
        }
       
    }
}
