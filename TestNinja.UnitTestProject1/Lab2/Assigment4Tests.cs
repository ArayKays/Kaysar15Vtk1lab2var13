using System;
using NUnit.Framework;
using TestNinja.Fundamentals;
using static TestNinja.Fundamentals.Assignment3;

namespace TestNinja.UnitTestProject1.Lab2
{
    [TestFixture]
    public class Assigment4Tests
    {
        [Test]


        public void GetFullName_IsNameSurname_ReturnIsEquaToFullName()
        {
            /// <summary>
            /// Act
            /// </summary>
            var logger = new Assignment4();
            logger.Define("Aray", "Kaysar");

            /// <summary>
            /// Assert
            /// </summary>
            Assert.That(logger._fullname, Is.EqualTo("Aray Kaysar"));

        }
        
    }
}
