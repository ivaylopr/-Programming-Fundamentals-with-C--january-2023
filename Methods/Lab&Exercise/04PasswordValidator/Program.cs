using System;

namespace _04PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            bool passWLength = PassWordCheckLength(text);
            bool passWDigitsAndLetters = AlphaNumeric(text);
            bool passDigits = IsPassworContainsAtLeastTwoD(text);
            if (passWLength==true)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (passWDigitsAndLetters==false)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (passDigits==false)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (!passWLength && passWDigitsAndLetters && passDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }
        static bool PassWordCheckLength(string passW) //lenght chars 6-10
        {
            bool isValid = passW.Length < 6 || passW.Length > 10;
            return isValid;
            
        }
        static bool AlphaNumeric(string password) //contains only digits and letters
        {

            foreach (char item in password)
            {
                if (!Char.IsLetterOrDigit(item))
                {
                    return false;
                }
            }
            return true;  
        }
        static bool IsPassworContainsAtLeastTwoD(string password)
        {
            int digitsCnt = 0;
            foreach (char item in password)
            {
                if (char.IsDigit(item))
                {
                    digitsCnt++;
                }
            }
            if (digitsCnt >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}