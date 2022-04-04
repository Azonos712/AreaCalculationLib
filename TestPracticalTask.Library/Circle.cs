using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPracticalTask.Library
{
    public class Circle : IArea
    {
        private double _r;

        public Circle(double r)
        {
            _r = r;
        }

        public double CalculateArea()
        {
            return Math.PI * _r * _r;
        }
    }
}