int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
if (m <= 10)
{
    for (int i = m; i <= 10; i++)
    {
        Console.WriteLine($"{n} X {i} = {i * n}");
    }
}
else 
{
    
    Console.WriteLine($"{n} X {m} = {n * m}");
    
}
