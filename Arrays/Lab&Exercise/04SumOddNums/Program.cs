int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int evenSum = 0;

for (int i = 0; i < inputArray.Length; i++)
{
    int currentElement = inputArray[i];
	if (currentElement%2==0)
	{
		evenSum += currentElement;
	}
}
Console.WriteLine(evenSum);