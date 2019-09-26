using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Whip: CondimentDecorator
    {
        Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public BeverageSize beverageSize()
        {
            return beverage.getBeverageSize();
        }

        
    public override String getDescription()
        {
            return beverage.getDescription() + ", Whip";
        }
        
    public override double cost()
        {
            double cost = beverage.cost();

            switch (beverageSize())
            {
                case BeverageSize.SMALL:
                    cost += 0.30D;
                    break;
                case BeverageSize.AVERAGE:
                    cost += 0.4D;
                    break;
                case BeverageSize.BIG:
                    cost += 0.50D;
                    break;
            }

            return cost;
        }
    }
}
