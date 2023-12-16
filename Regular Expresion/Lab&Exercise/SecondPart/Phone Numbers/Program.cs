using System.Text.RegularExpressions;

string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
string numbers = Console.ReadLine();
MatchCollection validNums = Regex.Matches(numbers, pattern);
Console.WriteLine(string.Join(", ",validNums));

