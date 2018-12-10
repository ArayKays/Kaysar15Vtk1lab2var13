using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.UnitTestProject1.Lab2
{
    [TestFixture]
    public class Assigment3Tests
    {
        /// <summary>
        /// Setup
        /// </summary>
        private Assignment3 _assignment3;

        [SetUp]
        public void SetUp()
        {
            _assignment3 = new Assignment3();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        [TestCase(50, 50, 50)]


        /// <summary>
        /// Error Tests
        /// </summary>
        //[TestCase(5, "Monday", "day off")]

        public void SendMoney_WhenCalled_ReturnComplete(int myMoney, int sendMoney, int terMoney)
        { 
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment3.SendMoney(myMoney, sendMoney, terMoney);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.TypeOf<Complete>());
            Assert.That(result, Is.InstanceOf<Complete>());
        }
        [Test]
        [TestCase(50, 50, 0)]
        public void SendMoney_WhenCalled_ReturnError(int myMoney, int sendMoney, int terMoney)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _assignment3.SendMoney(myMoney, sendMoney, terMoney);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.TypeOf<Error>());
            Assert.That(result, Is.InstanceOf<Error>());
        }
    }
}
