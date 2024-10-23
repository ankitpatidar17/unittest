using NUnit.Framework;
using ConsoleApp1;

namespace NUnitTest
{
    public class Tests
    {
        Student std;
        [SetUp]
        public void Setup()
        {
            std=new Student();
        }

        [Test]
        public void Test1()
        {
            string expectedName = "Ankit";
            string actualName = std.name();
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Test2()
        {
            string expectedemail = "apatidar213@gmail.com";
            string actualemail = std.email();
            Assert.AreEqual(expectedemail, actualemail);
        }
    }
}