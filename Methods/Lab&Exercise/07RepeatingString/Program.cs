namespace _07RepeatingString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string inputString =Console.ReadLine();
           int n = int.Parse(Console.ReadLine());
           StringPrinting(inputString, n);
        }

        static void StringPrinting(string inStr, int times)
        {

            for (int i = 0; i < times; i++)
            {
                Console.Write(inStr);
            }
        }
    }
}