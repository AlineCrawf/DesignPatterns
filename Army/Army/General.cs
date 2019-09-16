using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Army
{
    class General: IGeneral
    {
        List<ISolder> solders = new List<ISolder>();

        public void addSolder(ISolder s)
        {
            solders.Add(s);
        }

        public void FightCommand()
        {
            foreach(ISolder s in solders)
            {
                s.Fight();
            }
        }

        public void RetreatCommand()
        {
            foreach (ISolder s in solders)
            {
                s.Retreat();
            }
        }

        public void PrintResult()
        {
            foreach (ISolder s in solders)
            {
                s.Print();
            }
        }

        public void Clear()
        {

            foreach (ISolder s in solders)
            {
                s.Clear();
            }
        }
    }
}
