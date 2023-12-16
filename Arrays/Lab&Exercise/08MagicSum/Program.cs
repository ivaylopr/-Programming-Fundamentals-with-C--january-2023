int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int magicNum = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 0; i < inputArray.Length; i++)
{
	for (int j = i+1; j < inputArray.Length; j++)
	{
        sum = inputArray[i] + inputArray[j];
        if (sum == magicNum)
        {
            Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
        }
    }
    
}