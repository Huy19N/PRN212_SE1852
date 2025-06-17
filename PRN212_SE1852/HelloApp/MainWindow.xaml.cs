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

namespace HelloApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePos = e.GetPosition(MainCanvas);
            double x = Canvas.GetLeft(btnEscape);
            double y = Canvas.GetTop(btnEscape);


            double dx = mousePos.X - (x + btnEscape.Width / 2);
            double dy = mousePos.Y - (y + btnEscape.Height / 2);
            double distance = Math.Sqrt(dx * dx + dy * dy);

            if(distance < 100)
            {
                double newx = rand.Next(0, (int)(MainCanvas.ActualWidth - btnEscape.Width));
                double newy = rand.Next(0, (int)(MainCanvas.ActualHeight - btnEscape.Height));
                Canvas.SetLeft(btnEscape, newx);
                Canvas.SetTop(btnEscape, newy);
            }
        }
    }
}