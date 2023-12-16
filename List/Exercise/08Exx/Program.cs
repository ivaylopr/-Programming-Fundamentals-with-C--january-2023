
string[] inputArr = Console.ReadLine()
    .Split('|', StringSplitOptions.RemoveEmptyEntries)//input
    .ToArray();
List<string> outputArr = new List<string>();
for (int i = 0; i < inputArr.Length; i++)
{
    string addedEl = inputArr[i];
    outputArr.Insert(0, addedEl);

}
Console.WriteLine(String.Join("",outputArr));