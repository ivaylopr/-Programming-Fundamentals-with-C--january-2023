int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int longestSequanceLenght = 0;
int longestSequanceStarIndex = 0;

for (int i = 1; i < numbers.Length; i++)
{
    int currentSequanceIndex = i - 1;
    int currentSequanceLenght = 1;

    while (i<numbers.Length && numbers[i] == numbers[i-1])
    {
        currentSequanceLenght++;
        i++;
    }
    if (currentSequanceLenght>longestSequanceLenght)
    {
        longestSequanceLenght = currentSequanceLenght;
        longestSequanceStarIndex = currentSequanceIndex;
    }
}
for (int i = longestSequanceStarIndex; i < longestSequanceLenght+longestSequanceStarIndex; i++)
{
    Console.Write(numbers[i]+" ");
}
    