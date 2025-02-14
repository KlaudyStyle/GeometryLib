using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public abstract class ConvexQuadrilateral
    {
        protected (double x, double y)[] Vertices;

        public ConvexQuadrilateral((double x, double y)[] vertices)
        {
            if (vertices.Length != 4)
                throw new ArgumentException("Должно быть 4 вершины!");
            Vertices = vertices;
        }

        public abstract double[] GetSidesLengths();
        public abstract double[] GetDiagonalsLengths();
        public abstract double[] GetAngles();
        public abstract double GetPerimeter();
        public abstract double GetArea();
        public abstract string GetTypeFigure();

        public override bool Equals(object obj)
        {
            if (obj is ConvexQuadrilateral other)
            {
                return Vertices.SequenceEqual(other.Vertices);
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Vertices.GetHashCode();
        }
    }
}
