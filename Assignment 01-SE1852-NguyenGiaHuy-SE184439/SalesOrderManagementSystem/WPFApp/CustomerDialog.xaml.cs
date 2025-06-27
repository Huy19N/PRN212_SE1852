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
    /// Interaction logic for CustomerDialog.xaml
    /// </summary>
    public partial class CustomerDialog : Window
    {
        public Customer Customer { get; set; }
        public CustomerDialog(Customer customer)
        {
            InitializeComponent();
            if(customer != null)
            {
                Customer = new Customer
                {
                    CustomerID = customer.CustomerID,
                    CompanyName = customer.CompanyName,
                    ContactName = customer.ContactName,
                    ContactTitle = customer.ContactTitle,
                    Address = customer.Address,
                    Phone = customer.Phone
                };

                txtID.Text = Customer.CustomerID.ToString();
                txtID.IsEnabled = false;
                txtCompany.Text = Customer.CompanyName;
                txtName.Text = Customer.ContactName;
                txtTitle.Text = Customer.ContactTitle;
                txtAddress.Text = Customer.Address;
                txtPhone.Text = Customer.Phone;
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }


        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
