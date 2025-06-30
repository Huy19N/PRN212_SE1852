using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        MyStoreContext context = new MyStoreContext();

        public AdminWindow()
        {
            InitializeComponent();
            DisplayCategoryandProduct();
        }

        private void DisplayCategoryandProduct()
        {
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho HCM";
            tvCategory.Items.Add(root);

            //Approve loop 
            var categories = context.Categories;
            foreach ( var category in categories )
            {
                TreeViewItem cate_note = new TreeViewItem();
                cate_note.Header = "Category";
                cate_note.Tag = category;
                root.Items.Add(cate_note);
                // Approve loop product of Category
                var products = context.Products.Where(x => x.CategoryId == category.CategoryId).ToList();
                foreach(var product in category.Products)
                {
                    TreeViewItem pro_note = new TreeViewItem();
                    pro_note.Header = product.ProductName;
                    pro_note.Tag = product;
                    root.Items.Add(pro_note);
                }

            }
            root.ExpandSubtree();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem item = e.NewValue as TreeViewItem;
            if(item != null)
            {
                Category category = item.Tag as Category;
                if(category != null)
                {
                    //Add list product up load on Listview display 
                    var products = context.Products.Where(x => x.CategoryId == category.CategoryId).ToList();
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }
            }
        }
    }
}
