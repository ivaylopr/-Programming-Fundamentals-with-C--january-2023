namespace _10GreaterThenTwoValues
{
    internal static class ProgramHelpers
    {
        static string Maximus(string a, string b)
        {
            int result = a.CompareTo(b);
            if (result > 0)
            {
                return a;
            }
            else if (result < 0)
            {
                return b;
            }
        }
    }
}