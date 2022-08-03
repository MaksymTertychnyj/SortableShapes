using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double sideA, double sideB)
        {
            Area = sideA * sideB;
        }
    }
}
