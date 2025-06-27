using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreeViewWpfApp.models;

namespace TreeViewWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, Category> categories = SampleDataset.GenerateDataset();

        public MainWindow()
        {
            InitializeComponent();
            DisplayCategoriesAndProducts();
        }

        private void DisplayCategoriesAndProducts()
        {
            // Delete old data
            tvCategory.Items.Clear();
            // Carete root 
            TreeViewItem root = new TreeViewItem();
            root.Header = "Invenstory Binh Duong";
            tvCategory.Items.Add(root);
            //Insert new Data
            foreach (KeyValuePair<int,Category> cate_kvp in categories)
            {
                Category cate = cate_kvp.Value;
                //Create category node
                TreeViewItem cate_note = new TreeViewItem();
                cate_note.Header = cate;
                // Redirect category node enter root 
                root.Items.Add(cate_note);
                // loop child insert product in category
                foreach(KeyValuePair<int, Product> product_kvp in cate.Products)
                {
                    Product product = product_kvp.Value;
                    TreeViewItem product_note = new TreeViewItem();
                    product_note.Header = product;
                    cate_note.Items.Add(product_note);
                }
            }
        }
    }
}