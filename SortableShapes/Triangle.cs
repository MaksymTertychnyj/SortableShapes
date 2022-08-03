using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public class Triangle : Shape
    {
        public Triangle(double _base, double _height)
        {
            Area = _base * _height / 2;
        }
    }
}
