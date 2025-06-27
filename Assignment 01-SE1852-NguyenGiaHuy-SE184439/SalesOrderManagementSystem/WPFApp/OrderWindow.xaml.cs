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
    /// Interaction logic for OrderWindow.xaml
    /// </summary>
    public partial class OrderWindow : Window
    {
        private readonly CustomerServices customerServices = new();
        private readonly ProductServices productServices = new();
        private readonly OrderServices orderServices = new();
        private readonly OrderDetailServices orderDetailServices = new();
        private Employee currentEmployee;

        private List<Customer> customers;
        private List<Product> products;
        private List<OrderDetail> orderDetails = new();
        public OrderWindow(Employee e)
        {
            InitializeComponent();

            customerServices.InitializeDataset();
            productServices.InitializeDataset();
            orderServices.InitializeDataset();
            orderDetailServices.InitializeDataset();

            customers = customerServices.GetCustomerList();
            products = productServices.GetALlProducts();

            cbCustomer.ItemsSource = customers;
            dpOrderDate.SelectedDate = DateTime.Now;

            dgOrderDetails.ItemsSource = orderDetails;
            dgOrderDetails.CellEditEnding += DgOrderDetails_CellEditEnding;

            var productColumn = dgOrderDetails.Columns[0] as DataGridComboBoxColumn;
            productColumn.ItemsSource = products;
            currentEmployee = e;
            Title = $"Order Window - Welcome {currentEmployee.Name}";
        }

        private void DgOrderDetails_CellEditEnding(object? sender, DataGridCellEditEndingEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                foreach (var item in orderDetails)
                {
                    var product = products.FirstOrDefault(p => p.ProductID == item.ProductID);
                    item.UnitPrice = product?.UnitPrice ?? 0;
                    item.Total = (int)(item.UnitPrice * item.Quantity * (1 - (decimal)item.Discount / 100m));
                }

                dgOrderDetails.Items.Refresh();
            }), System.Windows.Threading.DispatcherPriority.Background);
        }

        private void SaveOrder_Click(object sender, RoutedEventArgs e)
        {
            if (cbCustomer.SelectedValue == null || dpOrderDate.SelectedDate == null || orderDetails.Count == 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            int newOrderId = orderServices.GetNextOrderID();
            int customerId = (int)cbCustomer.SelectedValue;

            var order = new Order
            {
                OrderID = newOrderId,
                CustomerID = customerId,
                EmployeeID = 1,
                OrderDate = dpOrderDate.SelectedDate.Value
            };

            orderServices.SaveOrder(order);

            foreach (var detail in orderDetails)
            {
                var orderDetail = new OrderDetail
                {
                    OrderID = newOrderId,
                    ProductID = detail.ProductID,
                    Quantity = detail.Quantity,
                    UnitPrice = detail.UnitPrice,
                    Discount = detail.Discount
                };
                orderDetailServices.SaveOrderDetail(orderDetail);
            }

            MessageBox.Show("Order saved successfully.");
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // Đóng cửa sổ
        }

    }
}
