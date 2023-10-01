using System.Diagnostics;
using System.Numerics;

string name = "Magda";
string gender = "Female";
var age = 30;
if (age < 30)
    if (gender == "Female")
    {
        Console.WriteLine("kobieta, poniżej 33 lat.");
    }
    else
    {
        Console.WriteLine("Niepełnoletni mężczyzna.");
    }
else if (name == "kobieta" && age == 33)
{
    Console.WriteLine("To jest Eawa i ma 33 lata ");
}
else if (gender != "Female" && age < 18)
{
    Console.WriteLine("Niepełnoletnia Kiebieta");
}
