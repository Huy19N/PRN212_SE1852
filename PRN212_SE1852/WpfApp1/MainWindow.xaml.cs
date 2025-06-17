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


namespace RadioButton
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

        private void BtnGui_Click(object sender, RoutedEventArgs e)
        {
            String binhchon = "";
            if(radRatTot.IsChecked == true)
            {
                binhchon = radRatTot.Content + "";
            }
            else if(radTot.IsChecked == true)
            {
                binhchon = radTamDuoc.Content + "";
            }
            else if (radKhongTot.IsChecked == true)
            {
                binhchon = radKhongTot.Content + "";
            }
            string gioiTinh = "";
            if(radNam.IsChecked == true)
            {
                gioiTinh = radNam.Content + "";
            }
            else if(radNu.IsChecked == true)
            {
                gioiTinh = radNu.Content + "";
            }
            string infor = "Bạn bình chọn Hệ Thống=" + binhchon + Environment.NewLine;
            infor += "Giới tính của bạn= " + gioiTinh;
            MessageBoxResult ret;
            ret = MessageBox.Show(infor, "MỜi bạn xác nhận",
                                  MessageBoxButton.YesNo,
                                  MessageBoxImage.Question);
            if(ret == MessageBoxResult.Yes)
            {
                //gui xu ly xac nhan
            }
        }

        private void BtnHuy_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}