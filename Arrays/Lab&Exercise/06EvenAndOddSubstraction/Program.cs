int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int sumEven = 0;
int odd=0;
for (int i = 0; i < inputArray.Length; i++)
{
	int currentElement = inputArray[i];	
	if (currentElement%2==0)
	{
		sumEven+=currentElement;
	}
	else
	{
		odd+=currentElement;
	}
}
Console.WriteLine(sumEven-odd);