﻿using System.ComponentModel;

namespace _03Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse((Console.ReadLine()));
            if (command == "add")
            {
                Sum(a,b);
            }
            //add", "multiply", "subtract", "divide
            else if (command=="multiply")
            {
                Multiply(a,b);
            }
            else if (command=="subtract")
            {
                Subtract(a,b);
            }
            else if (command=="divide")
            {
                Divide(a, b);
            }
            
        }
        static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);   
        }
        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);   
        }
        static void Divide (int a, int b)
        {
            Console.WriteLine(a/b);
        }
    }
    
}