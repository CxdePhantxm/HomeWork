using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork.Classes
{
    public class CoalCook : ICooking
    {
        public void Cook()
        {
            Console.WriteLine("Шаурма готовится на углях!");
        }
    }
}