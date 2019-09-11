using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;

        public Duck()
        {
        }

        public abstract void display();

        public void performFly()
        {
            flyBehavior.fly();
        }

        public void performQuack()
        {
            quackBehavior.quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }

        public void setFlyBehavior(FlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void setQuackBehavior(QuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }
}
