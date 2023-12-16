using System.Collections.Generic;
using System;
using System.Diagnostics.Tracing;
using System.ComponentModel;

List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
string command = string.Empty;
bool flag = false;
while ((command=Console.ReadLine())!="end")
{
    string[] comandArr = command.Split(" ").ToArray();
    //⦁	Add { number}: add a number to the end of the list.
    if (comandArr[0]=="Add")
    {
        input.Add(int.Parse(comandArr[1]));
        flag = true;

    }
    //⦁	Remove { number}: remove a number from the list.
    else if (comandArr[0]=="Remove")
    {
        input.Remove(int.Parse(comandArr[1]));
        flag = true;

    }

    //⦁	RemoveAt { index}: remove a number at a given index.
    else if (comandArr[0]=="RemoveAt")
    {
        input.RemoveAt(int.Parse(comandArr[1]));
        flag = true;

    }
    //⦁	Insert { number} { index}: insert a number at a given index.
    else if (comandArr[0]=="Insert")
    {
        int number=int.Parse(comandArr[1]);
        int index=int.Parse(comandArr[2]);
        input.Insert(index, number);
        flag = true;
    }
    //⦁	Contains { number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
    else if (comandArr[0]=="Contains")
    {
        int number =int.Parse(comandArr[1]);
        if (input.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }

    }
    //⦁	PrintEven – print all the even numbers, separated by a space.
    else if (comandArr[0]=="PrintEven")
    {
        List<int> result = new List<int>();
        result=input.Where(x=> x%2==0).ToList();
        Console.WriteLine(String.Join(" ", result));

        
    }
    //⦁	PrintOdd – print all the odd numbers, separated by a space.
    else if (comandArr[0] == "PrintOdd")
    {
        
        List<int> result = new List<int>();
        result=input.Where(x => x % 2 != 0).ToList();
        Console.WriteLine(String.Join(" ", result));

    }
    //⦁	GetSum – print the sum of all the numbers.
    else if (comandArr[0]=="GetSum")
    {
        int sum = 0;
        sum=input.Sum();
        Console.WriteLine(sum);
    }
    //⦁	Filter { condition}{ number} – print all the numbers that fulfill the given condition.The condition will be either '<', '>', ">=", "<=".
    else if (comandArr[0]=="Filter")
    {
        int number = int.Parse(comandArr[2]);
        if (comandArr[1]=="<")
        {
            List<int> result = new List<int>();
            result=input.Where(x => x < number).ToList();
            Console.WriteLine(String.Join(" ",result));
           
        }
        else if (comandArr[1]==">")
        {
            List<int> result = new List<int>();
            result =input.Where(x => x > number).ToList();
            Console.WriteLine(String.Join(" ", result));

        }
        else if (comandArr[1]==">=")
        {
            List<int> result = new List<int>();
            result=input.Where(x => x >= number).ToList();
            Console.WriteLine(String.Join(" ", result));

        }
        else if (comandArr[1]=="<=")
        {
            List<int> result = new List<int>();
            result=input.Where(x => x <= number).ToList();
            Console.WriteLine(String.Join(" ", result));
        }
    }

}
if (flag)
{
Console.WriteLine(String.Join(" ",input));
}
