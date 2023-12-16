using System.Collections.Generic;
using System;
using System.Security.AccessControl;
using System.Reflection.Metadata.Ecma335;
using System.Reflection;

List<int> inputList = Console.ReadLine()
    .Split(" ",StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse).ToList();
string command = string.Empty;
List<int> rotatedList = new List<int>();
while ((command=Console.ReadLine())!="End")
{
    string[] comArg = command.Split();

    if (comArg[0]=="Add")
    {
        
        
        inputList.Add(int.Parse(comArg[1]));
    }
    //      Insert { number}
    //      { index} – insert the number at the given index
    else if (comArg[0]=="Insert")
    {
        int index = int.Parse(comArg[2]);
        bool isValid = IndexValidator(inputList, index);
        if (!isValid)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        inputList.Insert(int.Parse(comArg[2]),int.Parse(comArg[1]));
    }
    //      Remove { index} – remove the number at the given index
    else if (comArg[0]== "Remove")
    {
        int index = int.Parse(comArg[1]);
        bool isValid = IndexValidator(inputList, index);
        if (!isValid)
        {
            Console.WriteLine("Invalid index");
            continue;
        }
        inputList.RemoveAt(int.Parse(comArg[1]));
    }
    //      Shift left { count} – first number becomes last. This has to be repeated the specified number of times
    else if (comArg[0] == "Shift" && comArg[1]=="left")
    {
        int howManyTimes = int.Parse(comArg[2]);
        inputList=ShiftingLeft(inputList, howManyTimes);
    }
    //      Shift right { count} – last number becomes first. To be repeated the specified number of times
    else if (comArg[0] == "Shift" && comArg[1] == "right")
    {
        int howManyTimes = int.Parse(comArg[2]);
        inputList = ShiftingRight(inputList, howManyTimes);
    }

}
Console.WriteLine(String.Join(" ",inputList));
static List<int> ShiftingLeft(List<int>inputList, int howManyTimes)
{
    for (int i = 0; i < howManyTimes; i++)
    {
        int firstEl = inputList[0];
        inputList.RemoveAt(0);
        inputList.Add(firstEl);
    }
    return inputList;
}
static List<int> ShiftingRight(List<int> inputList, int howManyTimes)
{
    for (int i = 0; i < howManyTimes; i++)
    {
        int lastEl = inputList[inputList.Count-1];
        inputList.RemoveAt(inputList.Count-1);
        inputList.Insert(0,lastEl);
    }
    return inputList;
}
static bool IndexValidator(List<int>integers,int index)
{
    bool isValid;
    if (index<0 || index>integers.Count-1)
    {
        return isValid = false;
    }
    else
    {
        return isValid = true;
    }
}
