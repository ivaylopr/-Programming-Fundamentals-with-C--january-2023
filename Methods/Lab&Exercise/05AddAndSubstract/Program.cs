namespace _05AddAndSubstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = Substract(a, b, c);
            Console.WriteLine(result);
        }
        static int SumOfFirstTwoInt(int a, int b)
        {
            return a + b;
        }
        static int Substract(int a,int b, int c)
        {
            int substract = SumOfFirstTwoInt(a, b);
            substract -= c;
            return substract;
        }

    }
}