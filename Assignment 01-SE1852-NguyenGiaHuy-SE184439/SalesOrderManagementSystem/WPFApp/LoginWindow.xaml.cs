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
using BusinessObject;
using Services;

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly CustomerServices customerServices = new();
        private readonly EmployeeServices employeeServices = new();
        public LoginWindow()
        {
            InitializeComponent();
            customerServices.InitializeDataset();
            employeeServices.InitializeDataset();
        }

       
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            String role = (cbRole.SelectedItem as ComboBoxItem)?.Content.ToString();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Password;

            if(role == "Admin")
            {
                var emp = employeeServices.GetAllEmployees().FirstOrDefault(e => 
                e.UserName == username && e.Password == password);

                if(emp != null)
                {
                    MessageBox.Show("Welcome Admin: " + emp.Name);
                    new AdminWindow(emp).Show();
                    this.Close();
                }
                else
                {
                    txtError.Text = "Invaild admin login";
                }
            }
            else
            {
                var cust = customerServices.GetCustomerList().FirstOrDefault(e => e.Phone == username);

                if(cust != null)
                {
                    MessageBox.Show("Welcome customer: " + cust.ContactName);
                    new CustomerWindow(cust).Show();
                    this.Close();
                }
                else
                {
                    txtError.Text = "Invaild phone";
                }
            }
        }
    }
}
