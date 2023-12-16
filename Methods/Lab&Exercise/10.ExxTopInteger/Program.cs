namespace _10.ExxTopInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endBorder = int.Parse(Console.ReadLine());
            for (int i = 0; i <= endBorder; i++)
            {
                bool isBest = false;
                int currentNum = i;
                if (currentNum/10!=0)
                {
                    int checking;
                    currentNum %= 10;

                }
                else if (currentNum/10==0)
                {
                    continue;
                }
                int oddElementCnt = 0;
                int sumOfElements = 0;

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (currentNum[j]%2!=0)
                    {
                        oddElementCnt++;
                    }
                    sumOfElements += currentNum[j];

                }
                if (sumOfElements%8==0 && oddElementCnt>0)
                {
                    Console.WriteLine();
                }

            }
        }
        
    }
}