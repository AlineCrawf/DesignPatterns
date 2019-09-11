using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performFly();
            mallard.performQuack();

            ModelDuck modelDuck = new ModelDuck();
            modelDuck.performFly();
            modelDuck.setFlyBehavior(new FlyRocketPowered());
            modelDuck.performFly();
            Console.ReadKey();
        }
    }
}
