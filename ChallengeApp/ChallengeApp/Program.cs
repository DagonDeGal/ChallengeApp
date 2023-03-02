using ChallengeApp;

var employee1 = new Employee("Marta", "Kowalska", "42");
var employee2 = new Employee("Karol", "Michalski", "34");
var employee3 = new Employee("Natalia", "Brodnicka", "25");

employee1.AddScore(6);
employee1.AddScore(3);
employee1.AddScore(2);
employee1.AddScore(9);
employee1.AddScore(8);

employee2.AddScore(8);
employee2.AddScore(3);
employee2.AddScore(4);
employee2.AddScore(5);
employee2.AddScore(7);

employee3.AddScore(6);
employee3.AddScore(7);
employee3.AddScore(10);
employee3.AddScore(3);
employee3.AddScore(5);

List<Employee> employees = new List<Employee>()

{
    employee1, employee2, employee3
 };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }
}
Console.WriteLine("Pracownik z najwieksza liczba punktów:");
Console.WriteLine(employeeWithMaxResult.Name + "" + employeeWithMaxResult.Surname);
Console.WriteLine("Zdobyta ilość punktow:" + maxResult);