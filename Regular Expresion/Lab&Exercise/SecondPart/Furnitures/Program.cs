using System.Text.RegularExpressions;

string pattern = @"^>>(?<product>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)(\.\d+)?$";
string input = string.Empty;
Regex regex = new Regex(pattern);
List<string> products = new List<string>();
double totalSpend = 0;

while ((input=Console.ReadLine())!= "Purchase")
{
	Match match = regex.Match(input);
	if (match.Success)
	{
		string productName = match.Groups["product"].Value;
		double price = double.Parse(match.Groups["price"].Value);
		int quantity = int.Parse(match.Groups["quantity"].Value);
		totalSpend+=price*quantity;
		products.Add(productName);
	}
}
Console.WriteLine("Bought furniture:");
foreach (var item in products)
{
	Console.WriteLine(item);
}
Console.WriteLine($"Total money spend: {totalSpend:f2}");