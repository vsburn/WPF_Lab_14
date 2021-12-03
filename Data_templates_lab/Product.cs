using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_templates_lab
{
    /// <summary>
    ///Определить класс Product для хранения информации о товаре.
    /// Класс должен содержать характеристики:
    /// Название товара (строка)
    /// Цена (число)
    /// Изображение (строка - путь к файлу с изображением)
    /// Категория (перечисление, возможные значения – Еда, Бытовая техника)
    /// Разработать шаблон данных для отображения списка товаров в компоненте ListBox
    /// При помощи триггеров определите разный шаблон для товаров категории Еда и категории Бытовая техника.
    /// </summary>
    
    public enum Category
    {
        Food,
        Appliances
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string PathImg { get; set; }
        public Category Category { get; set; }
    }
}
