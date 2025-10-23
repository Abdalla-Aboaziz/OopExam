using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal class Subject
    {
        #region property
        public int SubjectId{ get; set; }
        public string ?SubjectName{ get; set; }
        public Exam Exams{ get; set; }

        #endregion
        #region Constractor 
        public Subject(int subject_id,string subject_name)
        {
            SubjectId = subject_id;
            SubjectName = subject_name;

            
        }
        #endregion

        #region Methods
        public void CreateExam(Exam exams)
        {
            Exams=exams;
        }

        public void ShowExam()
        {
            Exams.ShowExam();
        }

        #endregion




    }
}
