using System.Diagnostics;

string comand = " ";
decimal money = 0m;
decimal bank = 0m;
string product = " ";
while ((comand = Console.ReadLine()) != "Start")
{
    money = decimal.Parse(comand);
	if (money == 2m || money==1m || money==0.5m || money==0.2m || money==0.1m)
	{
		bank +=money;
	}
	else
	{
		Console.WriteLine($"Cannot accept {money}");
	}
}
while ((product=Console.ReadLine())!="End")
{
	if (product=="Nuts")
	{
		if (bank>=2m)
		{
            bank -= 2m;
            Console.WriteLine($"Purchased nuts");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
	else if (product=="Water")
	{
        if (bank >= 0.7m)
        {
            bank -= 0.7m;
            Console.WriteLine($"Purchased water");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }


    }
    else if (product == "Crisps")
    {
        if (bank >= 1.5m)
        {
            bank -= 1.5m;
            Console.WriteLine($"Purchased crisps");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else if (product == "Soda")
    {
        if (bank >= 0.8m)
        {
            bank -= 0.8m;
            Console.WriteLine($"Purchased soda");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }

    }
    else if (product == "Coke")
    {
        if (bank >= 1m)
        {
            bank -= 1m;
            Console.WriteLine($"Purchased coke");
        }
        else
        {
            Console.WriteLine("Sorry, not enough money");
        }
    }
    else
    {
        Console.WriteLine("Invalid product");
    }
}
Console.WriteLine($"Change: {bank:F2}");