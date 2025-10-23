using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal abstract class Exam
    {
        #region property
        public int Time  { get; set; }
        public int NumberofQuestions { get; set; }

       // public Question[] questions { get; set; }
       public List<Question>questions { get; set; }

        #endregion

        #region Constractor 

       
        public Exam(int time ,int numberofquestions) 
        {
                Time = time;
                NumberofQuestions = numberofquestions;
          //  questions = new[] Question(); // مش هعرف لازم اثبت 
                questions = new List<Question>();
        
        }
        #endregion

        #region Methods

       

        public abstract void ShowExam();
        #endregion

    }
}
