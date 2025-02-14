using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    using System;
    using System.Linq;

    public class Rhombus : ConvexQuadrilateral
    {
        public Rhombus((double x, double y)[] vertices) : base(vertices)
        {
        }

        public override double[] GetSidesLengths()
        {
            double[] sides = new double[4];
            for (int i = 0; i < 4; i++)
            {
                int j = (i + 1) % 4;
                double dx = Vertices[j].x - Vertices[i].x;
                double dy = Vertices[j].y - Vertices[i].y;
                sides[i] = Math.Sqrt(dx * dx + dy * dy);
            }
            return sides;
        }

        public override double[] GetDiagonalsLengths()
        {
            double dx0 = Vertices[2].x - Vertices[0].x;
            double dy0 = Vertices[2].y - Vertices[0].y;
            double diag0 = Math.Sqrt(dx0 * dx0 + dy0 * dy0);

            double dx1 = Vertices[3].x - Vertices[1].x;
            double dy1 = Vertices[3].y - Vertices[1].y;
            double diag1 = Math.Sqrt(dx1 * dx1 + dy1 * dy1);

            return new double[] { diag0, diag1 };
        }

        public override double[] GetAngles()
        {
            double[] angles = new double[4];
            for (int i = 0; i < 4; i++)
            {
                int prev = (i + 3) % 4;
                int next = (i + 1) % 4;
                double v1x = Vertices[prev].x - Vertices[i].x;
                double v1y = Vertices[prev].y - Vertices[i].y;
                double v2x = Vertices[next].x - Vertices[i].x;
                double v2y = Vertices[next].y - Vertices[i].y;
                double dot = v1x * v2x + v1y * v2y;
                double mag1 = Math.Sqrt(v1x * v1x + v1y * v1y);
                double mag2 = Math.Sqrt(v2x * v2x + v2y * v2y);
                angles[i] = Math.Acos(dot / (mag1 * mag2)) * (180.0 / Math.PI);
            }
            return angles;
        }

        public override double GetPerimeter()
        {
            double[] sides = GetSidesLengths();
            return sides.Sum();
        }

        public override double GetArea()
        {
            double[] diagonals = GetDiagonalsLengths();
            return (diagonals[0] * diagonals[1]) / 2.0;
        }

        public override string GetTypeFigure()
        {
            return "Ромб";
        }
    }
}