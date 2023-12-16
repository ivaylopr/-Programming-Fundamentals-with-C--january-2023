namespace _01ExxSmallestInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            int secondN= int.Parse(Console.ReadLine());
            int thirdN = int.Parse(Console.ReadLine());
            int result = SmallestInt(firstN, secondN, thirdN);
            Console.WriteLine(result);
        }
        static int SmallestInt(int a, int b, int c)
        {
            int result = 0;
            if (a<=b && a<=c)
            {
                result = a;
            }
            else if (b<=c && b<=a)
            {
                result = b;
            }
            else if (c<=a && c<=b)
            {
                result = c;
            }
            return result;
        }
    }
}