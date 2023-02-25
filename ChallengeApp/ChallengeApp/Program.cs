//! <-- negacja  && <-- i || <-- lub

string name = "Ewa";
bool woman =  true;
var age = 33;

if (woman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (woman = false && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

