using ChallengeApp;

Console.WriteLine("Witamy w Programie Szkolne Oceny Dla Pracowników");
Console.WriteLine("=================================================");
Console.WriteLine();

//var supervisor = new Supervisor("Arek", "Kozłowski","23");
var employee = new EmployeeInFile("Krzysiek", "Markowkski", "52");

employee.AddGrade(0.2f);
employee.AddGrade(4);
employee.AddGrade(9);
employee.AddGrade(2);
var statistics = employee.GetStatistics();
Console.WriteLine($"Statystyki dla Pracownika: {employee.Name} {employee.Surname} wiek : {employee.Age} lat");
Console.WriteLine($"Ocena Maksymalna: {statistics.Max}");
Console.WriteLine($"Ocena Średnia: {statistics.Average:N2}");
Console.WriteLine($"Ocena Minimalna: {statistics.Min}");
Console.WriteLine($"Average as Letter: {statistics.AverageLetter}");
Console.ReadLine();
//while (true)
//{
//var StatisticSupervisor = supervisor.GetStatistics();
//Console.WriteLine(" ");
//Console.WriteLine($"Kierownik {supervisor.Name} {supervisor.Surname} wiek : {supervisor.Age} lat");
//Console.WriteLine($"Ocena Minimalna: {StatisticSupervisor.Min}");
//Console.WriteLine($"Ocena Średnia: {StatisticSupervisor.Average:N2}");
//Console.WriteLine($"Ocena Końcowa: {StatisticSupervisor.AverageLetter}");

