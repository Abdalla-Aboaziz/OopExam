using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal abstract class Question
    {
        #region property
        public string ?Header { get; set; }
        public string ?Body  { get; set; }

        public int Mark { get; set; }
        public Answer[]answers { get; set; }
        public Answer RightAnswer { get; set; }
        #endregion
        #region Constractor 
        protected Question(string header,string body,int mark)
        {
            Header=header;
            Body=body;
            Mark=mark;
            
            
        }
        #endregion
        #region Methods
        public abstract void ShowExam();


        #endregion

    }
}
