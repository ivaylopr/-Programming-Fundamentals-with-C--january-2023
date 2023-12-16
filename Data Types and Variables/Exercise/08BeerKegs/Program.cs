int numberOfKegs = int.Parse(Console.ReadLine());
string bestModel = " ";
double maxVolume = 0;
for (int i = 0; i < numberOfKegs; i++)
{
    string modelKeg = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());
    double volume =Math.PI * Math.Pow((double)radius, 2) * height;
    if (maxVolume<volume)
    {
        maxVolume = volume;
        bestModel = modelKeg;
    }
}
Console.WriteLine(bestModel);