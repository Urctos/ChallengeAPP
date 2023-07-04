using CHallengeAPP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace CHallengeApp.Tests
{
    public class TypeTests
    {
        [Test]// Sprawdzenie Typów referencyjnych 
        public void GetUserShouldReturnDifferentObjects()
        {
            //arrange
            var user1 = GetUser("Jan");
            var user2 = GetUser("Jan");

            //act

            //assert
            Assert.AreNotEqual(user1, user2);

        }
        // Sprawdzenie typów wartościowych
        [Test]// Test typu String
        public void GetStringShouldReturnEqualObjects()
        {
            //arrange
            String name1 = "Jan";
            String name2 = "Jan";

            //act

            //assert
            Assert.AreEqual(name1, name2);

        }

        [Test]// Test typu Float
        public void GetTwoFloatShouldReturnDifferentValues()
        {
            //arrange
            float number1 = 5.2F;
            float number2 = 6.35F;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);

        }

        [Test]// Test typu int
        public void GetIntShouldReturnEqualValues()
        {
            //arrange
            int number1 = 5;
            int number2 = 5;

            //act

            //assert
            Assert.AreEqual(number1, number2);

        }

        private User GetUser(string name)
        {
            return new User(name, "32555235" );
        }
    }
}
