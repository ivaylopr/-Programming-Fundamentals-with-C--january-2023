
string[] inputArr = Console.ReadLine()
    .Split('|',StringSplitOptions.RemoveEmptyEntries)//input
    .ToArray();
List<string> outputArr = new List<string>();
//int cntLength = 0;
//List<string> element = new List<string>();
bool isFound = false;
for (int i = inputArr.Length-1; i >=0; i--)
{
    string[] addEl = inputArr[i].Split(' ',StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < addEl.Length; j++)
    {
        outputArr.Add(addEl[j]);
    }
}
Console.WriteLine(String.Join(" ",outputArr));