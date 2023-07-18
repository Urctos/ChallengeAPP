using CHallengeAPP;

namespace CHallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]// Sprawdzenie Max dla  ocen
        public void GetStatisticsMaxValuesTest()
        {
            //arrange
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(55);
            employee.AddGrade(5);
            employee.AddGrade(13);
            employee.AddGrade(11);

            //act
            var statistics = employee.GetStatistics();

            //assert
            Assert.AreEqual(55, statistics.Max);
        }

        [Test]// Sprawdzenie Min dla 
        public void GetStatisticsMinValuesTest()
        {
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(55);
            employee.AddGrade(5);
            employee.AddGrade(13);
            employee.AddGrade(11);

            var statistics = employee.GetStatistics();
            Assert.AreEqual(5, statistics.Min);
        }

        [Test]// Sprawdzenie średniej 
        public void GetStatisticsAverageNegativeValuesTest()
        {
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(10);
            employee.AddGrade(15);
            employee.AddGrade(55);
            employee.AddGrade(5);
            employee.AddGrade(13);
            employee.AddGrade(10);

            var statistics = employee.GetStatistics();
            Assert.AreEqual(18, statistics.Average);

        }

        [Test]
        public void GetStatisticsAverageReturnCorrectLetterA()
        {
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(81);
            employee.AddGrade(80);
            employee.AddGrade(85);


            Statistics statistics = employee.GetStatistics();
            Assert.AreEqual('A', statistics.AverageLetter);

        }
        [Test]
        public void GetStatisticsAverageReturnCorrectLetterB()
        {
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(75);
            employee.AddGrade(69);
            employee.AddGrade(71);

            Statistics statistics = employee.GetStatistics();
            Assert.AreEqual('B', statistics.AverageLetter);
        }

        [Test]
        public void GetStatisticsAverageReturnCorrectLetterC()
        {
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(44);
            employee.AddGrade(41);
            employee.AddGrade(50);
 

            Statistics statistics = employee.GetStatistics();
            Assert.AreEqual('C', statistics.AverageLetter);
        }

        [Test]
        public void GetStatisticsAverageReturnCorrectLetterD()
        {
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(18);
            employee.AddGrade(29);
            employee.AddGrade(16);

            Statistics statistics = employee.GetStatistics();
            Assert.AreEqual('D', statistics.AverageLetter);
        }

        [Test]
        public void GetStatisticsAverageReturnCorrectLetterE()
        {
            var employee = new Employee("Wincent", "Adam");
            employee.AddGrade(3);
            employee.AddGrade(4);
            employee.AddGrade(3);

            Statistics statistics = employee.GetStatistics();
            Assert.AreEqual('E', statistics.AverageLetter);
        }
    }
}