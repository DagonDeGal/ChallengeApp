using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {

        [Test]
        public void CorrectMaxLetter()
        {
            var employee = new Employee();
            employee.AddGrade(8);
            employee.AddGrade(9);


            var statistic = employee.GetStatistics();

            Assert.AreEqual(statistic.Max, 9);
        }
        [Test]
        public void CorrectAverage()
        {
            var employee = new Employee();
            employee.AddGrade('a');
            employee.AddGrade('c');
           

            var statistic = employee.GetStatistics();
            Assert.AreEqual(statistic.Average, 98);
        }

        [Test]
        public void CorrectAverageLetter()
        {
            var employee = new Employee();
            employee.AddGrade(80);
            employee.AddGrade(40);
            


            var statistic = employee.GetStatistics();
            Assert.AreEqual(statistic.AverageLetter, 'B');
        }
        }
    }

