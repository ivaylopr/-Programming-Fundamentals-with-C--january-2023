using System.ComponentModel.DataAnnotations;

string[] input =Console.ReadLine().Split("\\",StringSplitOptions.RemoveEmptyEntries);
string lastWord = input[input.Length-1];
string[] splitedLastWord = lastWord.Split('.');
Console.WriteLine($"File name: {splitedLastWord[0]}");
Console.WriteLine($"File extension: {splitedLastWord[1]}");
