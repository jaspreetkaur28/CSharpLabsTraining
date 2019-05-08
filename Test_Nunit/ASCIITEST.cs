using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;
using homework_10_Nunit;
using homework_15_ASCII;


namespace Tests
{
    public class Testss
    {
        [SetUp]
        public void Setup()
        {
        } 
        

 
        [TestCase(1, 1, 1, 1, 1, 5)]
        public void Homework_ASCII(int a, int b, int c, int d, int e, int expected3) {
             
            var actual3 = Collection.CollectionForTest(a, b, c, d, e);

            Assert.AreEqual(expected3, actual3);
        }

    }
}