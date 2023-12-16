int startingYield = int.Parse(Console.ReadLine());
int dayCnt = 0;
int minedSpice = 0;
while (startingYield>=100)
{
    dayCnt++;
    minedSpice += startingYield - 26;
    startingYield -= 10;
}
if (dayCnt>0)
{
    minedSpice -= 26;
}
Console.WriteLine(dayCnt);
Console.WriteLine(minedSpice);