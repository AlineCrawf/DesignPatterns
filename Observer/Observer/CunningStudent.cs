using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class CunningStudent : IStudent
    {
        int number;
        static int count = 0;
        int currentAnswer = 0;
        List<int> answers = new List<int> ();

        public CunningStudent()
        {
            count++;
            number = count;
        }

        public  void Update()
        {
            currentAnswer = currentAnswer == 0? 1 : 0;
        }

        public void answer()
        {
            answers.Add(currentAnswer);
        }

        public void printResults()
        {
            Console.Write($"CunningStudent {number}: ");
            foreach (int i in answers)
                Console.Write(i);
            Console.Write('\n');
        }
    }
}
