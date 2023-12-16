// See https://aka.ms/new-console-template for more information
string country = Console.ReadLine();
if (country == "USA" || country == "England")
{
    Console.WriteLine("English");
}
else if(country == "Spain"||country == "Argentina"||country=="Mexico")
{
    Console.WriteLine("Spanish");
}
else
{
    Console.WriteLine("unknown");
}
