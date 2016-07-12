using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ASP.NET._1607.Day1.Task2.Suhov.Tests
{
    [TestClass]
    public class PolidromCheckTest
    {
        [TestMethod]
        public void TestIsPolidromPolidromValues()
        {
            // Arrange
            var arr = new List<int>() { 123321, -202, 9889, -5555, 8 };
            // Act
            // Assert
            arr.ForEach(delegate (int numb) {
                Assert.IsTrue(PolidromCheck.IsPolidrom(numb));
            });
        }
        [TestMethod]
        public void TestIsPolidromNotPolidromValues()
        {
            // Arrange
            var arr = new List<int>() { 1233212, -2022, 988933, -553556, 84 };
            // Act
            // Assert
            arr.ForEach(delegate (int numb) {
                Assert.IsFalse(PolidromCheck.IsPolidrom(numb));
            });
        }

    }
}
