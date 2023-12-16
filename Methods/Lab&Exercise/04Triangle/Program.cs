namespace _04Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                TrianglePrint(i);
            }
            for (int i = input-1; i >=1; i--)
            {

                TrianglePrint(i);

            }
        }
        static void TrianglePrint (int a)
        {
            for (int j = 1; j <= a; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}