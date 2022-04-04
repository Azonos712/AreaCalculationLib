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
        public double R
        {
            get { return _r; }
            private set
            {
                if (value <= 0)
                    throw new Exception("Invalid data");
                _r = value;
            }
        }

        public Circle(double r)
        {
            R = r;
        }

        public double CalculateArea()
        {
            return Math.PI * _r * _r;
        }
    }
}