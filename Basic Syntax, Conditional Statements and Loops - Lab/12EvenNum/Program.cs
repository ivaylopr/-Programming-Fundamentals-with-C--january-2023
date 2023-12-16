while (true)
{
    int i = int.Parse(Console.ReadLine());
    if (i%2!=0)
    {
        Console.WriteLine("Please write an even number.");
    }
    else
    {
        Console.WriteLine($"The number is: {Math.Abs(i)}");
        break;
    }    
}