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
using System.Windows.Shapes;

namespace Project_Three_GUI
{
    /// <summary>
    /// Interaction logic for Login_Window.xaml
    /// </summary>
    public partial class Login_Window : Window
    {
        string Username;
        string UserPassword;
        string CorrectUsername = "home";
        string CorrectPassword = "1234";

        public Login_Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Username = UsernameBox.Text;
            UserPassword = PasswordBox.Text;
            if(Username == CorrectUsername || UserPassword == CorrectPassword)
            {
                Console.WriteLine("successful");
            }
            else
            {
                Console.WriteLine("not successful");
            }
        }
    }
}
