using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1.Lab2
{
    [TestFixture]
    public class Assigment1Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Assignment1 _assignment1;

        [SetUp]
        public void SetUp()
        {
            _assignment1 = new Assignment1();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        [TestCase(5, "Monday", "Work")]
        [TestCase(6, "Monday", "Work")]
        [TestCase(5, "saturday", "day off")]
        [TestCase(6, "sunday", "day off")]
        [TestCase(5, "sat", "day inncorect")]
        [TestCase(6, "sun", "day inncorect")]
        [TestCase(4, "Monday", "error!")]
        [TestCase(7, "sunday", "error!")]

        /// <summary>
        /// Error Tests
        /// </summary>
        //[TestCase(5, "Monday", "day off")]
        //[TestCase(6, "Monday", "day off")]
        //[TestCase(5, "saturday", "Work")]
        //[TestCase(6, "sunday", "Work")]
        //[TestCase(5, "sat", "Work")]
        //[TestCase(6, "sun", "Work")]
        //[TestCase(4, "Monday", "Work")]
        //[TestCase(7, "sunday", "Work")]
        public void WorkDay_ReturnTheGreatherArgument(int workday, string day, string expectedResult)
        { 
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment1.WorkDay(workday,day);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.EqualTo(expectedResult).IgnoreCase);
        }
    }
}
