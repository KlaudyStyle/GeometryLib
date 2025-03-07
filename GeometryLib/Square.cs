using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
<<<<<<< HEAD
    public class Square : Rhombus
    {
        public Square(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {
            if (!IsSquare())
                throw new ArgumentException("Точки не образуют квадрат.");
        }

        private bool IsSquare()
        {
            double[] angles = CalculateAngles();
            return angles.All(angle => Math.Abs(angle - 90) < 0.001);
        }

        public override double CalculateArea()
        {
            double side = Distance(VERTICES[0], VERTICES[1]);
            return side * side;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
=======
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
>>>>>>> 97c56c56403eff14dd9de3eaf411b8880a369099
