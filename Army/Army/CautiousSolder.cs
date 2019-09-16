using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    class CautiousSolder: ISolder
    {
        int x = 0;
        static int soldersCount = 0;
        int number;

        public CautiousSolder()
        {
            number = ++soldersCount;
        }        

        public void Fight()
        {
            x ++;
        }

        public void Retreat()
        {
            x-=2;
        }

        public void Print()
        {
            Console.WriteLine($"CautiousSolder #{number}: x = {x}");
        }

        public void Clear()
        {
            x = 0;
        }
    }
}
