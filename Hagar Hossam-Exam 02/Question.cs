using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Hagar_Hossam_Exam_02
{
    internal abstract class  Question
    {
        public string Question_Header { get; set; }
        public string Question_Body { get; set; }
        public double Question_Mark { get; set; }
        public int Question_Right_Answer { get; set; }
        public Answers[] AnswerList { get; set; }
        public Question()
        {
            Question_Header = "";
            Question_Body = "";
            Question_Mark = 0;
            Question_Right_Answer =-1;
           //AnswerList = new Answers[3];
        }
        public Question( string _question_body ,double _question_mark ,int _question_ra):this()
        {
         
            Question_Body = _question_body ;
            Question_Mark = _question_mark ;
            Question_Right_Answer = _question_ra;


        }

        

        public abstract   void Set_answers();
        public override string ToString()
        {
           
            StringBuilder Answers = new StringBuilder();
            foreach (var answer in AnswerList)
            {
                Answers.Append(answer.ToString());
            }
            return $"{Question_Header}: \n {Question_Body}     ({Question_Mark} Marks.) \n \n{Answers}";
        }
        public virtual void Create_Question()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Question_Header );
            Question_Body = Helper.GetStringInput("Please Enter The Body Of Question : ");

            Question_Mark = Helper.GetdoubleInput("Please Enter The Question Mark: ");

        }
   

    }
}
