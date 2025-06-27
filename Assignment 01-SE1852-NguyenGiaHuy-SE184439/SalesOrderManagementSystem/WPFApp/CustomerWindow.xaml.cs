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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        private readonly CustomerServices customerServices = new();
        private List<Customer> allCustomers;

        private Customer customer;
        public CustomerWindow(Customer cust)
        {
            InitializeComponent();
            customerServices.InitializeDataset();
            LoadCustomerList();

            customer = cust;
            if (cust != null)
            {
                Title = $"Customer - Welcome {cust.CustomerID}";
            }
            else
            {
                Title = "Customer - Add New";
            }

        }

        private void LoadCustomerList()
        {
            allCustomers = customerServices.GetCustomerList();
            dgCustomers.ItemsSource = null;
            dgCustomers.ItemsSource = allCustomers;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var result = allCustomers
                         .Where(c => c.ContactName.ToLower().Contains(keyword) ||
                                     c.CompanyName.ToLower().Contains(keyword))
                         .ToList();
            dgCustomers.ItemsSource = result;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CustomerDialog(null);
            if (dialog.ShowDialog() == true)
            {
                customerServices.SaveCustomer(dialog.Customer);
                LoadCustomerList();
            }
        }


        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is Customer selected)
            {
                var dialog = new CustomerDialog(selected);
                if (dialog.ShowDialog() == true)
                {
                    customerServices.UpdateCustomer(dialog.Customer);
                    LoadCustomerList();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to edit.");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dgCustomers.SelectedItem is Customer selected)
            {
                var confirm = MessageBox.Show("Are you sure to delete this customer?",
                    "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (confirm == MessageBoxResult.Yes)
                {
                    customerServices.DeleteCustomer(selected.CustomerID);
                    LoadCustomerList();
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
