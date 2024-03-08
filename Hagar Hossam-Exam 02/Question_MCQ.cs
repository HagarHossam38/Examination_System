using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagar_Hossam_Exam_02
{
    internal class Question_MCQ:Question

    {
        public Question_MCQ( string _question_body, double _question_mark, int _question_ra) : base( _question_body, _question_mark, _question_ra)
        {
            AnswerList = new Answers[3];
            Question_Header = "Choose One Answer Question";

        }

        public Question_MCQ()  { 
            AnswerList = new Answers[3];
            Question_Header = "Choose One Answer Question";
           

        }
        public override void Set_answers()
        {

            Console.Write("The Choices of Question: ");
            Console.WriteLine();
            for (int i = 0; i < AnswerList.Length; i++)
            {

                string AnswerBody;
                AnswerBody = Helper.GetStringInput($"Please enter the choice number ({i + 1}) :  ");
                AnswerList[i] = new Answers(i + 1, AnswerBody);


            }
            do {

                Question_Right_Answer = Helper.GetIntInput("Please Specify The Right Answer Of Question: ");
            } while ( (Question_Right_Answer != 1 && Question_Right_Answer != 2 && Question_Right_Answer != 3));
            
        }


        public override void Create_Question()
        {
            base.Create_Question();

            this.Set_answers();

        }
    }
}
