using System.Diagnostics.Metrics;

namespace _05Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            //coffee",  "water", "coke", "snacks"
            PrintPrice(product, quantity);
        }
        static void PrintPrice(string a, int b)
        {
            double price = 0;
            if (a == "coffee")
            {
                price = (double)b * 1.5;
            }
            else if (a == "water")
            {
                price = (double)b * 1.00;
            }
            else if (a == "coke")
            {
                price = (double)b * 1.4;
            }
            else if (a == "snacks")
            {
                price = (double)b * 2.00;
            }
            Console.WriteLine($"{price:F2}");
        }
    }
}