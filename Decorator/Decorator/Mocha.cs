using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mocha: CondimentDecorator
    {
        Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public BeverageSize beverageSize()
        {
            return beverage.getBeverageSize();
        }
        

    public override String getDescription()
        {
            return beverage.getDescription() + ", Mocha";
        }
        
    public override double cost()
        {
            double cost = beverage.cost();

            switch (beverageSize())
            {
                case BeverageSize.SMALL:
                    cost += 0.20D;
                    break;
                case BeverageSize.AVERAGE:
                    cost += 0.25D;
                    break;
                case BeverageSize.BIG:
                    cost += 0.30D;
                    break;
            }

            return cost;
        }
    }
}
