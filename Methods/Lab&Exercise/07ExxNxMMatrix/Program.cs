namespace _07ExxNxMMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            NxMMatrix(n);

        }
        static void NxMMatrix (int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}