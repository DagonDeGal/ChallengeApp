using ChallengeApp;

Console.WriteLine("Witamy w Programie Szkolne Oceny Dla Pracowników");
Console.WriteLine("=================================================");
Console.WriteLine();

var employee = new Employee();
//try 
//    Employee emp = null;
  //  var name = emp.Surname;
//}
//{
 //   Console.WriteLine(exception);
//}
//finally 
//{
//    Console.WriteLine("Finally here");
//}

while (true)
{
    Console.WriteLine("Kolejna Ocena Dla Pracownika:");
    Console.WriteLine("Naciskajac q podliczysz punkty");
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
    var statistic = employee.GetStatistics();
    Console.WriteLine($"Average: {statistic.Average}");
    Console.WriteLine($"Average: {statistic.Min}");
    Console.WriteLine($"Average: {statistic.Max}");


