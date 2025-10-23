using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal class Practical : Exam
    {
        #region Constractor 
        public Practical(int time, int numberofquestion) : base(time, numberofquestion)
        {
            
        }
        #endregion
        #region Methods
        public override void ShowExam()
        {
            Console.WriteLine("===== practical Exam ======");
            foreach (var x in questions)
            {
                x.ShowExam();
                Console.WriteLine($"Right answer is {x.RightAnswer.AnswerText}");
                Console.WriteLine();
            }

           
        }
        #endregion
    }
}
