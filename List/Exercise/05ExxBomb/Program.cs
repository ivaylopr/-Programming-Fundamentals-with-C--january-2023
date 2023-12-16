List<int> inputForDetonation = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
int[] specialNumAndPower = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();
int bomb = specialNumAndPower[0];
int power = specialNumAndPower[1];
int indexOfBomb=inputForDetonation.IndexOf(bomb);
while (inputForDetonation.Any(x=>x==bomb))
{
    DetonationLeft(inputForDetonation, indexOfBomb, power, bomb);
    DetonationRight(inputForDetonation, indexOfBomb, power, bomb);
    inputForDetonation.Remove(bomb);

}
int sum = inputForDetonation.Sum();
Console.WriteLine(sum);
static void DetonationLeft(List<int>inputForDetonation, int indexOfBomb, int power, int bomb)
{
    for (int i = 0; i < power; i++) //left Elements removing
    {
        if (indexOfBomb == 0 
        || inputForDetonation[indexOfBomb] == inputForDetonation[indexOfBomb -1])
        {
           
            break;
        }

        inputForDetonation.RemoveAt(indexOfBomb - 1);
        indexOfBomb = inputForDetonation.IndexOf(bomb);
    }

}
static void DetonationRight(List<int> inputForDetonation, int indexOfBomb, int power, int bomb)
{
    int newIndexOfBomb=inputForDetonation.IndexOf(bomb);
    for (int i = 0; i < power; i++) //right ekements removing
    {
        if (newIndexOfBomb >= inputForDetonation.Count - 1 
        || inputForDetonation[newIndexOfBomb] == inputForDetonation[newIndexOfBomb+1])
        {
           break;
        }
        inputForDetonation.RemoveAt(++newIndexOfBomb);
        newIndexOfBomb = inputForDetonation.IndexOf(bomb);

    }

}