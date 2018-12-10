using System;
using System.Linq;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1.Lab2
{
    [TestFixture]
    public class Assigment2Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Assignment2 _assignment2;

        [SetUp]
        public void SetUp()
        {
            _assignment2 = new Assignment2();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]

        public void GetDecimalNumbers_ReturnTheGreatherArgument()
        { 
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment2.GetDecimalNumbers(40);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count(), Is.EqualTo(4));
            Assert.That(result, Does.Contain(10));
            Assert.That(result, Does.Contain(20));
            Assert.That(result, Does.Contain(30));
            Assert.That(result, Does.Contain(40));
            Assert.That(result, Is.EquivalentTo(new[] { 10,20,30,40}));
        }
    }
}
