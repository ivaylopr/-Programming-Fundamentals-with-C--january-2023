namespace _08MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double basa = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double powered = PowerMeth(basa, power);
            Console.WriteLine(powered);
        }
        static double PowerMeth(double basa, double power)
        {
            double result = 1;
            for (int i = 1; i <=power; i++)
            {
                result *= basa;
            }
            return result;
        }
    }
}