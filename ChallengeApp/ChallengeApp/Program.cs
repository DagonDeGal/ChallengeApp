using ChallengeApp;

var employee = new Employee("Marta", "Kowalska", "23");
employee.AddGrade("Adam");
employee.AddGrade("4000");
employee.AddGrade(18.4);
employee.AddGrade(0.873);
employee.AddGrade(6);
employee.AddGrade(2);
employee.AddGrade('5');
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

