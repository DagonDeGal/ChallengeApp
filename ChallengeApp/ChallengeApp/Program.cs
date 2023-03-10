using ChallengeApp;

Console.WriteLine("Witamy w Programie Szkolne Oceny Dla Pracowników");
Console.WriteLine("=================================================");
Console.WriteLine();

Console.WriteLine("Wpisz oceny dla pracownikow i kierownika , Naciskajac q podliczysz punkty");
Console.WriteLine(" ");

var supervisor = new Supervisor("Arek", "Kozłowski","23");
var employee = new Employee("Krzysiek", "Markowkski", "52");

while (true)
{
    Console.WriteLine("Kolejna Ocena Dla Pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
while (true)
{
    Console.WriteLine("Podaj Ocene Dla Kierownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}
    
    var StatisticSupervisor = supervisor.GetStatistics();
    var StatisticEmployee = employee.GetStatistics();
Console.WriteLine(" ");
Console.WriteLine($"Kierownik {supervisor.Name} {supervisor.Surname} wiek : {supervisor.Age} lat");
Console.WriteLine(" ");
Console.WriteLine($"Ocena Minimalna: {StatisticSupervisor.Min}");
Console.WriteLine($"Ocena Maksymalna: {StatisticSupervisor.Max}");
Console.WriteLine($"Ocena Średnia: {StatisticSupervisor.Average:N2}");
Console.WriteLine($"Ocena Końcowa: {StatisticSupervisor.AverageLetter}");

Console.WriteLine(" ");
Console.WriteLine($"Pracownik {employee.Name} {employee.Surname} wiek : {employee.Age} lat");
Console.WriteLine(" ");
Console.WriteLine($"Ocena Minimalna: {StatisticEmployee.Min}");
Console.WriteLine($"Ocena Maksymalna: {StatisticEmployee.Max}");
Console.WriteLine($"Ocena Średnia: {StatisticEmployee.Average:N2}");
Console.WriteLine($"Ocena Końcowa: {StatisticEmployee.AverageLetter}");


