using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    class BraveSoldier: ISolder
    {
        int x = 0;
        static int soldersCount = 0;
        int number;

        public BraveSoldier()
        {
            number = ++soldersCount;
        }

        public void Fight()
        {
            x += 2;
        }

        public void Retreat()
        {
            x--;
        }

        public void Print()
        {
            Console.WriteLine($"BraveSoldier #{number}: x = {x}");
        }

        public void Clear()
        {
            x = 0;
        }
    }
}
