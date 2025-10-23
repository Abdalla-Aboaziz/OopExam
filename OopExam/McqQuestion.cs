using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal class McqQuestion : Question

    {
        #region Constractor

      

        public McqQuestion(string header,string body,int mark):base(header,body,mark)
        {
            
        }
        #endregion

        #region Methods

       

        public override void ShowExam()
        {
            Console.WriteLine($"Header : {Header}");
            Console.WriteLine($"Body : {Body}");

            foreach (var item in answers)
            {
                Console.WriteLine(item);

            }


        }
        #endregion
    }
}
