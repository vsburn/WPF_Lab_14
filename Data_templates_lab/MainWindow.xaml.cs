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
using System.Collections.ObjectModel;

namespace Data_templates_lab
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
                Name = "Холодильник",
                Price = 990,
                PathImg = "img/refrigerator.png",
                Category = Category.Appliances
            });
            products.Add(new Product()
            {
                Name = "Микроволновка",
                Price = 300,
                PathImg = "img/oven.png",
                Category = Category.Appliances
            });
            products.Add(new Product()
            {
                Name = "Молоко",
                Price = 2.90,
                PathImg = "img/milk.png",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                Name = "Сыр",
                Price = 15.99,
                PathImg = "img/cheese.png",
                Category = Category.Food
            });
            products.Add(new Product()
            {
                Name = "Чайник",
                Price = 150,
                PathImg = "img/kettle.png",
                Category = Category.Appliances
            });
            listBox.ItemsSource = products;
        }
    }


}
