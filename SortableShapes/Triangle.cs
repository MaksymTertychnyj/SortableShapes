using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public class Triangle : Shape
    {
        private double _base;
        private double _height;

        public Triangle(double _base, double height)
        {
            this._base = _base;
            _height = height;
        }

        public override double GetArea()
        {
            return _base * _height / 2;
        }
    }
}
