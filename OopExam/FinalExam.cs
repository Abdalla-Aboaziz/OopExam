using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal class FinalExam : Exam
    {
        #region Constractor 
        public FinalExam(int time ,int numberofquestion):base(time,numberofquestion)
        {
            
        }
        #endregion

        #region Methods
        public override void ShowExam()
        {
            Console.WriteLine("======= Final Exam ========");
            int total = 0;
            foreach(var x in questions)
            {
                x.ShowExam();
               // Console.WriteLine("Enter The Answer : ");
                int Ans;
                bool isparsed;
                do
                {
                    Console.WriteLine("Enter The Answer : ");
                    isparsed = int.TryParse(Console.ReadLine(),out Ans);

                } while (!isparsed);

                if (x.answers[Ans - 1].AnswerId == x.RightAnswer.AnswerId)
                {
                    total += x.Mark;
                }

               

            }
            Console.WriteLine($" your grade is {total}");

        }
        #endregion
    }
}
