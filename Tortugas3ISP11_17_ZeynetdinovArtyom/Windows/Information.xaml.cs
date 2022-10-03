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
        BD.Product editProduct = new BD.Product();
        public Information(BD.Product product)
        {
            InitializeComponent();

            editProduct = product;

        }

        public Information()
        {
            InitializeComponent();

            editProduct.NameProduct = Convert.ToString(NameProduct.Content);
            editProduct.Cost = Convert.ToDecimal(CostProduct.Content);
            editProduct.Description = DescriptionProduct.Text;
            editProduct.Photo = Convert.ToString(ImageProduct.Source);
        }
     }
}
