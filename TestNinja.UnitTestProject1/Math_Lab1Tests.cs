using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTestProject1
{
    [TestClass]
    class Math_Lab1Tests
    {
        //Var 13
        [TestMethod]
        public void LogicalAND_LogicalAND_ReturnsTrue()
            {
                //Arrange
                var math_Lab1 = new Fundamentals.Math_Lab1();
            //Act
            var result = math_Lab1.LogicalAND(true, true);
            

                //Assert
                Assert.IsTrue(result);
            }

        [TestMethod]
        public void LogicalAND_LogicalAND_ReturnsFalse()
            {
                //Arrange
                var math_Lab1 = new Fundamentals.Math_Lab1();
                //Act
                var result = math_Lab1.LogicalAND(false,false);
                //Assert
                Assert.IsFalse(result);
            }

        }
    }
