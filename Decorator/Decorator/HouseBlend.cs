using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class HouseBlend: Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        
        public override double cost()
        {
            double cost;

            switch (getBeverageSize())
            {
                case BeverageSize.SMALL:
                    cost = 0.60D;
                    break;
                case BeverageSize.AVERAGE:
                    cost = 0.99D;
                    break;
                case BeverageSize.BIG:
                    cost = 1.40D;
                    break;
                default:
                    cost = 0.99D;
                    break;
            }

            return cost;
        }
    }
}
