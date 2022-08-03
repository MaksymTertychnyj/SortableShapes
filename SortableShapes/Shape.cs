using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public abstract class Shape : IComparable<Shape>
    {
        public double Area { get; set; }

        public int CompareTo(Shape? otherShape)
        {
            if (otherShape == null || otherShape.Area > this.Area)
                return -1;
            if (otherShape.Area < this.Area)
                return 1;
            return 0;
        }
    }
}
