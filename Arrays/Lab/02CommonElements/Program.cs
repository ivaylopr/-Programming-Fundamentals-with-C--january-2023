string[] firstArray = Console.ReadLine().Split().ToArray(); 
string[] secondArray = Console.ReadLine().Split().ToArray();

for (int i = 0; i < secondArray.Length; i++)
{
    string currentElement = secondArray[i];
	for (int j = 0; j < firstArray.Length; j++)
	{
		if (currentElement == firstArray[j])
		{
			Console.Write(currentElement + " ");
		}
	}
}