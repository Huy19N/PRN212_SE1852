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
    /// Interaction logic for ProductDialog.xaml
    /// </summary>
    public partial class ProductDialog : Window
    {
        public Product Product { get; set; }
        public ProductDialog(Product product, List<Category> categories)
        {
            InitializeComponent();

            cbCategory.ItemsSource = categories;

            if (product != null)
            {
                Product = new Product
                {
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    CategoryID = product.CategoryID,
                    UnitPrice = product.UnitPrice,
                    UnitsInStock = product.UnitsInStock
                };

                txtID.Text = Product.ProductID.ToString();
                txtID.IsEnabled = false;
                txtName.Text = Product.ProductName;
                txtPrice.Text = Product.UnitPrice.ToString();
                txtStock.Text = Product.UnitsInStock.ToString();
                cbCategory.SelectedValue = Product.CategoryID;
            }
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (Product == null) Product = new Product();

            Product.ProductID = int.Parse(txtID.Text);
            Product.ProductName = txtName.Text;
            Product.CategoryID = (int)cbCategory.SelectedValue;
            Product.UnitPrice = int.Parse(txtPrice.Text);
            Product.UnitsInStock = int.Parse(txtStock.Text);

            this.DialogResult = true;
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
