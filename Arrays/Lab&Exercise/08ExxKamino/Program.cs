int longOfAr = int.Parse(Console.ReadLine());

string input = " ";
int[] currentLongestSequance = new int[longOfAr];
int currentSequanceLenght = 0;
int currentStartingIndx = 0;
int currentSum = 0;
int dnaNum = 0;
int counter = 0;
int currentStartIndex = 0;


while ((input = Console.ReadLine())!= "Clone them!")
{
    int[] inputArray = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int lenght = 0;
    counter++;
    foreach (var item in inputArray)
    {
        if (item==1)
        {
            lenght++;
        }
        else if (item == 0 && lenght >0)
        {
            break;
        }
    }
    int startingIndex = Array.IndexOf(inputArray, 1);
    int sum = inputArray.Sum();
    if (lenght>currentSequanceLenght||lenght==currentSequanceLenght && currentStartIndex>startingIndex
        || lenght == currentSequanceLenght && currentStartIndex==startingIndex && sum>currentSum)
    {
        currentLongestSequance = inputArray;
        currentSequanceLenght = lenght;
        currentSum = sum;
        currentStartIndex = startingIndex;
        dnaNum = counter;
    }
    

}
Console.WriteLine($"Best DNA sample {dnaNum} with sum: {currentSum}.");
Console.WriteLine(String.Join(' ',currentLongestSequance));
