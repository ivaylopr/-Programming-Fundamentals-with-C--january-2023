﻿List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

for (int i = 0; i < input.Count-1; i++)
{
	if (input[i] == input[i+1])
	{
		input[i] += input[i + 1];
		input.RemoveAt(i + 1);
		i = -1;
	}
}
Console.WriteLine(String.Join(' ',input));