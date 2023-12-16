using System.Collections.Concurrent;

double amount = double.Parse(Console.ReadLine());
int students = int.Parse(Console.ReadLine());
double lightsabersPr = double.Parse(Console.ReadLine());
double robesPr = double.Parse(Console.ReadLine());
double beltPr = double.Parse(Console.ReadLine());
double procentigeMore = students * 0.1 + students;
double lightsaberTotal = lightsabersPr * Math.Ceiling(procentigeMore);
double robesTotal = robesPr * students;
double beltTotal = 0;
int counterFree = 0;
double totalSpended = 0;
for (int i = 0; i < students; i++)
{
    beltTotal += beltPr;
    counterFree++;
    if(counterFree == 6)
    {
        beltTotal -= beltPr;
        counterFree = 0;
    }
}
totalSpended = beltTotal + lightsaberTotal + robesTotal;
if (totalSpended<=amount)
{
    Console.WriteLine($"The money is enough - it would cost {totalSpended:F2}lv.");
}
else
{
    totalSpended -= amount;
    Console.WriteLine($"John will need {totalSpended:F2}lv more.");
}