using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_42_testme;


namespace Tests_Microsoft
{

    [TestClass] 
    public class Demo_Test_For_Lab_42_TestMe
    {
        [TestMethod]
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
    }

    [TestClass]
    public class Demo_Test_For_Lab_42_TestMe2
    {
        [TestMethod]
        public void Lab_42_TestMe_Test02()
        {

 //Test2     
            var instance02 = new testme();
            var expected2 = 53.0;
            var actual2 = instance02.BIDMAS01(50, 30, 10);
            Assert.AreEqual(expected2, actual2);

        }
    }


}
