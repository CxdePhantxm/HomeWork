using HomeWork.Classes;
using HomeWork.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Shawarma shawarma = new Shawarma(4.00);
            shawarma.AddFilling(new Filling("Double Onion", 0.50));
            shawarma.AddFilling(new Filling("Double Meat", 0.50));

            shawarma.TypeCooking = new CoalCook();
            shawarma.Cook();
            shawarma.TypeCooking = new GrillCook();
            shawarma.Cook();

            var charge = shawarma.CalcCost();
            Console.WriteLine(charge);

            Console.ReadKey();
        }
    }
}