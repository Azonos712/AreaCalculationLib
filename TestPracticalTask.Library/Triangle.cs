using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPracticalTask.Library
{
    public class Triangle : IArea
    {
        private double _a;
        private double _b;
        private double _c;

        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;

            if (!IsTriangle())
                throw new InvalidDataException("Invalid data");
        }

        public bool IsTriangle()
        {
            return (_a + _b > _c) && (_a + _c > _b) && (_b + _c > _a);
        }

        public double CalculateArea()
        {
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public bool IsRightTriangle()
        {
            return _c * _c == _a * _a + _b * _b;
        }
    }
}
