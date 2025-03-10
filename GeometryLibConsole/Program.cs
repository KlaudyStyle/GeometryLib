﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryLib;
<<<<<<< HEAD
=======
using System.Globalization;
>>>>>>> 97c56c56403eff14dd9de3eaf411b8880a369099

namespace GeometryLibConsole
{
    class Program
    {
<<<<<<< HEAD
        static void Main()
        {
            ConvexQuadrilateral[] shapes =
            {
            new Square(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2)),
            new Rhombus(new Point(0, 0), new Point(3, 0), new Point(4, 4), new Point(1, 4)),
            new Parallelogram(new Point(0, 0), new Point(4, 0), new Point(5, 3), new Point(1, 3))
        };

            foreach (var shape in shapes)
            {
                Console.WriteLine(new string('=', 40));
                Console.WriteLine($"Тип фигуры: {shape.GetType().Name}\n");

                Console.WriteLine("Координаты вершин:");
                foreach (var point in shape.VERTICES)
                    Console.WriteLine($"({point.X}, {point.Y})");

                Console.WriteLine("\nДлины сторон: " +
                    string.Join(", ", Array.ConvertAll(shape.CalculateSideLengths(), x => $"{x:F2}")));

                Console.WriteLine("Углы: " +
                    string.Join(", ", Array.ConvertAll(shape.CalculateAngles(), x => $"{x:F1}°")));

                Console.WriteLine("Диагонали: " +
                    string.Join(", ", Array.ConvertAll(shape.CalculateDiagonals(), x => $"{x:F2}")));

                Console.WriteLine($"Периметр: {shape.CalculatePerimeter():F2}");
                Console.WriteLine($"Площадь: {shape.CalculateArea():F2}\n");
            }

            var square1 = new Square(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));
            var square2 = new Square(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));
            var rhombus = new Rhombus(new Point(0, 0), new Point(2, 0), new Point(2, 2), new Point(0, 2));

            Console.WriteLine(new string('=', 40));
            Console.WriteLine("Проверка метода Equals:");
            Console.WriteLine($"square1 == square2: {square1.Equals(square2)}");
            Console.WriteLine($"square1 == rhombus: {square1.Equals(rhombus)}");
            Console.ReadKey();
=======
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
>>>>>>> 97c56c56403eff14dd9de3eaf411b8880a369099
        }
    }
}
