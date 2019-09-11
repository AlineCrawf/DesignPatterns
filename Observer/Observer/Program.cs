using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            for(int i = 0; i<12;i++)
            {
                if (i < 5)
                {
                    //HonestStudent hs = new HonestStudent();
                    teacher.Students.Add(new HonestStudent());
                }
                //CunningStudent cs = ;
                teacher.Students.Add(new CunningStudent());
            }

            teacher.performExam();
            Console.ReadKey();
        }
    }
}
