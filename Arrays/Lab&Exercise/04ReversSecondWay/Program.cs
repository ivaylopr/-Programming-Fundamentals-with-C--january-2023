string[] inputArray=Console.ReadLine().Split().ToArray();

for (int i = 0; i < (inputArray.Length-1)/2; i++)
{
    string first = inputArray[i];
    string last = inputArray[inputArray.Length - 1 - i];
    inputArray[i] = last;
    inputArray[inputArray.Length - 1 - i] = first;
}
Console.WriteLine(string.Join(' ',inputArray));