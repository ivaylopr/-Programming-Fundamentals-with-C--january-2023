int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
SortedDictionary<int, int> sortedN = new SortedDictionary<int, int>();
foreach (int n in numbers)
{
	if (!sortedN.ContainsKey(n))
	{
		sortedN.Add(n, 0);
	}
	sortedN[n]++;
}
foreach (var item in sortedN)
{
	Console.WriteLine($"{item.Key} -> {item.Value}");
}