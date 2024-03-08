using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Hagar_Hossam_Exam_02
{
    internal class FinalExam : Exam
    {
        public override void AddQuestion(int type)
        {
            Question question;
            if (type == 1)
            {
                question = new Question_T_F();
            }
            else
            {
                question = new Question_MCQ();
            }
            question.Create_Question();
            Exam_Questions.Add(question);
            TotalGrade += question.Question_Mark;
        }

        public override void Show_Exam()
        {
            int answer = 0;
            double StudentGrade = 0;
            List<string> StudentAnswers= new List<string>();
           //DateTime StartExam= DateTime.Now;

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
                if (Exam_Questions[i].GetType() == typeof(Question_T_F))
                {
                    do
                    {
                        Console.Write("Choose Right Answer (1=> True or 2 => False ): ");
                    } while ((!int.TryParse(Console.ReadLine(), out answer)) || (answer != 1 && answer != 2));

                }


                StudentAnswers.Add(Exam_Questions[i].AnswerList[answer-1].Answer_Text);



                if (answer == Exam_Questions[i].Question_Right_Answer)
                {
                    StudentGrade += Exam_Questions[i].Question_Mark;
                  
                }

                Console.WriteLine("***************************************************");
                //DateTime CurrentTime = DateTime.Now;
                //TimeSpan difference = StartExam - CurrentTime;
                //if (difference.TotalMinutes >= Exam_Duration)
                //{
                //    Console.Clear();
                //    Console.WriteLine("*****************");
                //    Console.WriteLine("TIME OUT :(");
                //    Console.WriteLine("*****************");
                //    Show_Final_Exam(StudentGrade, TotalGrade, StudentAnswers);
                //}
            }
          

            Show_Final_Exam(StudentGrade, TotalGrade,StudentAnswers);
        }
        private void Show_Final_Exam(double StdGrade, double TotalGrade, List<string> StdAnswers)
        {
            Console.Clear();
            int QuestionNumber = 0;
            Console.WriteLine("Your Answers:");
            foreach (Question Q in Exam_Questions)
            {
                Console.WriteLine($"Q{QuestionNumber + 1}) {Q.Question_Body} : {StdAnswers[QuestionNumber]} ");

                QuestionNumber++;
            }
            Console.WriteLine($"Your Exam Grade is {StdGrade} out of {TotalGrade}");

        }
    }
        
        }


    

