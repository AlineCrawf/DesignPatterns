using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso();
            beverage.setBeverageSize(BeverageSize.AVERAGE);
            Console.WriteLine(beverage.getDescription() + " $" + beverage.cost());

            Beverage beverage2 = new DarkRoast();
            //beverage2.setBeverageSize(BeverageSize.BIG);
            //beverage2 = new Mocha(beverage2);
            //beverage2.setBeverageSize(BeverageSize.BIG);
            //beverage2 = new Whip(beverage2);
            //beverage2.setBeverageSize(BeverageSize.BIG);
            Console.WriteLine(beverage2.getDescription() + " $" + beverage2.cost());

            Beverage beverage3 = new HouseBlend();
            beverage3.setBeverageSize(BeverageSize.BIG);
            beverage3 = new Soy(beverage3);
            beverage3.setBeverageSize(BeverageSize.BIG);
            beverage3 = new Mocha(beverage3);
            beverage3.setBeverageSize(BeverageSize.BIG);
            beverage3 = new Whip(beverage3);
            beverage3.setBeverageSize(BeverageSize.BIG);
            Console.WriteLine(beverage3.getDescription() + " $" + beverage3.cost());
            Console.ReadKey();
        }
    }
}
