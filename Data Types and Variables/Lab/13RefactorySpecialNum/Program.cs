int number = int.Parse(Console.ReadLine());
int sum = 0;
int copyNum = 0;
int digit = 0;
for (int i = 1; i <= number; i++)
{
    copyNum = i;
    while (copyNum > 0)
    {
        digit = copyNum % 10;
        sum +=digit;
        copyNum /= 10;
    }
    if(sum == 5 || sum == 7 || sum == 11)
    {
        Console.WriteLine($"{i} -> True");

    }
    else
    {
        Console.WriteLine($"{i} -> False");

    }
    sum = 0;

}
