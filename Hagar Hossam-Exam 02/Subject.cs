using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Hagar_Hossam_Exam_02
{
    internal class Subject
    {
        //        Note: The Subject is a class that contains the following members:
        //a.Subject Id.
        public int Subject_ID { get; set; }
        //b.Subject Name.
        public string Subject_Name { get; set; }
        public Exam Subject_Exam { get; set; }

        #region Constructors
        public Subject()
        {
            Subject_ID = 0;
            Subject_Name = "";
           
        }

        public Subject(int subject_id, string subject_name):this()
        {
            Subject_ID = subject_id;
            Subject_Name = subject_name;
        }
   
        #endregion


        //d.We need to implement functionality to create the exam of
        //the subject.

        public void Create_exam()
        {
    

            int ExamType;
            do
            {
                Console.Write("Please enter the exam type you wanna create (1 for Parctical and  2 for Final ): ");
} while (!int.TryParse(Console.ReadLine(), out ExamType)|| (ExamType!=1 && ExamType != 2));

            if (ExamType == 1) {
                Subject_Exam = new PracticalExam();
            }
            else if (ExamType == 2)
            {
                Subject_Exam = new FinalExam ();

            }
           int Examduration= Helper.GetIntInput("Please Enter The Time Of Exam In Minutes: ");
           int NumberOfquestion = Helper.GetIntInput("Please Tnter The Number Of Qustions You Wanted to Create: ");
            Subject_Exam.Exam_Duration = Examduration;
            Subject_Exam.Number_Of_Question= NumberOfquestion;
            Console.Clear();
            for (int i = 0;i < Subject_Exam.Number_Of_Question;i++)
            {
                int Q_type = 1;
                if (ExamType == 2)
                { 
                    do
                    {
                        Console.Write($"Please Choose Type of Question Number ({i + 1})   (1 for True Or False || 2 for MCQ) ");
                    } while (!int.TryParse(Console.ReadLine(), out Q_type) || (Q_type != 1 && Q_type != 2));

                }
                else
                {
                    Console.Write($"Question Number ({i + 1}) ");
                }
                Subject_Exam.AddQuestion(Q_type);

                Console.Clear() ;

            }


        }
    }
}
