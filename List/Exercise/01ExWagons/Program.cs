List<int> listOfWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());
string command = string.Empty;
while ((command=Console.ReadLine())!="end")
{
    string[] comArg = command.Split().ToArray();
	if (comArg.Length==2)
	{
		int passangers = int.Parse(comArg[1]);
		
		if (passangers<=maxCapacity)
		{
			listOfWagons.Add(passangers);
		}
		else
		{
			continue;
		}
	}
	else if (comArg.Length==1)
	{
		int peopleIncom = int.Parse(comArg[0]);
		for (int i = 0; i < listOfWagons.Count; i++)
		{
			int peopleIn = listOfWagons[i] + peopleIncom;
			if (peopleIn<=maxCapacity)
			{
				
				listOfWagons.Insert(i,peopleIn);
				listOfWagons.RemoveAt(i + 1);
				break;
			}
		}
	}
}
Console.WriteLine(String.Join(" ", listOfWagons));

