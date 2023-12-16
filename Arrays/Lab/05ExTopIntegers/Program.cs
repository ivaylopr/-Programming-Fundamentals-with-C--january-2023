int[] topInteger = new int[3];
int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < inputArray.Length; i++)
{
    int currentElement = inputArray[i];
	for (int j = 0; j < 3; j++)
	{
        if (currentElement > topInteger[j])
        {
            topInteger[j] = currentElement;
            
        }
    }
	
}
Console.WriteLine(String.Join(' ', topInteger));