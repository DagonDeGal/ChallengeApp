using ChallengeApp;

var employee1 = new Employee("Marek", "Kalicki", "32");
var employee2 = new Employee("Monika", "Płońska", "29");
var employee3 = new Employee("Piotr", "Młynarski", "45");

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(8);
employee1.AddScore(4);
employee1.AddScore(10);

employee2.AddScore(9);
employee2.AddScore(3);
employee2.AddScore(2);
employee2.AddScore(9);
employee2.AddScore(7);

employee3.AddScore(10);
employee3.AddScore(7);
employee3.AddScore(1);
employee3.AddScore(2);
employee3.AddScore(6);

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
    Console.WriteLine("Pracownik z najwieksza ilościa punktów: ");
    Console.WriteLine(employeeWithMaxResult.Name + "" + employeeWithMaxResult.Surname);
    Console.WriteLine("Zdobyta ilość punktów: " + maxResult);


