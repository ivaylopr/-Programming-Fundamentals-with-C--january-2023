namespace _03ExxCharInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startChar = char.Parse(Console.ReadLine());
            char endChar = char.Parse(Console.ReadLine());
            PrintRange(startChar, endChar);
        }
        static void PrintRange (int a,int b)
        {
            if (a>b)
            {
                int c = a;
                a = b;
                b = c;
               
            }
            for (int i = a+1; i < b; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}