using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname; 
            this.Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; private set; }
        
        public string Age { get; private set; }

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();
    }
}
