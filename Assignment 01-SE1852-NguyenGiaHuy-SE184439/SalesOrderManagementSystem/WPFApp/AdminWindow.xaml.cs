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

namespace WPFApp
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private readonly Employee currentEmployee;
        public AdminWindow(Employee emp)
        {
            InitializeComponent();
            currentEmployee = emp;

            txtWelcome.Text = $"Welcome, {currentEmployee.Name}";
        }

        private void ManageCustomers_Click(object sender, RoutedEventArgs e)
        {
            var customerWindow = new CustomerWindow(null);
            customerWindow.ShowDialog();
        }

        private void ManageProducts_Click(object sender, RoutedEventArgs e)
        {
            var productWindow = new ProductWindow();
            productWindow.ShowDialog();
        }

        private void ManageOrders_Click(object sender, RoutedEventArgs e)
        {
            var orderWindow = new OrderWindow(currentEmployee);
            orderWindow.ShowDialog();
        }

        private void Reports_Click(object sender, RoutedEventArgs e)
        {
            var reportWindow = new ReportWindow();
            reportWindow.ShowDialog();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            var loginWindow = new LoginWindow();
            loginWindow.Show();
            this.Close();
        }

    }
}
