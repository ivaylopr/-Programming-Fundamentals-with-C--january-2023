using System;
using System.Net.WebSockets;

namespace _09.ExxPalindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string command = string.Empty;
            while ((command=Console.ReadLine())!="END")
            {
                int inputInt = int.Parse(command);
                bool result = IsPalindrom(inputInt);
               
                if (result==true)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
        static bool IsPalindrom (int a)
        {
            int remainder = 0;
            int reverse = 0;
             while (a > 0)
            {
                remainder = a % 10;
                reverse = reverse * 10 + remainder;
                a /= 10;
            }
            if (reverse==a)
            {
                
               return true;
            }
            return false;

        }
    }
}