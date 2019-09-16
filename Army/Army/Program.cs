using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    class Program
    {
        static void Main(string[] args)
        {
            General general = new General();
            int loop = 0;

            for(int i=0; i<10; i++)
            {
                if (Convert.ToBoolean(i % 2))
                    general.addSolder(new BraveSoldier());

                else
                    general.addSolder(new CautiousSolder());
            }

            Console.WriteLine("Enter count of loop");
            loop = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < loop; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random rd = new Random();
                    if (rd.Next() % 2 != 0)
                        general.FightCommand();
                    else
                        general.RetreatCommand();
                }

                general.PrintResult();
                general.Clear();
                Console.ReadKey();

            }
        }
    }
}
