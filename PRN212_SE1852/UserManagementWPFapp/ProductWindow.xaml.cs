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

namespace SimpleManagementWPFapp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService = new ProductService();
        public ProductWindow()
        {
            InitializeComponent();
            productService.InitializeDataset();
            lvProduct.ItemsSource = productService.GetAllProducts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
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
        }

        
    }
}
