using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());
decimal sum = 0;

for (int i = 0; i < n; i++)
{
    decimal intput = decimal.Parse(Console.ReadLine());
    sum+=intput;
}
Console.WriteLine(sum);