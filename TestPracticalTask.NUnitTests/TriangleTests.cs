using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPracticalTask.Library;

namespace TestPracticalTask.NUnitTests
{
    public class TriangleTests
    {
        [Test]
        public void GoodAreaCalculation()
        {
            var goodTriangle = new Triangle(3, 4, 5);
            Assert.AreEqual(goodTriangle.CalculateArea(), 6);
        }

        [Test]
        public void BadAreaCalculation()
        {
            Assert.Throws<InvalidDataException>(() =>
            {
                var badTriangle = new Triangle(1, 1, 5);
            });
        }

        [Test]
        public void RightTriangle()
        {
            var rightTriangle = new Triangle(20, 21, 29);
            Assert.AreEqual(rightTriangle.IsRightTriangle(), true);
        }
    }
}
