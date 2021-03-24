using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.UnitTests
{
    public class MemCalculatorTests
    {
        private static MemCalculator MakeCalculator()
        {
            return new MemCalculator();
        }

        [Test]
        public void Sum_ByDefault_ReturnsZero()
        {
            MemCalculator calculator = MakeCalculator();
            int lastSum = calculator.Sum();
            Assert.AreEqual(0, lastSum);
        }

        [Test]
        public void Add_WhenCalled_ChangesSum()
        {
            MemCalculator calculator = MakeCalculator();
            calculator.Add(1);
            int sum = calculator.Sum();
            Assert.AreEqual(1, sum);
        }
    }
}
