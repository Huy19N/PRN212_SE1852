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
    /// Interaction logic for ReportWindow.xaml
    /// </summary>
    public partial class ReportWindow : Window
    {
        private readonly IOrderServices orderServices;
        public ReportWindow()
        {
            InitializeComponent();
            orderServices = new OrderServices();
            orderServices.InitializeDataset();
        }

        private void BtnGenerateReport_Click(object sender, RoutedEventArgs e)
        {
            DateTime? fromDate = dpFromDate.SelectedDate;
            DateTime? toDate = dpToDate.SelectedDate;

            if (fromDate == null || toDate == null)
            {
                MessageBox.Show("Please select both From and To dates.");
                return;
            }

            var orders = orderServices.GetAllOrders()
                .Where(o => o.OrderDate.Date >= fromDate.Value.Date && o.OrderDate.Date <= toDate.Value.Date)
                .OrderByDescending(o => o.OrderDate)
                .ToList();

            dgReport.ItemsSource = orders;
        }
    }
}
