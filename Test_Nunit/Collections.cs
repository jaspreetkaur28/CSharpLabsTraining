using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;
using Homework_9_NUNIT;
using project_b;

namespace Tests
{
    public class CollectionTest
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

        [TestCase(new string[] { "hi", "there" }, new string[] { "hi", "there", "you" }, new string[] { "hi", "there", "you" })]
        public void linqunion(string[] x, string[] y, string[] expected)
        {
            var actual = linq.LINQunion(x, y);

            Assert.AreEqual(expected, actual);
        }



        [Test]
        public void Lab_42_TestMe_Test01()
        {
            //test1    //arrange
            var instance01 = new testme(); // testme has to be public class in it's own file.
            var expected = 14.0;
            //act
            var actual = instance01.BIDMAS01(10, 20, 5);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 20, 5, 14.0)] //runs multiple tests at the same time. 
        [TestCase(20, 30, 6, 25.0)] // x,y,z values and the expected value.
        [TestCase(30, 50, 10, 35.0)]
        public void Lab_42_TestMe_Test02(int a, int b, int c, double expected2)
        {
            var instance02 = new testme();
            //var expected2 = 14.0; 
            var actual2 = instance02.BIDMAS01(a, b, c);

            Assert.AreEqual(expected2, actual2);
        }


        [TestCase(1,2,3,4,5,80)]
        [TestCase(1,2,3,4,1,72)]
        [TestCase(1,1,1,1,1,60)]
        public void lab102_Collections_test(int a, int b, int c, int d, int e, int expected)
        {
            //arrange 
         // var instance02 = new testme();

            //act 
            var actual = Collections.UseCollections(a, b, c, d, e);
          // assert 
          Assert.AreEqual(expected, actual);
        }
   

    }
}