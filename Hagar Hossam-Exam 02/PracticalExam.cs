using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagar_Hossam_Exam_02
{
    internal class PracticalExam : Exam
    {
        public override void AddQuestion(int type) {
            Question_MCQ MCQQ = new Question_MCQ();
            MCQQ.Create_Question();
            Exam_Questions.Add(MCQQ);
            TotalGrade += MCQQ.Question_Mark;
          }

        public override void Show_Exam()
        {
            int answer = 0;
      

            for (int i = 0; i < Number_Of_Question; i++)
            {
                Console.WriteLine($"=> Question ( {i + 1} ) ");
                Console.WriteLine(Exam_Questions[i].ToString());
                Console.WriteLine("_______________");

                if (Exam_Questions[i].GetType() == typeof(Question_MCQ))
                {
                    do
                    {
                        Console.Write("Choose Right Answer (1,2 or 3): ");
                    } while ((!int.TryParse(Console.ReadLine(), out answer)) || (answer != 1 && answer != 2 && answer != 3));

                }
                Console.WriteLine("***************************************************");


            }
            Console.Clear();

            Show_Practical_Exam();

        }

        private  void Show_Practical_Exam()
        {
            Console.WriteLine("****");
            Console.WriteLine("__Model Answer__ ");
            int QuestionNumber = 0;
            foreach (Question  Q in Exam_Questions)
            {
                Console.WriteLine($"Q{QuestionNumber+1}) {Q.Question_Body} : ");
                Console.WriteLine($"Rigth Answer: {Q.Question_Right_Answer}");
                Console.WriteLine("______________________________");
                QuestionNumber++;
            }
            Console.WriteLine("****");
        }
    }
}
