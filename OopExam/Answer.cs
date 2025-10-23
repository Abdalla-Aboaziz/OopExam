using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal class Answer:ICloneable
    {
        #region property

       
        public int AnswerId { get; set; }
        public string ?AnswerText {  get; set; }

        #endregion
        #region Constractor

      
        public Answer(int AnsId,string Anstxt)
        {
            AnswerId = AnsId;
            AnswerText = Anstxt;
        }
        #endregion

        #region Methods

       
        public override string ToString()
        {
            return $" {AnswerId}):-  {AnswerText}";
        }

        public object Clone()
        {
            return new Answer(this.AnswerId, this.AnswerText);
        }
        #endregion
    }
}
