using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class HonestStudent : IStudent
    {
        int currentAnswer = 1;
        int number;
        static int count = 0;
        List<int> answers = new List<int>();
        
        public HonestStudent()
        {
            count++;
            number = count;
        }
        public void answer()
        {
            answers.Add(currentAnswer);
        }

        public void Update()
        {
            Random random = new Random();
            currentAnswer = random.Next(0,1);
         }

        public void printResults()
        {
            Console.Write($"HonestStudent {number}: ");
            foreach (int i in answers)
                Console.Write(i);
            Console.Write('\n');
        }
    }
}
