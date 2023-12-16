// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine())+30;
if(minutes > 60)
{
    hour += 1;
    minutes -= 60;
    if (hour >= 24)
    {
        hour = 0;

    }
}
Console.WriteLine($"{hour}:{minutes:D2}");



