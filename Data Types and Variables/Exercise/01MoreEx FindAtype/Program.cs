
string input = " ";
while ((input=Console.ReadLine())!="END")
{
    
    if (int.TryParse(input, out int a))
    {
        Console.WriteLine($"{a} is integer type");
    }
    else if (double.TryParse(input, out double b))
    {
        Console.WriteLine($"{b} is floating point type");
    }
    else if (bool.TryParse(input, out bool c))
    {

        input.ToString().ToLowerInvariant();
        Console.WriteLine($"{input} is boolean type");

    }
    else if (char.TryParse(input, out char d))
    {
        Console.WriteLine($"{d} is character type");

    }
    else
    {
        Console.WriteLine($"{input} is string type");

    }
}

