int lines = int.Parse(Console.ReadLine());
string firstNum = " ";
string secondNum = " ";
int sum = default(int);
string a = " ";
bool flag = false;
long second=0;
for (int m = 0; m < lines; m++)
{
    string input = Console.ReadLine();

    for (int i = 0; i < input.Length; i++)
    {
        char c = input[i];
        if (c != ' ' && flag != true)
        {
            firstNum += c.ToString();
        }
        else if (c == ' ')
        {
            flag = true;
            continue;
        }
        if (flag)
        {
            secondNum += c.ToString();
        }

    }
    long first = long.Parse(firstNum);
    firstNum = " ";
    if (flag)
    {
        second = int.Parse(secondNum);
        secondNum = " ";
        flag = false;
    }
    if (first > second)
    {
        while (first > 0)
        {
            long digit = first % 10;
            sum += digit;
            first /= 10;

        }
        Console.WriteLine(sum);
        sum = 0;
    }
    else
    {
        while (second > 0)
        {
            long digit = second % 10;
            sum += digit;
            second /= 10;

        }
        Console.WriteLine(sum);
        sum=0;
    }
}


