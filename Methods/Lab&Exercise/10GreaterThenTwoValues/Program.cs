namespace _10GreaterThenTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type=="int")
            {
                int a= int.Parse(Console.ReadLine());
                int b= int.Parse(Console.ReadLine());
                int greaterVelue = Maximus(a, b);
                Console.WriteLine(greaterVelue);
            }
            else if (type=="char")
            {
                char a=char.Parse(Console.ReadLine());
                char b=char.Parse(Console.ReadLine());
                char greaterValue = Maximus(a, b);
                Console.WriteLine(greaterValue);
            }
            else if (type=="string")
            {
                string a = Console.ReadLine();
                string b = Console.ReadLine();
                string greaterValue = Maximus(a, b);
                Console.WriteLine(greaterValue);
            }
        }
        static int Maximus (int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;  
            }
        }
        static string Maximus (string a, string b)
        {
            int  result = a.CompareTo(b);
            if (result>0)
            {
                return a;
            }
            else if (result<0)
            {
                return b;
            }
            return " ";
        }
        static char Maximus(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}