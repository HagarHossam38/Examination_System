namespace Hagar_Hossam_Exam_02
{
    internal class Helper
    {
        public static string GetStringInput(string msg)
        {
            string input; 
            do
            {
                Console.Write(msg);
                input = Console.ReadLine() ?? "";

            } while (input == null || input == "" || input == " ");
            return input;
        }

        public static double GetdoubleInput(string msg)
        {
            double input;
            do
            {
                Console.Write(msg);
             

            } while (!double.TryParse(Console.ReadLine(),out input));
            return input;
        }

        public static int GetIntInput(string msg)
        {
            int input;
            do
            {
                Console.Write(msg);


            } while (!int.TryParse(Console.ReadLine(), out input));
            return input;
        }
    }
}
