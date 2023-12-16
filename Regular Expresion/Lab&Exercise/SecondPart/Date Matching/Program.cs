using System.Text.RegularExpressions;

string pattern = @"(?<date>\d{2})(\.|-|/|\\)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
string dateInput = Console.ReadLine();
MatchCollection validDate = Regex.Matches(dateInput, pattern);
foreach (Match item in validDate.OrderBy(x => x.Groups["day"].Value)) //nachin za sortirane v regex
{
    Console.WriteLine($"Day: {item.Groups["date"]}, Month: {item.Groups["month"]}, Year: {item.Groups["year"]}");
}