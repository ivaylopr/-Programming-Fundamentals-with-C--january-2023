
using System.Text;
using System.Text.RegularExpressions;
string[] participants = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
Dictionary<string, int> results = new Dictionary<string, int>();
foreach (string participant in participants)
{
    results.Add(participant, 0);
}
string input = string.Empty;
while ((input=Console.ReadLine())!="end of race")
{
    MatchCollection namesCollection = Regex.Matches(input, @"([A-Za-z]+)");
    MatchCollection distanceCollection = Regex.Matches(input, @"(\d)");

    string name = string.Join(string.Empty, namesCollection);
    if (results.ContainsKey(name))
    {
        results [name] = distanceCollection.Select(x => int.Parse(x.Value)).Sum();
    }

}
var finalists = results.OrderByDescending(x => x.Value).Take(3);
int counter = 1;
foreach (var finalist in finalists)
{
    string suffix = counter == 1 ? "st" : counter == 2 ? "nd" : "rd";
    Console.WriteLine($"{counter++}{suffix} place: {finalist.Key}");
    
}

