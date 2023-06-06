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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Order order { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            order = new Order
            {
                FullNameCustomer = "Киселёв Артём",
                StartDate = DateTime.Now,
                orderItems = new List<OrderItem>
                {
                    new OrderItem { NameItem = "Молоко", Cost = 80, Photo = "/Res/Planet9_3840x2160.jpg" },
                    new OrderItem { NameItem = "Масло", Cost = 100, Photo = "/Res/Planet9_3840x2160.jpg" },
                    new OrderItem { NameItem = "Хлеб", Cost = 40, Photo = "/Res/Planet9_3840x2160.jpg" }
                }
            };
            DataContext = this;
            
        }
    }

    public class Order
    {
        public string FullNameCustomer { get; set; }
        public DateTime StartDate { get; set; }
        public List<OrderItem> orderItems { get; set; }
    }
    public class OrderItem
    {
        public string NameItem { get; set; }
        public int Cost { get; set; }
        public string Photo { get; set; }
    }
}
