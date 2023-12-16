using System.ComponentModel.DataAnnotations;

List<int> firstL = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> secondL = Console.ReadLine().Split().Select(int.Parse).ToList();
List<int> result = new List<int>();
int min = Math.Min(firstL.Count, secondL.Count);
for (int i = 0; i < min; i++)
{
    result.Add(firstL[i]);
    result.Add(secondL[i]);
}
if (firstL.Count>secondL.Count)
{
    for (int i = min; i < firstL.Count; i++)
    {
        result.Add(firstL[i]);
    }
}
else
{
    for (int i = min; i < secondL.Count; i++)
    {
        result.Add(secondL[i]);
    }
}
Console.WriteLine(string.Join(" ",result));