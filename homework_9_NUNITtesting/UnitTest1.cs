using NUnit.Framework;
using Homework_9_NUNIT;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase(1, 2)]
        [TestCase(4, 5)]
        [TestCase(44, 45)]
        public void Homework_9_NUNIT_Test01(int a, int expected)
        {
            //arrange 

            var actual = Program.number(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}