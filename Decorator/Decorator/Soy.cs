using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Soy: CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public BeverageSize beverageSize()
        {
            return beverage.getBeverageSize();
        }

    public override String getDescription()
        {
            return beverage.getDescription() + ", Soy";
        }
         
    public override double cost()
        {
            double cost = beverage.cost();

            switch (beverageSize())
            {
                case BeverageSize.SMALL:
                    cost += 0.10D;
                    break;
                case BeverageSize.AVERAGE:
                    cost += 0.15D;
                    break;
                case BeverageSize.BIG:
                    cost += 0.20D;
                    break;
            }

            return cost;
        }
    }
}
