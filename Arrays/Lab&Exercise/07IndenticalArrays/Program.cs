using System;

int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sumEqual = 0;
bool flag=true;
for (int i = 0; i < firstArray.Length; i++)
{
    int currentElement = firstArray[i];
	if (currentElement != secondArray[i])
	{
		Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
		flag = false;
		break;
	}
	else
	{
		sumEqual+=currentElement;
	}
}
if (flag)
{
	Console.WriteLine($"Arrays are identical. Sum: {sumEqual}");
}