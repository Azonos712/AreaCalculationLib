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
            var goodCircle = new Circle(5);
            Assert.AreEqual(Math.Round(goodCircle.CalculateArea(), 4), Math.Round(78.5398, 4));
        }

        [Test]
        public void BadAreaCalculation()
        {
            Assert.Throws<InvalidDataException>(() =>
            {
                var badCircle = new Circle(-4);
            });
        }
    }
}