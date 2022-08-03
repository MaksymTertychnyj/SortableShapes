using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public class Rectangle : Shape
    {
        private double _sideA;
        private double _sideB;
        public Rectangle(double sideA, double sideB)
        {
            _sideA = sideA;
            _sideB = sideB;
        }

        public override double GetArea()
        {
            return _sideA * _sideB;
        }
    }
}
