using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Hagar_Hossam_Exam_02
{
    internal class Question_T_F:Question
    {
        public Question_T_F() : base()
        {
            AnswerList = new Answers[2];
            Question_Header = "True | False Question ";
        
        }
    public Question_T_F(  string _question_body,double _question_mark,int _question_ra):base( _question_body, _question_mark,_question_ra)
        {
            AnswerList = new Answers[2];
            Question_Header = "True | False Question ";
            // Set_answers();

        }
    public override void Set_answers()
        {
            

            AnswerList[0]=new Answers(1,"True");
            AnswerList[1] = new Answers(2, "False");
          

        }
     public override void Create_Question()
        {
            base.Create_Question();
          
            this.Set_answers();
            do
            {
                Question_Right_Answer = Helper.GetIntInput("Please Specify The Right Answer Of Question (1 For True and 2 For False): ");
            } while ((Question_Right_Answer != 1 && Question_Right_Answer != 2));
        }




    }
}
