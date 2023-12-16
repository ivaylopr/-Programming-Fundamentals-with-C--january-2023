namespace _12Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstN = int.Parse(Console.ReadLine());
            string operatorIn = Console.ReadLine();
            int secondN = int.Parse(Console.ReadLine());    
            int result=Operations(firstN, operatorIn, secondN);
            Console.WriteLine(result);
        }
        static int Operations(int a, string oper, int b)
        {
            int result = 0;
            if (oper=="*")
            {
                result = a * b;
            }
            else if (oper=="/")
            {
                result = a / b;
            }
            else if (oper=="+")
            {
                result = a + b;
            }
            else if (oper == "-")
            {
                result = a - b;
            }
            return result;
        }
    }
}