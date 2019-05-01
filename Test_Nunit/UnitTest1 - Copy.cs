using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;
using homework_10_Nunit;

namespace Tests
{
    public class Test
    {
        [SetUp]
        public void Setup()
        {
        } 
        [TestCase(1,1,1, 63)]
        [TestCase(20, 30, 40, 150)] 
        [TestCase(30, 55, 60, 205)]
        public void number_test(int a, int b,  int c, int expected)
        {
            var actual = Program.number(a, b, c);

            Assert.AreEqual(expected, actual);
        }


    }
}