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

            Filter();
        }

        private void Filter()
        {
            productList = AppData.Context.Product.ToList();
        }

        private void Burger_Click(object sender, RoutedEventArgs e)
        {
            Image myImage1 = new Image();
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/ImageMenu/OFF/PizzaOFF.png", UriKind.Relative);
            bi1.EndInit();
            myImage1.Stretch = Stretch.Fill;
            myImage1.Source = bi1;
            PizzaPhoto.Source = bi1;

            Image myImage2 = new Image();
            BitmapImage bi2 = new BitmapImage();
            bi2.BeginInit();
            bi2.UriSource = new Uri("/ImageMenu/OFF/DrinkOFF.png", UriKind.Relative);
            bi2.EndInit();
            myImage2.Stretch = Stretch.Fill;
            myImage2.Source = bi2;
            DrinkPhoto.Source = bi2;

            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("/ImageMenu/OFF/SaladOFF.png", UriKind.Relative);
            bi3.EndInit();
            myImage3.Stretch = Stretch.Fill;
            myImage3.Source = bi3;
            SaladPhoto.Source = bi3;

            Image myImage4 = new Image();
            BitmapImage bi4 = new BitmapImage();
            bi4.BeginInit();
            bi4.UriSource = new Uri("/ImageMenu/OFF/SnackOFF.png", UriKind.Relative);
            bi4.EndInit();
            myImage4.Stretch = Stretch.Fill;
            myImage4.Source = bi4;
            SnackPhoto.Source = bi4;

            Image myImage5 = new Image();
            BitmapImage bi5 = new BitmapImage();
            bi5.BeginInit();
            bi5.UriSource = new Uri("/ImageMenu/ON/BurgerON.png", UriKind.Relative);
            bi5.EndInit();
            myImage5.Stretch = Stretch.Fill;
            myImage5.Source = bi5;
            BurgerPhoto.Source = bi5;

            Titles.Content = "Бургеры";

            productList = AppData.Context.Product.ToList();
            productList = productList.Where(i => i.IDCategoryProduct == 1).ToList();
            listProduct.ItemsSource = productList;
        }

        private void Pizza_Click(object sender, RoutedEventArgs e)
        {
            Image myImage1 = new Image();
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/ImageMenu/OFF/BurgerOFF.png", UriKind.Relative);
            bi1.EndInit();
            myImage1.Stretch = Stretch.Fill;
            myImage1.Source = bi1;
            BurgerPhoto.Source = bi1;

            Image myImage2 = new Image();
            BitmapImage bi2 = new BitmapImage();
            bi2.BeginInit();
            bi2.UriSource = new Uri("/ImageMenu/OFF/DrinkOFF.png", UriKind.Relative);
            bi2.EndInit();
            myImage2.Stretch = Stretch.Fill;
            myImage2.Source = bi2;
            DrinkPhoto.Source = bi2;

            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("/ImageMenu/OFF/SaladOFF.png", UriKind.Relative);
            bi3.EndInit();
            myImage3.Stretch = Stretch.Fill;
            myImage3.Source = bi3;
            SaladPhoto.Source = bi3;

            Image myImage4 = new Image();
            BitmapImage bi4 = new BitmapImage();
            bi4.BeginInit();
            bi4.UriSource = new Uri("/ImageMenu/OFF/SnackOFF.png", UriKind.Relative);
            bi4.EndInit();
            myImage4.Stretch = Stretch.Fill;
            myImage4.Source = bi4;
            SnackPhoto.Source = bi4;

            Image myImage5 = new Image();
            BitmapImage bi5 = new BitmapImage();
            bi5.BeginInit();
            bi5.UriSource = new Uri("/ImageMenu/ON/PizzaON.png", UriKind.Relative);
            bi5.EndInit();
            myImage5.Stretch = Stretch.Fill;
            myImage5.Source = bi5;
            PizzaPhoto.Source = bi5;

            Titles.Content = "Пиццы";

            productList = AppData.Context.Product.ToList();
            productList = productList.Where(i => i.IDCategoryProduct == 2).ToList();
            listProduct.ItemsSource = productList;
        }

        private void Drink_Click(object sender, RoutedEventArgs e)
        {
            Image myImage1 = new Image();
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/ImageMenu/OFF/BurgerOFF.png", UriKind.Relative);
            bi1.EndInit();
            myImage1.Stretch = Stretch.Fill;
            myImage1.Source = bi1;
            BurgerPhoto.Source = bi1;

            Image myImage2 = new Image();
            BitmapImage bi2 = new BitmapImage();
            bi2.BeginInit();
            bi2.UriSource = new Uri("/ImageMenu/OFF/PizzaOFF.png", UriKind.Relative);
            bi2.EndInit();
            myImage2.Stretch = Stretch.Fill;
            myImage2.Source = bi2;
            PizzaPhoto.Source = bi2;

            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("/ImageMenu/OFF/SaladOFF.png", UriKind.Relative);
            bi3.EndInit();
            myImage3.Stretch = Stretch.Fill;
            myImage3.Source = bi3;
            SaladPhoto.Source = bi3;

            Image myImage4 = new Image();
            BitmapImage bi4 = new BitmapImage();
            bi4.BeginInit();
            bi4.UriSource = new Uri("/ImageMenu/OFF/SnackOFF.png", UriKind.Relative);
            bi4.EndInit();
            myImage4.Stretch = Stretch.Fill;
            myImage4.Source = bi4;
            SnackPhoto.Source = bi4;

            Image myImage5 = new Image();
            BitmapImage bi5 = new BitmapImage();
            bi5.BeginInit();
            bi5.UriSource = new Uri("/ImageMenu/ON/DrinkON.png", UriKind.Relative);
            bi5.EndInit();
            myImage5.Stretch = Stretch.Fill;
            myImage5.Source = bi5;
            DrinkPhoto.Source = bi5;
            Titles.Content = "Напитки";

            productList = AppData.Context.Product.ToList();
            productList = productList.Where(i => i.IDCategoryProduct == 3).ToList();
            listProduct.ItemsSource = productList;
        }

        private void Snack_Click(object sender, RoutedEventArgs e)
        {
            Image myImage1 = new Image();
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/ImageMenu/OFF/BurgerOFF.png", UriKind.Relative);
            bi1.EndInit();
            myImage1.Stretch = Stretch.Fill;
            myImage1.Source = bi1;
            BurgerPhoto.Source = bi1;

            Image myImage2 = new Image();
            BitmapImage bi2 = new BitmapImage();
            bi2.BeginInit();
            bi2.UriSource = new Uri("/ImageMenu/OFF/PizzaOFF.png", UriKind.Relative);
            bi2.EndInit();
            myImage2.Stretch = Stretch.Fill;
            myImage2.Source = bi2;
            PizzaPhoto.Source = bi2;

            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("/ImageMenu/OFF/SaladOFF.png", UriKind.Relative);
            bi3.EndInit();
            myImage3.Stretch = Stretch.Fill;
            myImage3.Source = bi3;
            SaladPhoto.Source = bi3;

            Image myImage4 = new Image();
            BitmapImage bi4 = new BitmapImage();
            bi4.BeginInit();
            bi4.UriSource = new Uri("/ImageMenu/OFF/DrinkOFF.png", UriKind.Relative);
            bi4.EndInit();
            myImage4.Stretch = Stretch.Fill;
            myImage4.Source = bi4;
            DrinkPhoto.Source = bi4;

            Image myImage5 = new Image();
            BitmapImage bi5 = new BitmapImage();
            bi5.BeginInit();
            bi5.UriSource = new Uri("/ImageMenu/ON/SnackON.png", UriKind.Relative);
            bi5.EndInit();
            myImage5.Stretch = Stretch.Fill;
            myImage5.Source = bi5;
            SnackPhoto.Source = bi5;

            Titles.Content = "Закуски";

            productList = AppData.Context.Product.ToList();
            productList = productList.Where(i => i.IDCategoryProduct == 4).ToList();
            listProduct.ItemsSource = productList;
        }

        private void Salad_Click(object sender, RoutedEventArgs e)
        {
            Image myImage1 = new Image();
            BitmapImage bi1 = new BitmapImage();
            bi1.BeginInit();
            bi1.UriSource = new Uri("/ImageMenu/OFF/BurgerOFF.png", UriKind.Relative);
            bi1.EndInit();
            myImage1.Stretch = Stretch.Fill;
            myImage1.Source = bi1;
            BurgerPhoto.Source = bi1;

            Image myImage2 = new Image();
            BitmapImage bi2 = new BitmapImage();
            bi2.BeginInit();
            bi2.UriSource = new Uri("/ImageMenu/OFF/PizzaOFF.png", UriKind.Relative);
            bi2.EndInit();
            myImage2.Stretch = Stretch.Fill;
            myImage2.Source = bi2;
            PizzaPhoto.Source = bi2;

            Image myImage3 = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("/ImageMenu/OFF/SnackOFF.png", UriKind.Relative);
            bi3.EndInit();
            myImage3.Stretch = Stretch.Fill;
            myImage3.Source = bi3;
            SnackPhoto.Source = bi3;

            Image myImage4 = new Image();
            BitmapImage bi4 = new BitmapImage();
            bi4.BeginInit();
            bi4.UriSource = new Uri("/ImageMenu/OFF/DrinkOFF.png", UriKind.Relative);
            bi4.EndInit();
            myImage4.Stretch = Stretch.Fill;
            myImage4.Source = bi4;
            DrinkPhoto.Source = bi4;

            Image myImage5 = new Image();
            BitmapImage bi5 = new BitmapImage();
            bi5.BeginInit();
            bi5.UriSource = new Uri("/ImageMenu/ON/SaladON.png", UriKind.Relative);
            bi5.EndInit();
            myImage5.Stretch = Stretch.Fill;
            myImage5.Source = bi5;
            SaladPhoto.Source = bi5;

            Titles.Content = "Салаты";

            productList = AppData.Context.Product.ToList();
            productList = productList.Where(i => i.IDCategoryProduct == 5).ToList();
            listProduct.ItemsSource = productList;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Order_Click(object sender, RoutedEventArgs e)
        {
            Order mainWindow = new Order();
            mainWindow.Show();
            this.Close();
        }

        private void Information_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button == null)
            {
                return;
            }
            var editProduct = button.DataContext as Product;
            Information info = new Information(editProduct);
            this.Opacity = 0.2;
            info.ShowDialog();
            productList = AppData.Context.Product.ToList();
            this.Opacity = 1;
        }

        private void AddProduct_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
