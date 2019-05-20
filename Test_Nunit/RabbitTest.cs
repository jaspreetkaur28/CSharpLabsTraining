using NUnit.Framework;
using lab_42_testme;
using lab_102_homework;
using homework_10_Nunit;
using RabbitPopulationExplosion;
using System;

namespace Tests
{
    public class TestRabbit
    {
        [SetUp]
        public void Setup()
        {
        } 

        [TestCase(1, 2)]
        [TestCase(2, 4)]
        [TestCase(3, 8)]
        [TestCase(5, 32)]
        public void Rabbits(int X, int expected)
        { 
            var actual = Rabbit.Explosion(X); 
            Assert.AreEqual(expected, actual); 
        }
         
    }
}