using System.Security.Cryptography.X509Certificates;

string userName = Console.ReadLine();
string expectedPass = new string(userName.Reverse().ToArray());
string pass = " ";
int cnt = 0;
bool flag = false;
while ((pass = Console.ReadLine())!=expectedPass)
{
    
    if (cnt >= 3)
    {
        flag = true;
        break;
    }
    Console.WriteLine("Incorrect password. Try again.");
    cnt++;
}
if (flag)
{
    Console.WriteLine($"User {userName} blocked!");
}
else
{
    Console.WriteLine($"User {userName} logged in.");
}