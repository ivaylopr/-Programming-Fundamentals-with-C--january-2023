int countPeople = int.Parse(Console.ReadLine());
string type = Console.ReadLine();
string dayOfWeeek = Console.ReadLine();
decimal price = 0;

//              Friday  Saturday   Sunday
//Students      8.45     9.80       10.46
if (type == "Students")
{
    if (dayOfWeeek == "Friday")
    {
        price = 8.45m;
        price *= countPeople;

    }
    else if (dayOfWeeek == "Saturday")
    {
        price = 9.80m;
        price *= countPeople;

    }
    else if (dayOfWeeek == "Sunday")
    {
        price = 10.46m;
        price*= countPeople;
    }
    if (countPeople>=30)
    {
        price *= 0.85m;
    }
}
else if(type == "Business")
//Business      10.90    15.60       16

{
    if (countPeople >= 100)
    {
        countPeople -= 10;
    }
    if (dayOfWeeek == "Friday")
    {
        price = 10.90m;
        price *= countPeople;
    }
    else if (dayOfWeeek == "Saturday")
    {
        price = 15.60m;
        price *= countPeople;
    }
    else if (dayOfWeeek == "Sunday")
    {
        price = 16m;
        price *= countPeople;
    }
    
}
else if(type == "Regular")
//Regular        15      20         22.50

{
    if (dayOfWeeek == "Friday")
    {
        price = 15m;
        price *= countPeople;
    }
    else if (dayOfWeeek == "Saturday")
    {
        price = 20m;
        price *= countPeople;
    }
    else if (dayOfWeeek == "Sunday")
    {
        price = 22.5m;
        price *= countPeople;
    }
    if (countPeople>=10 && countPeople<=20)
    {
        price -= price*0.05m;
    }
}
Console.WriteLine($"Total price: {price:F2}");
