using System.Runtime.Serialization;

namespace _08ExAnonymnosMyTry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWords=Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            string command = string.Empty;
            while ((command=Console.ReadLine())!="3:1")
            {
                string[] comandAr = command.Split(" ").ToArray();
                string commandType=comandAr[0];
                if (commandType=="merge")
                {
                    int startIndex = int.Parse(comandAr[1]);
                    int endIndex = int.Parse(comandAr[2]);
                    IndexValidation(inputWords,ref startIndex,ref endIndex);  
                    Merging(inputWords, startIndex, endIndex);  
                }
                else if (commandType=="devide")
                {
                    string word = inputWords[int.Parse(comandAr[1])];
                    int index = int.Parse(comandAr[1]);
                    int partiotions = int.Parse(comandAr[2]);
                    List<string> partitionL =Devation(word, partiotions);
                    inputWords.InsertRange(index, partitionL);
                }
            }
            Console.WriteLine(String.Join(" ",inputWords));

        }
        static void Merging(List<string> inputWords, int startIndex, int endIndex)
        {
            string mergerdText = string.Empty;
            
            for (int i = startIndex; i < endIndex; i++)
            {
                string currentW = inputWords[startIndex];
                mergerdText += currentW;
                inputWords.RemoveAt(startIndex);
                inputWords.Insert(startIndex, mergerdText);

            }
        }
        static void IndexValidation(List<string>inputWords,ref int startIndex, ref int endIdex)
        {
            if (startIndex < 0)
            {
                //First possible
                startIndex = 0;
            }

            if (startIndex >= inputWords.Count)
            {
                startIndex =inputWords.Count - 1;
            }

            if (endIdex <= 0)
            {
                endIdex = 0;
            }

            if (endIdex >= inputWords.Count)
            {
                //Last possible
                endIdex = inputWords.Count - 1;
            }
        }
        static List<string> Devation(string word,int partitions)
        {
            int partitionLength = word.Length / partitions;
            int lastPartLength = partitionLength + word.Length % 2;
            List<string> partitionsList = new List<string>();
            //All without the last one
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = partitions;
                if (i == partitions - 1)
                {
                    //All without the last one
                    desiredLength = lastPartLength;
                }

                char[] newPartitionArr = word
                    .Skip(i * partitionLength) //skip tooked elements
                    .Take(desiredLength) //taking wanted length
                    .ToArray();
                string newPartition = String.Join("", newPartitionArr);
                partitionsList.Add(newPartition);
            }

            return partitionsList;
        }
    }
    }
}