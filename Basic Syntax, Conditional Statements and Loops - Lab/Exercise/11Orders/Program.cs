using System.Diagnostics;

int n = int.Parse(Console.ReadLine());
decimal priceCoffeOrder = 0;
decimal totalPr = 0;
for (int i = 0; i < n; i++)
{
    decimal pricePerCapsul = decimal.Parse(Console.ReadLine());
    int days = int.Parse(Console.ReadLine());
    int capsulesCnt = int.Parse(Console.ReadLine());
    priceCoffeOrder = (days * capsulesCnt) * pricePerCapsul;
    Console.WriteLine($"The price for the coffee is: ${priceCoffeOrder:F2}");
    totalPr += priceCoffeOrder;
    priceCoffeOrder = 0;
}
Console.WriteLine($"Total: ${totalPr:F2}");