int[] inputArray= Console.ReadLine().Split().Select(int.Parse).ToArray();

for (int i = 0; i < inputArray.Length; i++)
{
    int leftSum = 0;
    int rightSum = 0;
    for (int j = 0; j < i; j++)
    {
        leftSum += inputArray[j];
    }
    for (int j = i+1; j < inputArray.Length; j++)
    {
        rightSum += inputArray[j];

    }
    if (leftSum==rightSum)
    {
        Console.WriteLine(i);
        return;
    }
}
Console.WriteLine("no");