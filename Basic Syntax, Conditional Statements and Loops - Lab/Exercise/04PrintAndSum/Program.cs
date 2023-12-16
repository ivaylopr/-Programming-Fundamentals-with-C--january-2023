int startSenquence = int.Parse(Console.ReadLine());
int endSenquance = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = startSenquence; i <= endSenquance; i++)
{
    sum += i;
    Console.Write($"{i} ");
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");