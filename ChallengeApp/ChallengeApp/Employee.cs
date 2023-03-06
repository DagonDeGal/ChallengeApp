

using ChallengeApp;

public class Employee
{
    private List<float> grades = new List<float>();
    public Employee()
    {

    }
    public Employee(string name, string surname, string age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }
    public string Name { get; private set; }
    public string Surname { get; private set; }

    public string Age { get; private set; }

    public void AddGrade(float grade)
    {
        if (grade >= 0 && grade <= 100)
        {
            this.grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid grade value");
        }
    }
    public void AddGrade(string grade)
    {
        if (float.TryParse(grade, out float result))
        {
            this.AddGrade(result);
        }
        else
        {
            Console.WriteLine("String is not float");
        }
    }
    public void AddGrade(double grade)
    {
        float result = (float)grade;
        this.AddGrade(result);
    }
    public void AddGrade(decimal grade)
    {
        float result = (float)grade;
        this.AddGrade(result);
    }
    public void AddGrade(long grade)
    {
        float result = (float)grade;
        this.AddGrade(result);
    }
    public void AddGrade(char grade)
    {
        switch (grade)
        {
            case 'A':
            case 'a':
                this.grades.Add(grade);
                break;
            case 'B':
            case 'b':
                this.grades.Add(grade);
                break;
            case 'C':
            case 'c':
                this.grades.Add(grade);
                break;
            case 'D':
            case 'd':
                this.grades.Add(grade);
                break;
            case 'E':
            case 'e':
                this.grades.Add(grade);
                break;
            default:
                this.grades.Add(grade);
                break;
        }
        }
        public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }

        statistics.Average /= this.grades.Count;

        switch (statistics.Average)
        {
            case var average when average >= 80:
                statistics.AverageLetter = 'A';
                break;
            case var average when average >= 60:
                statistics.AverageLetter = 'B';
                break;
            case var average when average >= 40:
                statistics.AverageLetter = 'C';
                break;
            case var average when average >= 20:
                statistics.AverageLetter = 'D';
                break;
            default:
                statistics.AverageLetter = 'E';
                break;
        }
        return statistics;
    }
}


