using System;
using System.Threading.Tasks;
using static System.Console; // This is a static directive

PrintMyName("Mohamad");

await Task.Delay(3000);

WriteLine("It is breakfast time :)");

WriteLine("Please input your email");
var email = ReadLine(); 
WriteLine($"Your email is {email}");


static void PrintMyName(string name)
{
    WriteLine($"Your name is {name}");
}