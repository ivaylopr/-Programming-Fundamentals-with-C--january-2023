// Day / Age	0 <= age <= 18	18 < age <= 64	64 < age <= 122
//Weekday           12$	            18$	            12$
//Weekend           15$	            20$	            15$
//Holiday           5$	            12$         	10$ 
string tipeOfDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
int price = 0;
if (age >=0 && age<=18)
{
    if(tipeOfDay == "Weekday")
    {
        Console.WriteLine("12$");
    }
    else if (tipeOfDay == "Weekend")
    {
        Console.WriteLine("15$");
    }
    else if (tipeOfDay == "Holiday")
    {
        Console.WriteLine("5$");
    }
}
else if (age > 18 && age<=64)
{
    if (tipeOfDay == "Weekday")
    {
        Console.WriteLine("18$");
    }
    else if (tipeOfDay == "Weekend")
    {
        Console.WriteLine("20$");
    }
    else if (tipeOfDay == "Holiday")
    {
        Console.WriteLine("12$");
    }
}
else if (age>64 && age<=122)
{
    if (tipeOfDay == "Weekday")
    {
        Console.WriteLine("12$");
    }
    else if (tipeOfDay == "Weekend")
    {
        Console.WriteLine("15$");
    }
    else if (tipeOfDay == "Holiday")
    {
        Console.WriteLine("10$");
    }
}
else
{
    Console.WriteLine("Error!");
}    


