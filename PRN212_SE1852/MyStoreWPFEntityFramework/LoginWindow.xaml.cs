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
using MyStoreWPFEntityFramework.Models;

namespace MyStoreWPFEntityFramework
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            MyStoreContext context = new MyStoreContext();
            AccountMember am = context.AccountMembers.FirstOrDefault(
                                    x => x.EmailAddress == txtUserName.Text
                                    && x.MemberPassword == txtPassword.Password);
            if(am != null)
            {
                if(am.MemberRole == 1)
                {
                    MessageBox.Show("Login Successfully with Admin");
                    AdminWindow ad = new AdminWindow();
                    ad.Show();
                    Close();
                }
                else if(am.MemberRole == 2)
                {
                    MessageBox.Show("Login Successfully with Staff");
                    AdminWindow ad = new AdminWindow();
                    ad.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Login Successfully with account other");
                }
            }
            else
            {
                MessageBox.Show("Login Fail");
            }
        }
    }
}
