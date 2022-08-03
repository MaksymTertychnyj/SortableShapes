using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public class Square : Shape
    {
        public Square(double side)
        {
            Area = Math.Pow(side, 2);
        }
    }
}
