int num = int.Parse(Console.ReadLine());
string[] daysOfWeeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
if (num>=1 && num<=7)
{
        Console.WriteLine(daysOfWeeek[num-1]);
}
else
{
    Console.WriteLine("Invalid day!");
}