using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DarkRoast: Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
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
                    cost = 1.25D;
                    break;
                case BeverageSize.BIG:
                    cost = 1.50D;
                    break;
                default:
                    cost = 1.25D;
                    break;
            }

            return cost;
        }
    }
}
