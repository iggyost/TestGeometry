using GeometryCalculateLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = ShapeClass.CreateCircle(5);
            double areaCircle = ShapeClass.AreaCalculate(circle);
            Console.WriteLine($"Площадь круга: {areaCircle}");
            Triangle triangle = ShapeClass.CreateTriangle(3, 4, 5);
            string isRight = triangle.IsRight() ? "Прямоугольный" : "Непрямоугольный";
            double areaTriangle = ShapeClass.AreaCalculate(triangle);
            Console.WriteLine($"Площадь треугольника: {areaTriangle} {isRight}");

            Console.ReadKey();
        }
    }
}
