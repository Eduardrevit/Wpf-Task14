using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf_Task14
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProductName = "Мука",
                ProductPrice = 120,
                ProductImage = "Data/Мука.PNG",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Яйца",
                ProductPrice = 95,
                ProductImage = "Data/Яйца.PNG",
                ProductCategory = ProductCategories.Food
            });
            products.Add(new Product()
            {
                ProductName = "Робот-пылесос",
                ProductPrice = 19000,
                ProductImage = "Data/Пылесос.PNG",
                ProductCategory = ProductCategories.Appliances
            });
            products.Add(new Product()
            {
                ProductName = "Чайник",
                ProductPrice = 6000,
                ProductImage = "Data/Чайник.PNG",
                ProductCategory = ProductCategories.Appliances
            });
            listBox.ItemsSource = products;
        }
    }
}
