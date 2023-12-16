int n = int.Parse(Console.ReadLine());
int[] inputArray = new int[n];
for (int i = 0; i < n; i++)
{
    int currentNum = int.Parse(Console.ReadLine());
    inputArray[i] = currentNum;

}
inputArray = inputArray.Reverse().ToArray();
Console.WriteLine(String.Join(' ',inputArray));