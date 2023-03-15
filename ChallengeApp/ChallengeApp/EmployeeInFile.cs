using System.Runtime.CompilerServices;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname, string age)
            : base(name, surname, age)
        {
        }
        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid number");
            }
        }

        public override void AddGrade(string grade)
        {
            switch (grade)
            {
                case "A":
                case "a":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(100);
                    }
                    break;
                case "B":
                case "b":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(80);
                    }
                    break;
                case "C":
                case "c":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(60);
                    }
                    break;
                case "D":
                case "d":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(40);
                    }
                    break;
                case "E":
                case "e":
                    using (var writer = File.AppendText(fileName))
                    {
                        writer.WriteLine(20);
                    }
                    break;
                default:
                    if (float.TryParse(grade, out float result))
                    {
                        using (var writer = File.AppendText(fileName))
                        {
                            writer.WriteLine(result);
                        }
                    }
                    throw new Exception("Podaj liczbę od 1 do 100 , lub litere od A(a) do E(e)");
            }

        }

        public override void AddGrade(int grade)
        {
            this.AddGrade((float)grade);
        }


        public override void AddGrade(double grade)
        {
            this.AddGrade((float)grade);
        }

        public override void AddGrade(char grade)
        {
            this.AddGrade(grade.ToString());
        }
        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var render = File.OpenText($"{fileName}"))
                {
                    var line = render.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = render.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Min = float.MaxValue;
            statistics.Max = float.MinValue;


            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }
            statistics.Average /= grades.Count;
            
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
        private void SaveGradeFile(float grade, string fileName)
        {
            using (var writer = File.AppendText(fileName))
            {
                writer.WriteLine(grade);
            }
        }
    }
}


