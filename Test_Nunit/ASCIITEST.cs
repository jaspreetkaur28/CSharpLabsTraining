using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;
using homework_10_Nunit;
using homework_15_ASCII;
using hw_106_InterviewPrep;

namespace Tests
{
    public class ASCII
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



        [TestCase('h', 0, 104)]
        public void Hw_106_interviewprep(char x, int index, int expected)
        {   //arrange // act // assert
            var instance = new ASCIIx();
          //  var actual = -2; 
            var actual = instance.stringnumbers(x,index);
            Assert.AreEqual(expected, actual);
        }



        [TestCase("hello", 2, 108)]
        public void Hw_106_interviewprep2(string x, int index, int expected)
        {   //arrange // act // assert
            var instance = new ASCII2x();
            //  var actual = -2; 
            var actual = instance.stringnumbers(x, index);
            Assert.AreEqual(expected, actual);
        }

    }
}