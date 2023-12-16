int pokemonPower = int.Parse(Console.ReadLine());
int distance = int.Parse(Console.ReadLine());
int cntTargetReached = 0;
int exhouxFacotry=int.Parse(Console.ReadLine());
int halfPower = pokemonPower / 2;
while (pokemonPower>= distance)
{
    pokemonPower -= distance;
    cntTargetReached++;
    if (pokemonPower==halfPower)
    {
        if (pokemonPower>exhouxFacotry && exhouxFacotry!=0)
        {
            pokemonPower /= exhouxFacotry;
            
        }
        
    }
}
Console.WriteLine(pokemonPower);
Console.WriteLine(cntTargetReached);