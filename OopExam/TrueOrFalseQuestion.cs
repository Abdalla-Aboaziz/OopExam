using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal class TrueOrFalseQuestion : Question
    {
        #region Constractor 
        public TrueOrFalseQuestion(string header,string body, int mark):base(header, body,mark)
        {
            
        }
        #endregion
        #region Methods
        public override void ShowExam()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine("1- True \n 2-False");
           
        }
        #endregion
    }
}
