int n=int.Parse(Console.ReadLine());
int[] wagons = new int [n];
int sumOfPeople=0;
for (int i = 0; i < wagons.Length; i++)
{
    int people = int.Parse(Console.ReadLine());
    wagons [i] = people;
    sumOfPeople+=people;
    
}
Console.WriteLine(string.Join(' ', wagons));
Console.WriteLine(sumOfPeople);