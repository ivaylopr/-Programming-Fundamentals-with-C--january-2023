int maxValue = int.MinValue;
int minValue = int.MaxValue;
int midValue = 0;
int first = 0;
int second = 0;
int third = 0;
for (int i = 0; i < 3; i++)
{
    int value = int.Parse(Console.ReadLine());
    
    if (value>maxValue)
	{
		maxValue = value;
	}
	if (value < minValue)
	{
		minValue = value;
	}
	if(i==0)
	{
		first = value;
	}
	else if (i==1)
	{
		second = value;
	}
	else if (i==2)
	{
		third = value;
	}

	
}
if (maxValue > first && minValue < first)
{
	midValue = first;
}
else if (maxValue > second && minValue < second)
{
    midValue = second;
}
else
{
	midValue = third;
}
Console.WriteLine($"{maxValue}");
Console.WriteLine($"{midValue}");
Console.WriteLine($"{minValue}");