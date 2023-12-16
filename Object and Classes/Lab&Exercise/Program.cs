

string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

for (int i = 0; i < words.Length; i++)
{
    Random random = new Random();
    int randomIndex = random.Next(0,words.Length);
    string currWord = words[i];
    string toSwap = words[randomIndex];
    words[i] = toSwap;
    words[randomIndex] = currWord;
}
Console.WriteLine(string.Join(Environment.NewLine,words));
