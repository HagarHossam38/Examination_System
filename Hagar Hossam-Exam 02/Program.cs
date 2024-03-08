using System.Diagnostics;

namespace Hagar_Hossam_Exam_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(10,"C#");
            subject.Create_exam();
            Console.Clear();
            Console.WriteLine("Do You Want To Start The Exam (Y|N)");
            if (char.Parse(Console.ReadLine()) == 'y'){
                Console.Clear() ;
                Stopwatch sw = Stopwatch.StartNew();
                sw.Start();
                subject.Subject_Exam.Show_Exam();
                Console.WriteLine($"The Elapsed Time= {sw.Elapsed}");
            }

        

            //}
        }
    }
}
