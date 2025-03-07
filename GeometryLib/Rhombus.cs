using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Rhombus : Parallelogram
    {
        public Rhombus(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {
        }

        public override double CalculateArea()
        {
            double[] diagonals = CalculateDiagonals();
            return (diagonals[0] * diagonals[1]) / 2;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
