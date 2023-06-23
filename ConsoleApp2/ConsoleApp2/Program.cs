string name = "Ewa";
bool ismale = false;
int age = 33; 

if (!ismale)
{
    if (age == 33 && name == "Ewa")
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Kobieta powyżej 30 lat");
    }
}
else
{
    if (age >= 18)
    {
        Console.WriteLine("Pełnolietni mężczyzna");
    }
    else
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
