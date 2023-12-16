int n = int.Parse(Console.ReadLine());
int sumOfDigits = 0;
int digit = 0;
for (int i = 1; i <= n; i++)
{
    int copyNum = i;
    while (copyNum>0)
    {
        digit =copyNum % 10;
        sumOfDigits += digit;
        copyNum /= 10;
    }
    if (sumOfDigits==5 || sumOfDigits==7  || sumOfDigits==11)
    {
        Console.WriteLine($"{i} -> True");
    }
    else
    {
        Console.WriteLine($"{i} -> False");
    }
    sumOfDigits = 0;

}