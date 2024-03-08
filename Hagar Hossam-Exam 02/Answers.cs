using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagar_Hossam_Exam_02
{
    internal class Answers
    {
        public int Answer_ID { get; set; }
        public string Answer_Text { get; set; }

        #region Constructors
     
        public Answers(int answer_id, string answer_text)
        {
            Answer_ID = answer_id;
            Answer_Text = answer_text;


        } 
        #endregion
       
       public override string ToString()
        {
         
            return $" ({Answer_ID}) {Answer_Text} \n";
        }
      
    }
}
