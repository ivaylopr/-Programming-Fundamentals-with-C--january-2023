using System.Security.Cryptography.X509Certificates;

string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

foreach (var currName in input) /*sh, too_long_username, !lleg@l ch@rs, jeffbutt*/
{
    if(currName.Length>3 && currName.Length<=16)
    {
        bool isValid = true;
        foreach (char item in currName)
        {
            if (!(char.IsLetter(item) || char.IsDigit(item) || item=='-' || item=='_'))
            {
                isValid = false;
                break;
            }
        }
        if (isValid)
        {
            Console.WriteLine(currName);
        }
    }    
}