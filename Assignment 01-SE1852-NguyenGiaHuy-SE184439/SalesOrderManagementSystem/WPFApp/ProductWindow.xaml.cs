using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
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
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private readonly ProductServices productServices = new();
        private readonly CategoryServices categoryServices = new();
        private List<Product> allProducts;
        private List<Category> allCategories;
        public ProductWindow()
        {
            InitializeComponent();
            categoryServices.InitializeDataset();
            productServices.InitializeDataset();
            LoadData();
        }

        private void LoadData()
        {
            allProducts = productServices.GetALlProducts();
            allCategories = categoryServices.GetAllCategory();

            foreach (var p in allProducts)
            {
                var cat = allCategories.FirstOrDefault(c => c.CategoryID == p.CategoryID);
                p.CategoryName = cat?.CategoryName ?? "N/A";
            }

            dgProducts.ItemsSource = null;
            dgProducts.ItemsSource = allProducts;
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            var result = allProducts
                .Where(p => p.ProductName.ToLower().Contains(keyword))
                .ToList();
            dgProducts.ItemsSource = result;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new ProductDialog(null, allCategories);
            if (dialog.ShowDialog() == true)
            {
                productServices.SaveAllProduct(dialog.Product);
                LoadData();
            }
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var dialog = new ProductDialog(selected, allCategories);
                if (dialog.ShowDialog() == true)
                {
                    productServices.UpdateProduct(dialog.Product);
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }
        }


        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (dgProducts.SelectedItem is Product selected)
            {
                var confirm = MessageBox.Show("Are you sure to delete this product?",
                    "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (confirm == MessageBoxResult.Yes)
                {
                    productServices.DeleteProducts(selected.ProductID);
                    LoadData();
                }
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
