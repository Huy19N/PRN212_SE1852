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

namespace HelloApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void txtExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void txtLogin_Click(object sender, RoutedEventArgs e)
        {
            //account
            //if username is huy and pass is 123
            //then enter in window
            if(txtUsername.Text == "huy" && txtPassword.Password == "123")
            {
                MainWindow mw = new MainWindow();
                mw.Show();
                Close();
            }
            else
            {
                Console.WriteLine("Error Username and password");
                Close();
            }
        }
    }
}
