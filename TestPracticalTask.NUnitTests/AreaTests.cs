using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPracticalTask.Library;

namespace TestPracticalTask.NUnitTests
{
    public class AreaTests
    {
        private IArea[] _areas;

        [SetUp]
        protected void SetUp()
        {
            _areas = new IArea[]
            {
                new Triangle(4,4,4),
                new Circle(25),
                new Triangle(11,11,5),
                new Circle(1)
            };
        }

        [Test]
        public void AreaCalculationFromInterface()
        {
            Assert.AreEqual(Math.Round(_areas[0].CalculateArea(), 2), Math.Round(6.928, 2));
            Assert.AreEqual(Math.Round(_areas[1].CalculateArea(), 2), Math.Round(1963.5, 2));
            Assert.AreEqual(Math.Round(_areas[2].CalculateArea(), 2), Math.Round(26.78, 2));
            Assert.AreEqual(Math.Round(_areas[3].CalculateArea(), 2), Math.Round(3.14, 2));
        }
    }
}
