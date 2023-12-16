int numer = int.Parse(Console.ReadLine());

while (true)
{
    if(numer%10==0)
    {
        Console.WriteLine("The number is divisible by 10");
        break;
    }
    else if(numer%7==0)
    {
        Console.WriteLine("The number is divisible by 7");
        break ;
    }
    else if (numer%6==0)
    {
        Console.WriteLine("The number is divisible by 6");
        break;
    }
    else if (numer % 3==0)
    {
        Console.WriteLine("The number is divisible by 3");
        break;
    }
    else if (numer %2==0)
    {
        Console.WriteLine("The number is divisible by 2");
        break;
    }
    else
    {
        Console.WriteLine("Not divisible");
        break;
    }
}