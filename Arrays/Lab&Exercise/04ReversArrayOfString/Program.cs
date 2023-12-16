string[] inputArray = Console.ReadLine().Split().ToArray();
inputArray = inputArray.Reverse().ToArray();
Console.WriteLine(string.Join(' ', inputArray));
