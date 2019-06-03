using NUnit.Framework;
using hw_109_linq_aggregate;


namespace Tests
{
    public class LINQ
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 21)]
        [TestCase(new int[] { 2, 2, 4, 4, 6, 6 }, 24)]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1 }, 6)]
        public void hw_109_Aggregate(int[] aa, int expected)
        {   var actual = LINQAggregate.LINQAggregateSum(aa);
            Assert.AreEqual(expected, actual); 
        }


        [TestCase(new string[] { "Hello", "World" }, new string[] { "Hello", "World", "there" },
                                                                                new string[] { "Hello", "World", "there" })]
        [TestCase(new string[] { "are", "you", "there" }, new string[] { "are", "you", "here" },
                                                                                new string[] { "are", "you", "there", "here" })]
        [TestCase(new string[] { "ok", "then", "yeah" }, new string[] { "ok", "you" },
                                                                                new string[] { "ok", "then", "yeah", "you" })]
        public void hw_109_UNION(string[] x, string[] y, string[] expected)
        {
            var actual = LINQAggregate.LINQUnion(x, y);
            Assert.AreEqual(expected, actual);
        }


        [TestCase(new string[] { "Hello", "World" }, new string[] { "Hello", "World", "there" },
                                                                               new string[] { "Hello", "World" })]
        [TestCase(new string[] { "what", "is" }, new string[] { "this", "is", "what" },
                                                                               new string[] { "what", "is" })]
        [TestCase(new string[] { "blue", "yellow" }, new string[] { "blue", "red", "green" },
                                                                               new string[] { "blue" })]
        public void hw_109_Intersect(string[] x, string[] y, string[] expected)
        {
            var actual = LINQAggregate.LINQIntersect(x, y);
            Assert.AreEqual(expected, actual);

        }





         

    }
}