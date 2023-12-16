int n = int.Parse(Console.ReadLine());
List<string> products = new List<string>();

for (int i = 0; i < n; i++)
{
    string currentProduct = Console.ReadLine();
    products.Add(currentProduct);
}
for (int i = 0; i < products.Count; i++)
{
    products.Sort();
    Console.WriteLine($"{i+1}.{products[i]}");
}