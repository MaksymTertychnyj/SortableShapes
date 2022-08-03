using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortableShapes
{
    public abstract class Shape : IComparable<Shape>
    {
        public abstract double GetArea();

        public int CompareTo(Shape? otherShape)
        {
            if (otherShape == null || otherShape.GetArea() > GetArea())
            {
                return -1;
            }
            if (otherShape.GetArea() < GetArea())
            {
                return 1;
            }

            return 0;
        }
    }
}
