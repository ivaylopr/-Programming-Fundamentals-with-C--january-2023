namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstIn = int.Parse(Console.ReadLine());
            int secondIn = int.Parse(Console.ReadLine());
            double division = FactorialDivision(firstIn, secondIn);
            Console.WriteLine($"{division:f2}");
        }
        static double FactorialDivision(int a, int b)
        {
            int firstF = 1;
            int secondF = 1;
            for (int i = 1; i <= a; i++)
            {
                firstF *= i;
            }
            for (int i = 1; i < b; i++)
            {
                secondF *= b;
            }
            return (double)firstF/(double)secondF;

        }
    }
}