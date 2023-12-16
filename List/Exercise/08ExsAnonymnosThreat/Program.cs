using System;
using System.Linq;
using System.Collections.Generic;

namespace _08ExsAnonymnosThreat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine() //input
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command; //command from console
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] cmdArgs = command // command to array
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string cmdType = cmdArgs[0]; // taking first index as command

                if (cmdType == "merge") //chek about the command 
                {
                    int startIndex = int.Parse(cmdArgs[1]);
                    int endIndex = int.Parse(cmdArgs[2]);

                    FixInvalidIndexes(words, ref startIndex, ref endIndex); //method for fixing out of range indexes
                    MergeWords(words, startIndex, endIndex); //murging the words
                }
                else if (cmdType == "divide")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int partitions = int.Parse(cmdArgs[2]);

                    //abcde -> ab, bc, e (Wrong, we want the last one to be the longest)
                    //abcde -> a, b, cde 5 : 3 = 1
                    //abcdef -> ab, cd, ef
                    string word = words[index]; //taking the word from the list taht we want to devide
                    List<string> partitionsList = DivideWord(word, partitions);

                    words.RemoveAt(index);
                    words.InsertRange(index, partitionsList);
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }

        static void FixInvalidIndexes(List<string> words, ref int startIndex, ref int endIndex)
        {

        }

        static void MergeWords(List<string> words, int startIndex, int endIndex)
        {
            string mergedText = string.Empty;
            for (int i = startIndex; i <= endIndex; i++)
            {
                string currWord = words[startIndex];
                mergedText += currWord;
                words.RemoveAt(startIndex);// removing the taken word from the list
            }

            words.Insert(startIndex, mergedText); //insert the merged word at the idex that we took
        }

        static List<string> DivideWord(string word, int partitions)
        {
            int substringsLength = word.Length / partitions; //wanted length 
            int lastSubstringLength = substringsLength + word.Length % partitions; //wanted length + rest
            //int lastSubstringLength = word.Length - ((partitions - 1) * substringsLength);

            List<string> partitionsList = new List<string>();
            //All without the last one
            for (int i = 0; i < partitions; i++)
            {
                int desiredLength = substringsLength;
                if (i == partitions - 1)
                {
                    //All without the last one
                    desiredLength = lastSubstringLength;
                }

                char[] newPartitionArr = word
                    .Skip(i * substringsLength) //skip tooked elements
                    .Take(desiredLength) //taking wanted length
                    .ToArray();
                string newPartition = string.Join("", newPartitionArr);
                partitionsList.Add(newPartition);
            }

            return partitionsList;
        }
    }
}