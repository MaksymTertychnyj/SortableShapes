using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public class Square : Shape
    {
        private double _side;
        public Square(double side)
        {
            _side = side;
        }

        public override double GetArea()
        {
            return Math.Pow(_side, 2);
        }
    }
}
