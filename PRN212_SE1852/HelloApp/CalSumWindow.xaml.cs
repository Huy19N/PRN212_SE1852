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

namespace HelloApp
{
    /// <summary>
    /// Interaction logic for CalSumWindow.xaml
    /// </summary>
    public partial class CalSumWindow : Window
    {
        public CalSumWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Sum_result_Click(object sender, RoutedEventArgs e)
        {
            int a = int.Parse(Num1.Text);
            int b = int.Parse(Num2.Text);
            int sum = a + b;
            Sum.Text = sum +"";
        }
    }
}
