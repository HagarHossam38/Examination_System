using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hagar_Hossam_Exam_02
{
    internal abstract class Exam
    {
        public double Exam_Duration { get; set; }
        public int Number_Of_Question { get; set; }
        public double TotalGrade { get; set; }


        public List<Question> Exam_Questions { get; set; }
        public Exam()
        {
            Exam_Duration = 0;
            Number_Of_Question = 0;
            TotalGrade = 0;
            Exam_Questions = new List<Question>();
        }
        public abstract void AddQuestion(int type);
        public abstract void Show_Exam();
        

        

    }
}
