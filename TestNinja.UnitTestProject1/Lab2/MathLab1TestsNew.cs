using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1.Lab2
{
    [TestFixture]
    public class MathLab1TestsNew
    {
        //Var 13

        /// <summary>
        /// Setup
        /// </summary>
        private Math_Lab1 _mathlab1;

        [SetUp]
        public void SetUp()
        {
            _mathlab1 = new Math_Lab1();
        }

        /// <summary>
        /// Tests
        /// </summary>
        [Test]
        [TestCase(false, false, false)]
        [TestCase(false, true, false)]
        [TestCase(true, false, false)]
        [TestCase(true, true, true)]

        /// <summary>
        /// Error Tests
        /// </summary>
        //[TestCase(false, false, true)]
        //[TestCase(false, true, true)]
        //[TestCase(true, false, true)]
        //[TestCase(true, true, false)]
        public void LogicalAND_LogicalAND_ReturnTheGreatherArgument(bool a, bool b, bool expectedResult)
        {
            /// <summary>
            /// Act
            /// </summary>
            var result = _mathlab1.LogicalAND(a, b);


            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}