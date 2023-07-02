using CHallengeAPP;

namespace CHallengeApp.Tests
{
    public class Tests
    {
        [Test]// Sprawdzenie zliczania jedynie dodatnich ocen
        public void WhenEmployeeCollectsOnlyPositiveGradesShouldCorrectResult()
        {
            //arrange
            var employ1 = new Employee("Jeremi", "Wiœniowiecki", 35);
            employ1.AddGrade(10);
            employ1.AddGrade(15);
            employ1.AddGrade(5);

            //act
            var result = employ1.Result;

            //assert
            Assert.AreEqual(30, result);
        }

        [Test]// Sprawdzenie dodawania
        public void WhenEmployeeCollectsGradesShouldCorrectResult()
        {
            //arrange
            var employ2 = new Employee("Micha³", "Wo³odyjowski", 42);
            employ2.AddGrade(3);
            employ2.AddGrade(3);
            employ2.AddGrade(-4);

            //act
            var result2 = employ2.Result;

            //assert
            Assert.AreEqual(2, result2);
        }

        [Test]// Sprawdzenie dodawania
        public void CWhenEmployeeCollectsOnlyNegativeGradesShouldCorrectResultSumOperation()
        {
            //arrange
            var employ3 = new Employee("Onufry", "Zag³oba", 65);
            employ3.AddGrade(-4);
            employ3.AddGrade(-5);
            employ3.AddGrade(-8);


            //act
            var result3 = employ3.Result;

            //assert
            Assert.AreEqual(-17, result3);
        }
    }
}
