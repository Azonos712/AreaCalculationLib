using NUnit.Framework;
using System;
using TestPracticalTask.Library;

namespace TestPracticalTask.NUnitTests
{
    public class CircleTests
    {
        [Test]
        public void GoodAreaCalculation()
        {
            var _goodCircle = new Circle(5);
            Assert.AreEqual(Math.Round(_goodCircle.CalculateArea(), 4), Math.Round(78.5398, 4));
        }

        [Test]
        public void BadAreaCalculation()
        {
            Assert.Throws<InvalidDataException>(() =>
            {
                var _badCircle = new Circle(-4);
            });
        }
    }
}