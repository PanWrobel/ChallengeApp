string name = "Ewa";
string gender = "female";
int age = 33;

if (gender == "female")
{
    if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30-tego roku życia");
    }
    else if (name == "Ewa" && age == 33)
    {
        Console.WriteLine("Ewa , lat 33");
    }
}
else if (age < 18) 
{
    Console.WriteLine("Męszczyzna , niepełnoletni");
}