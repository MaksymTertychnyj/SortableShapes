using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            Area = Math.PI * Math.Pow(radius, 2);
        }
    }
}
