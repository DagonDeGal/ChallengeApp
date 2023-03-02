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
        public void StatisticMinimumValue()
        {
            var employee = new Employee("Marta", "Kowalska", "23");
            employee.AddGrade(8);
            employee.AddGrade(7);
            employee.AddGrade(9);

            var statistic = employee.GetStatistics();
            Assert.AreEqual(statistic.Min, 7);
        }

        [Test]
        public void StatisticMaximuxValue()
        {
            var employee = new Employee("Marta", "Kowalska", "23");
            employee.AddGrade(8);
            employee.AddGrade(7);
            employee.AddGrade(9);


            var statistic = employee.GetStatistics();
            Assert.AreEqual(statistic.Max, 9);
        }

        [Test]
        public void StatisticAverageValue()
        {
            var employee = new Employee("Marta", "Kowalska", "23");
            employee.AddGrade(8);
            employee.AddGrade(7);
            employee.AddGrade(9);


            var statistic = employee.GetStatistics();

            Assert.AreEqual(statistic.Average, 8);
        }
    }
}
