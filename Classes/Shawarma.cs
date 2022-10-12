using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Classes
{
    public class Shawarma: IShawarma
    {
        //Свойства
        public List<Filling> Fillings = new List<Filling>(); //Добавки начинки
        public double EndingCost { get; protected set; }     //Цена с добавками
        public ICooking TypeCooking { protected get; set; }  //Тип готовки 
        //Конструкторы
        public Shawarma(double c)
        {
            EndingCost = c;
        }

        public Shawarma(IList<Filling> fillings)
        {
            this.Fillings.AddRange(fillings);
        }
        //Методы
        public void AddFilling(Filling filling) //Добавить в начинку
        {
            this.Fillings.Add(filling);
        }

        public void RemoveTopping(Filling filling) //Удалить из начинки
        {
            this.Fillings.Remove(filling);
        }

        public void Cook() //Тип готовки
        {
            TypeCooking.Cook();
        }

        public double CalcCost() //Подсчёт стоимости
        {
            var total = EndingCost;
            foreach (var t in Fillings)
            {
                total += t.Price;
            }
            return total;
        }
    }
}