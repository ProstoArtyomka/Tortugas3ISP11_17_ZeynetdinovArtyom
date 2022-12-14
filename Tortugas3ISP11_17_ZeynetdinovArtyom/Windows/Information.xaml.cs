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

namespace Tortugas3ISP11_17_ZeynetdinovArtyom.Windows
{
    /// <summary>
    /// Логика взаимодействия для Information.xaml
    /// </summary>
    public partial class Information : Window
    {
        BD.Product editProd = new BD.Product();
        int ProductCount = 1;
        public Information(BD.Product editProduct)
        {
            InitializeComponent();
            editProd = editProduct;

            NameProduct.Content = editProd.NameProduct;
            CostProduct.Content = editProd.Cost;
            DescriptionProduct.Text = editProd.Description;

            Image myImage = new Image();
            BitmapImage bit = new BitmapImage();
            bit.BeginInit();
            bit.UriSource = new Uri(editProd.Photo, UriKind.Relative);
            bit.EndInit();
            myImage.Stretch = Stretch.Fill;
            myImage.Source = bit;
            ImageProduct.Source = bit;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            CountProduct.Text = Convert.ToString(ProductCount++);
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            CountProduct.Text = Convert.ToString(ProductCount--);
        }
    }
}
