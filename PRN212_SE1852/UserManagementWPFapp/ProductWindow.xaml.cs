using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace SimpleManagementWPFapp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();
        bool isLoaded = false;
        public ProductWindow()
        {
            isLoaded = false;
            InitializeComponent();
            productService.InitializeDataset();
            lvProduct.ItemsSource = productService.GetAllProducts();
            isLoaded = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            isLoaded = false;
            Product p = new Product();
            p.Id = int.Parse(txtMa.Text);
            p.Name = txtTen.Text;
            p.Price = int.Parse(txtgia.Text);
            p.Quantity = int.Parse(txtsoluong.Text);

            bool kq = productService.SaveProduct(p);

            if (kq == true)
            {
                lvProduct.ItemsSource = productService.GetAllProducts();
            }
            isLoaded = true;
        }


        private void txtUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product product = new Product();
                product.Id = int.Parse(txtMa.Text);
                product.Name = txtTen.Text;
                product.Quantity = int.Parse(txtsoluong.Text);
                product.Price = int.Parse(txtgia.Text);
                bool kq = productService.UpdateProduct(product);

                if (kq == true)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetAllProducts();
                }
                else
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error string, please check again!");
            }
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult ret = MessageBoxResult.Yes;
            if(ret == MessageBoxResult.No)
            {
                return;
            }

            try
            {
                isLoaded = false;
                int id = int.Parse(txtMa.Text);
                bool kq = productService.DeleteProduct(id);
                if(kq == true)
                {
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = productService.GetAllProducts();
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtsoluong.Text = "";
                    txtgia.Text = "";
                }
                isLoaded = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Delete, please check again!");
            }

        }

        private void lvProduct_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (isLoaded == false) return;
            if (e.AddedItems.Count < 0)
            {
                return;
            }
            Product p = e.AddedItems[0] as Product;
            txtMa.Text = p.Id.ToString();
            txtTen.Text = p.Name.ToString();
            txtsoluong.Text = p.Quantity.ToString();
            txtgia.Text = p.Price.ToString();
            isLoaded = true;
        }
    }
}
