namespace _11SumOfOddAndEvenDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputNumber = Console.ReadLine();
            int oddSum = GetSumMultiplayed(inputNumber, false);
            int evenSum = GetSumMultiplayed(inputNumber, true);

            int result = evenSum * oddSum;
            Console.WriteLine(result);
            
        }
        static int GetSumMultiplayed(string num, bool isEven)
        {
           
            int sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] >= 48 && num[i] <= 57)
                {
                    int currenNum = int.Parse(num[i].ToString());

                    if (currenNum % 2 == 0 && isEven)
                    {
                        sum += currenNum;
                    }
                    else if (num[i] % 2 != 0 && !isEven)
                    {
                        sum += currenNum;
                    }
                }
                

            }
            return sum;
        }
    }
}