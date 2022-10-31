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
using Tortugas3ISP11_17_ZeynetdinovArtyom.BD;
using Tortugas3ISP11_17_ZeynetdinovArtyom.ClassHelper;

namespace Tortugas3ISP11_17_ZeynetdinovArtyom.Windows
{
    /// <summary>
    /// Логика взаимодействия для Order.xaml
    /// </summary>
    public partial class Order : Window
    {
        List<ProductOrder> orderList = new List<ProductOrder>();
        public Order()
        {
            InitializeComponent();

            listOrder.ItemsSource = AppData.Context.ProductOrder.ToList();
        }

        private void Payment_Click(object sender, RoutedEventArgs e)
        {
            Expectation expectationWindow = new Expectation();
            expectationWindow.Show();
            this.Close();
        }
    }
}
