using CHallengeAPP;

namespace CHallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]// Sprawdzenie Max dla dodanich ocen
        public void GetStatisticsMaxValuesTest()
        {
            //arrange
            Employee employee1 = new Employee("Jeremi", "Wiśniowiecki", 35);
            employee1.AddGrade(10);
            employee1.AddGrade(15);
            employee1.AddGrade(5);

            //act
            Statistics statistics = employee1.GetStatistics();

            //assert
            Assert.AreEqual(15, statistics.Max);
        }

        [Test]// Sprawdzenie Max dla ujemnych ocen
        public void GetStatisticsMaxValuesTestNegativeValues()
        {
            Employee employee1 = new Employee("Jeremi", "Wiśniowiecki", 35);
            employee1.AddGrade(-10);
            employee1.AddGrade(-15);
            employee1.AddGrade(-5);

            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(-5, statistics.Max);
        }

        [Test]// Sprawdzenie Min dla dodanich ocen
        public void GetStatisticsMinValuesTest()
        {
            Employee employee1 = new Employee("Jeremi", "Wiśniowiecki", 35);
            employee1.AddGrade(10);
            employee1.AddGrade(15);
            employee1.AddGrade(5);

            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(5, statistics.Min);
        }

        [Test]// Sprawdzenie Min dla ujemnych ocen
        public void GetStatisticsMinValuesTestNegativeValues()
        {
            Employee employee1 = new Employee("Jeremi", "Wiśniowiecki", 35);
            employee1.AddGrade(-10);
            employee1.AddGrade(-15);
            employee1.AddGrade(-5);

            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(-15, statistics.Min);
        }

        [Test]// Sprawdzenie Average dla ujemnych ocen
        public void GetStatisticsAverageNegativeValuesTest()
        {
            Employee employee1 = new Employee("Jeremi", "Wiśniowiecki", 35);
            employee1.AddGrade(-10);
            employee1.AddGrade(-15);
            employee1.AddGrade(-5);

            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(-10, statistics.Average);

        }

        [Test]// Sprawdzenie Average dla ujemnych ocen
        public void GetStatisticsAverageValuesTest()
        {
            Employee employee1 = new Employee("Jeremi", "Wiśniowiecki", 35);
            employee1.AddGrade(10);
            employee1.AddGrade(15);
            employee1.AddGrade (5);

            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(10, statistics.Average);

        }
        [Test]// Sprawdzenie Average dla ujemnych ocen
        public void GetStatisticsAverageMixTest()
        {
            Employee employee1 = new Employee("Jeremi", "Wiśniowiecki", 35);
            employee1.AddGrade(-10);
            employee1.AddGrade(15);
            employee1.AddGrade(-5);

            Statistics statistics = employee1.GetStatistics();
            Assert.AreEqual(0, statistics.Average);

        }
    }
}