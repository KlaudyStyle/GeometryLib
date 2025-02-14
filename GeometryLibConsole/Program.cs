using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
using System.Globalization;

namespace GeometryLibConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvexQuadrilateral[] shapes = new ConvexQuadrilateral[]
            {
                new Parallelogram(new (double, double)[] { (0, 0), (4, 0), (5, 3), (1, 3) }),
                new Rhombus(new (double, double)[] { (0, 0), (2, 0), (3, 2), (1, 2) }),
                new Square(new (double, double)[] { (0, 0), (1, 0), (1, 1), (0, 1) })
            };

            foreach (var shape in shapes)
            {
                Console.WriteLine($"Тип фигуры: {shape.GetTypeFigure()}");
                Console.WriteLine($"Периметр: {shape.GetPerimeter():F2}");
                Console.WriteLine($"Площадь: {shape.GetArea():F2}");
                Console.WriteLine($"Стороны: {string.Join(", ", shape.GetSidesLengths().Select(x => x.ToString("F2")))}");
                Console.WriteLine($"Диагонали: {string.Join(", ", shape.GetDiagonalsLengths().Select(x => x.ToString("F2")))}");
                Console.WriteLine($"Углы: {string.Join(", ", shape.GetAngles().Select(x => x.ToString("F2")))}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
