using System.Security;

double[] input = Console.ReadLine().Split().Select(double.Parse).ToArray();
double currentNum = 0;
for (int i = 0; i < input.Length; i++)
{
    currentNum=input[i];
    Console.WriteLine($"{input[i]} => {Math.Round(input[i], MidpointRounding.AwayFromZero)}");
}