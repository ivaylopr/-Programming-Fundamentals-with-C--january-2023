int number = int.Parse(Console.ReadLine());
int factorial = 1;
int sumOfFactorial = 0;

int copyNum = number;
while (copyNum>0)
{
    int digit =copyNum % 10;
    copyNum /= 10;
    for (int i = 1; i <= digit; i++)
    {
        factorial *= i;
    }
    sumOfFactorial += factorial;
    factorial = 1;
    
}


if (sumOfFactorial==number)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}