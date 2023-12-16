using System.Collections.Generic;
using System;
using System.Data;

int n = int.Parse(Console.ReadLine());
List<string> guestList = new List<string>();

for (int i = 0; i < n; i++)
{
    string command = Console.ReadLine();
    string[] comArg = command.Split();
    if (comArg.Length==3)
    {
        bool isThere = guestList.Any(x => x == comArg[0]);
        if (!isThere)
        {
            guestList.Add(comArg[0]);
        }
        else
        {
            Console.WriteLine($"{comArg[0]} is already in the list!");
        }
    }
    else if (comArg.Length==4)
    {
        bool isThere = guestList.Any(x => x == comArg[0]);
        if (isThere)
        {
            guestList.Remove(comArg[0]);
        }
        else
        {
            Console.WriteLine($"{comArg[0]} is not in the list!");
        }
    }
}
PrintGuestList(guestList);

static void PrintGuestList (List<string> guestList)
{
    foreach (var item in guestList)
    {
        Console.WriteLine(item);
    }
}