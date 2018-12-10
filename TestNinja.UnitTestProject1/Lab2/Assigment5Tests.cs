using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.UnitTestProject1.Lab2
{
    [TestFixture]
    public class Assigment5Tests
    {
        [Test]
        [TestCase("","sd")]
        [TestCase("sd","")]
        [TestCase(" ","")]
        public void Log_InvalidError_ThrowArgumentNullException(string name,string surname)
        {
            /// <summary>
            /// Act
            /// </summary>
            var logger = new Assignment5();

            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(()=>logger.Define(name,surname), Throws.ArgumentNullException);

        }
        
    }
}
