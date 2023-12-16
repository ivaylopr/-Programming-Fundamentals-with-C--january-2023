using System.Numerics;

int numberOfBalls = int.Parse(Console.ReadLine());
BigInteger snowballMaxV = 0;
int bestSnow = 0;
int bestTime = 0;
int bestQuality = 0;
for (int i = 0; i < numberOfBalls; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowBallQuallity = int.Parse(Console.ReadLine());
    BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowBallQuallity);
    if (value>snowballMaxV)
    {
        snowballMaxV = value;
        bestSnow = snowballSnow;
        bestTime = snowballTime;
        bestQuality=snowBallQuallity;
    }
}
Console.WriteLine($"{bestSnow} : {bestTime} = {snowballMaxV} ({bestQuality})");