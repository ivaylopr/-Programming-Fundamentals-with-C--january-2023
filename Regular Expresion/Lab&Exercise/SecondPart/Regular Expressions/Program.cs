using System.Reflection;
using System.Text.RegularExpressions;

string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
string names = Console.ReadLine();
MatchCollection nameCollection = Regex.Matches(names, pattern);
foreach (Match name in nameCollection)
{
    Console.Write(name.Value+" ");
}