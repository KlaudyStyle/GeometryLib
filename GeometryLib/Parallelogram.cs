<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Parallelogram : ConvexQuadrilateral
    {
        public Parallelogram(Point a, Point b, Point c, Point d) : base(a, b, c, d)
        {
            if (!IsParallelogram())
                throw new ArgumentException("Точки не образуют параллелограмм.");
        }

        private bool IsParallelogram()
        {
            return Distance(VERTICES[0], VERTICES[1]) == Distance(VERTICES[2], VERTICES[3]) &&
                   Distance(VERTICES[1], VERTICES[2]) == Distance(VERTICES[3], VERTICES[0]);
        }

        public override double[] CalculateSideLengths()
        {
            return new double[]
            {
            Distance(VERTICES[0], VERTICES[1]),
            Distance(VERTICES[1], VERTICES[2]),
            Distance(VERTICES[2], VERTICES[3]),
            Distance(VERTICES[3], VERTICES[0])
            };
        }

        public override double[] CalculateAngles()
        {
            double angle1 = CalculateAngle(VERTICES[0], VERTICES[1], VERTICES[2]);
            double angle2 = 180 - angle1;
            return new double[] { angle1, angle2, angle1, angle2 };
        }

        public override double[] CalculateDiagonals()
        {
            return new double[]
            {
            Distance(VERTICES[0], VERTICES[2]),
            Distance(VERTICES[1], VERTICES[3])
            };
        }

        public override double CalculatePerimeter()
        {
            double ab = Distance(VERTICES[0], VERTICES[1]);
            double bc = Distance(VERTICES[1], VERTICES[2]);
            return 2 * (ab + bc);
        }

        public override double CalculateArea()
        {
            double baseLength = Distance(VERTICES[0], VERTICES[1]);
            double height = Math.Abs(VERTICES[3].Y - VERTICES[0].Y);
            return baseLength * height;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
=======
﻿namespace GeometryLib
{
    using System;
    using System.Linq;

    public class Parallelogram : ConvexQuadrilateral
    {
        public Parallelogram((double x, double y)[] vertices) : base(vertices)
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
            double ax = Vertices[1].x - Vertices[0].x;
            double ay = Vertices[1].y - Vertices[0].y;
            double bx = Vertices[3].x - Vertices[0].x;
            double by = Vertices[3].y - Vertices[0].y;
            return Math.Abs(ax * by - ay * bx);
        }

        public override string GetTypeFigure()
        {
            return "Параллелограм";
>>>>>>> 97c56c56403eff14dd9de3eaf411b8880a369099
        }
    }
}
