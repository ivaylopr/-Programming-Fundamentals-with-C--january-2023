List<int> firstPlayer = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
List<int> secondPlayer = Console.ReadLine()
    .Split(" ")
    .Select(int.Parse)
    .ToList();
while (firstPlayer.Count>0 && secondPlayer.Count>0)
{
    
        if (firstPlayer[0] > secondPlayer[0]) // case first player win
        {
            int winingCard = firstPlayer[0];
            int loosingCard = secondPlayer[0];
            firstPlayer.RemoveAt(0);
            secondPlayer.RemoveAt(0);
            firstPlayer.Add(winingCard);
            firstPlayer.Add(loosingCard);

        }
        else if (secondPlayer[0] > firstPlayer[0]) //case second player win
        {
        int winingCard = secondPlayer[0];
        int loosingCard = firstPlayer[0]; 
        firstPlayer.RemoveAt(0);
        secondPlayer.RemoveAt(0);
        secondPlayer.Add(winingCard);
        secondPlayer.Add(loosingCard);
        }
        else if (firstPlayer[0] == secondPlayer[0]) // case are equal
        {
        firstPlayer.RemoveAt(0);
        secondPlayer.RemoveAt(0);
        }
}
if (firstPlayer.Count>0)
{
    Console.WriteLine($"First player wins! Sum: {firstPlayer.Sum()}");
}
else if (secondPlayer.Count>0)
{
    Console.WriteLine($"Second player wins! Sum: {secondPlayer.Sum()}");
}

