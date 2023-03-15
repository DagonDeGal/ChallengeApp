using ChallengeApp;
using System;

Console.WriteLine("Witamy w Programie Szkolne Oceny Dla Pracowników");
Console.WriteLine("=================================================");
Console.WriteLine();

//var supervisor = new Supervisor("Arek", "Kozłowski","23");
var employee = new EmployeeInMemory("Krzysiek", "Markowkski", "52");


void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano nową ocenę");
}
employee.GradeAdded += EmployeeGradeAdded;

employee.AddGrade(0.6f);


while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try 
    {
        employee.AddGrade(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }

    
    var statistics = employee.GetStatistics();
   // Console.WriteLine($"Statystyki dla Pracownika: {employee.Name} {employee.Surname} wiek : {employee.Age} lat");
    //Console.WriteLine($"Ocena Maksymalna: {statistics.Max}");
   // Console.WriteLine($"Ocena Średnia: {statistics.Average:N2}");
    //Console.WriteLine($"Ocena Minimalna: {statistics.Min}");
    //Console.WriteLine($"Average as Letter: {statistics.AverageLetter}");
}

//while (true)
//{
//var StatisticSupervisor = supervisor.GetStatistics();
//Console.WriteLine(" ");
//Console.WriteLine($"Kierownik {supervisor.Name} {supervisor.Surname} wiek : {supervisor.Age} lat");
//Console.WriteLine($"Ocena Minimalna: {StatisticSupervisor.Min}");
//Console.WriteLine($"Ocena Średnia: {StatisticSupervisor.Average:N2}");
//Console.WriteLine($"Ocena Końcowa: {StatisticSupervisor.AverageLetter}");