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

namespace CheckBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChkToanBo_Checked(object sender, RoutedEventArgs e)
        {
            chkCOngNghe.IsChecked = true;
            chkDulich.IsChecked = true;
            chkDabong.IsChecked = true;
            chkXemPhim.IsChecked = true;
        }

        private void ChkToanBo_Unchecked(object sender, RoutedEventArgs e)
        {
            chkCOngNghe.IsChecked = false;
            chkDulich.IsChecked = false;
            chkDabong.IsChecked = false;
            chkXemPhim.IsChecked = false;
        }

        private void chkSub_CheckedChanged(object sender, RoutedEventArgs e)
        {
            if (chkCOngNghe.IsChecked == true && chkDulich.IsChecked == true && chkDabong.IsChecked == true && chkXemPhim.IsChecked == true)
            {
                chkToanBo.IsChecked = true;
            }
            else if(chkCOngNghe.IsChecked == false && chkDulich.IsChecked == false && chkDabong.IsChecked == false && chkXemPhim.IsChecked == false)
            {
                chkToanBo.IsChecked = false;
            }
        }

    }
}