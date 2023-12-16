using System.Data;

List<int> input= Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToList();
string command = string.Empty;
while ((command=Console.ReadLine())!="end" )
{
    string[] comArgs = command.Split();
    if (comArgs.Length==2)
    {
        int wantedEl = int.Parse(comArgs[1]);
        input.RemoveAll(x => x == wantedEl);
    }
    else if (comArgs.Length==3)
    {
        int element=int.Parse(comArgs[1]);  
        int index= int.Parse(comArgs[2]);
        input.Insert(index, element);
    }
}
Console.WriteLine(String.Join(" ",input));