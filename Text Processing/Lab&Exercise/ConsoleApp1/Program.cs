namespace ConsoleApp1

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            GetStringSum(input[0], input[1]);
        }
    private static void GetStringSum(string nameOne, string nameTwo)
    {
        int sum = 0;
        int minLenght = Math.Min(nameOne.Length, nameTwo.Length);
        for (int i = 0; i < minLenght; i++)
        {
            sum += nameOne[i] * nameTwo[i];
        }
        string longerString = nameOne;
        if (longerString.Length < nameTwo.Length)
        {
            longerString = nameTwo;
        }
        for (int i = minLenght; i < longerString.Length; i++)
        {
            sum += longerString[i];
        }
        Console.WriteLine(sum);
    }
}
}