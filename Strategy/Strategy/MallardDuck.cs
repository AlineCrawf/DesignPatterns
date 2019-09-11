using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new Quack();
        }
        

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard strategy");
        }
        }
}
