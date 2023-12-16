namespace _06MiddleChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MiddleCharacter(text);
        }
        static void MiddleCharacter ( string text)
        {
            int longOfInput = text.Length;
            char middle = ' ';
            char evenMid = ' ';
            if (longOfInput%2==0)
            {
                longOfInput /= 2;
                middle = text[longOfInput];
                evenMid = text[longOfInput -1];
                Console.WriteLine($"{evenMid}{middle}");
            }
            else 
            {
                longOfInput /= 2;
                middle = text[longOfInput];
                Console.WriteLine(middle);
            }
        }
    }
}