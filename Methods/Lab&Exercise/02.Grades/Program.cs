namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeCompare(grade);
        }

        static void GradeCompare(double g)
        {
            if (g >= 2 && g <= 2.99)
            {
                Console.WriteLine("Fail");
            }
            else if (g >= 3 && g <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (g >= 3.5 && g <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (g >= 4.5 && g <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (g >= 5.50 && g <= 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}