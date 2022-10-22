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
        public Information(BD.Product editProduct)
        {
            InitializeComponent();

            editProd = editProduct;

            NameProduct.Content = editProd.NameProduct;
            CostProduct.Content = editProd.Cost;
            DescriptionProduct.Text = editProd.Description;

            //Image ImageProduct = new Image();
            //BitmapImage photo = new BitmapImage();
            //photo.BeginInit();
            //photo.UriSource = new Uri(editProd.Photo);
            //photo.EndInit();
            //ImageProduct.Source = photo;
        }
     }
}
