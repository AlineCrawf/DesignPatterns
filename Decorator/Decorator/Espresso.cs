using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Espresso: Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        
    public override double cost()
        {
            double cost;

            switch (getBeverageSize())
            {
                case BeverageSize.SMALL:
                    cost = 1.00D;
                    break;
                case BeverageSize.AVERAGE:
                    cost = 1.70D;
                    break;
                case BeverageSize.BIG:
                    cost = 1.99D;
                    break;
                default:
                    cost = 1.70D;
                    break;
            }

            return cost;
        }
    }
}
