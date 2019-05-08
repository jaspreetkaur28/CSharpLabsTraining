using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;
using homework_10_Nunit;
//using Homework_12_Dog_Grows;
//using Homework_13_Stopwatch;
//using Homework_14_Polymorphism;


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
         



        //[TestCase(-1,-1)]
        //public void Homework_Test_12(int initialAge, int initialHeight)
        //{
        //    var expected2 = -1;
        //    var instance = new Dog();


        //    var actual2 = instance.Grow(out int finalheight);

        //    Assert.AreEqual(expected2,actual2);
        //}

        //[TestCase(-1,-1)]
        //public void Homework_Test_12(int initialAge, int initialHeight)
        //{
        //    var expected2 = -1;
        //    var instance = new Dog();


        //    var actual2 = instance.Grow(out int finalheight);

        //    Assert.AreEqual(expected2,actual2);
        //}

 

    }
}