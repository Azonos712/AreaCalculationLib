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
            Assert.AreEqual(Math.Round(_goodCircle.CalculateArea(), 4), 78.5398);
        }
    }
}