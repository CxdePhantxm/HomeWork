using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Classes
{
    public class Filling
    {
        //Свойства
        public double Price { get; protected set; } //Цена
        public string Description { get; protected set; } //Описание
        //Конструктор
        public Filling(string desc, double price)
        {
            Description = desc;
            Price = price;
        }
        //Методы

    }
}