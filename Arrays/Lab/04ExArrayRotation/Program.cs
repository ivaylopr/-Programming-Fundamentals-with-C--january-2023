string[] inputArray = Console.ReadLine().Split(); //51 47 32 61 21
int rotation = int.Parse(Console.ReadLine());

for (int i = 0; i < rotation; i++)
{
	string firstElement = inputArray[0];
	for (int j = 0; j < inputArray.Length-1; j++)
	{
        inputArray[j] = inputArray[j + 1];
    }
	inputArray[inputArray.Length - 1] = firstElement;
}
Console.WriteLine(string.Join(" ",inputArray));