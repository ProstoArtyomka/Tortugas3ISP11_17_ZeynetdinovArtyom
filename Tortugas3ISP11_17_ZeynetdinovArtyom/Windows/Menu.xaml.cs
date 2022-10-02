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
using Tortugas3ISP11_17_ZeynetdinovArtyom.ClassHelper;
using Tortugas3ISP11_17_ZeynetdinovArtyom.BD;

namespace Tortugas3ISP11_17_ZeynetdinovArtyom.Windows
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        List<Product> productList = new List<Product>();

        public Menu()
        {
            InitializeComponent();

            listProduct.ItemsSource = AppData.Context.Product.ToList();
        }

        private void Burger_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Pizza_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Drink_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Snack_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Salad_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            Order mainWindow = new Order();
            mainWindow.Show();
            this.Close();
        }
    }
}
