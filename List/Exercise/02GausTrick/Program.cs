List<int> inputL = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> result = new List<int>();
for (int i = 0; i < inputL.Count/2; i++)
{
    int sumOf = 0;
    sumOf = inputL[i] + inputL[inputL.Count - 1 - i];
    result.Add(sumOf);
    
}
if (inputL.Count % 2 != 0)
{
    result.Add(inputL[inputL.Count / 2]);
}
Console.WriteLine(String.Join(" ",result));