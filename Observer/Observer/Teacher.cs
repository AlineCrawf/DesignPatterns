using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Teacher: ITeacher
    {
        List<IStudent> students = new List<IStudent>();
        bool isObserved = true;
        Random random = new Random();
        
        internal List<IStudent> Students { get => students; set => students = value; }

        public void performExam()
        {
            for (int i = 0; i<40; i++)
            {
                isObserved = Convert.ToBoolean(random.Next(0, 10));

                if(!isObserved)
                {
                    Notify();
                }

                writeAnswer();
            }

            printResults();
        }

        void Notify()
        {
            foreach (IStudent st in students)
                st.Update();
        }

        void writeAnswer()
        {
            foreach (IStudent st in students)
                st.answer();
        }

        void printResults()
        {
            foreach (IStudent st in students)
                st.printResults();
        }
    }
}
