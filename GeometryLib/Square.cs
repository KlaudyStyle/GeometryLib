using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Square : ConvexQuadrilateral
    {
        private double side;

        public Square((double x, double y)[] points) : base(points)
        {
            side = Math.Sqrt(Math.Pow(Vertices[1].x - Vertices[0].x, 2) + Math.Pow(Vertices[1].y - Vertices[0].y, 2));
        }

        public override double[] GetSidesLengths()
        {
            return new double[] { side, side, side, side };
        }

        public override double[] GetDiagonalsLengths()
        {
            double diagonal = side * Math.Sqrt(2);
            return new double[] { diagonal, diagonal };
        }

        public override double[] GetAngles()
        {
            return new double[] { 90, 90, 90, 90 };
        }

        public override double GetPerimeter()
        {
            return 4 * side;
        }

        public override double GetArea()
        {
            return side * side;
        }

        public override string GetTypeFigure()
        {
            return "Квадрат";
        }
    }
}