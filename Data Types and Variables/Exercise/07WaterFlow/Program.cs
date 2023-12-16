using System.Diagnostics.CodeAnalysis;

int n = int.Parse(Console.ReadLine());

byte volume = byte.MaxValue;
int waterFillIn = 0;
for (int i = 0; i < n; i++)
{
    short quantity = short.Parse(Console.ReadLine());
	if (quantity<=volume-waterFillIn)
	{
		waterFillIn+=(byte)quantity;
	}
	else
	{
        Console.WriteLine("Insufficient capacity!");

    }
}
Console.WriteLine(waterFillIn);