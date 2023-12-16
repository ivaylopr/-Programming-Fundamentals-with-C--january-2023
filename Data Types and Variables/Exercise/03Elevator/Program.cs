int numberOfPeople = int.Parse(Console.ReadLine());
int capacy = int.Parse(Console.ReadLine());
int counter = 0;
while(numberOfPeople > 0)
{
    numberOfPeople-=capacy;
    counter++;  
}
Console.WriteLine(counter);
