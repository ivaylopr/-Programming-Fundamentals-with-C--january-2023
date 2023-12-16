using System.Security.Cryptography;

List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
input.RemoveAll(x => x < 0);
if (input.Count<=0)
{
    Console.WriteLine("empty");
}
else
{
    input.Reverse();
    Console.WriteLine(String.Join(" ", input));
} 
    
