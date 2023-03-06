using ChallengeApp;

Console.WriteLine("Witamy w Programie Szkolne Oceny Dla Pracowników");
Console.WriteLine("=================================================");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Kolejna Ocena Dla Pracownika:");
    Console.WriteLine("Naciskajac q podliczysz punkty");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistic = employee.GetStatistics();
Console.WriteLine($"AVG: {statistic.Average}");
Console.WriteLine($"AVG: {statistic.Min}");
Console.WriteLine($"AVG: {statistic.Max}");

