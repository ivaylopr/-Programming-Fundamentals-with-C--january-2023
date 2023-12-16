int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < inputArray.Length-1; i++)
{
	for (int j = 0; j < inputArray.Length-1-i; j++)
	{
        inputArray[j] = inputArray[j] + inputArray[j + 1];

    }
}
Console.WriteLine(inputArray[0]);