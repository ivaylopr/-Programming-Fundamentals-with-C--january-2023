using System.Runtime.CompilerServices;

namespace _02Vowels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int result = Vowels(input);
            Console.WriteLine(result);
        }
        static int Vowels(string text)
        {
            char[] arrayVowels =new char[] { 'a', 'u', 'o', 'u', 'e', 'i','y' };
            int result = 0;
            foreach (var item in text.ToLower())
            {
                if (arrayVowels.Contains(item))
                {
                    result++;
                }
            }
            return result;

        }
    }
}