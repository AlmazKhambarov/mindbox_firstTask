using System;

class Program
{
    static void Main()
    {
        double radius = 5;
        double sideA = 3;
        double sideB = 4;
        double sideC = 5;

        try
        {
            double circleArea = GeometryLibrary.GeometryCalculator.CalculateCircleArea(radius);
            double triangleArea = GeometryLibrary.GeometryCalculator.CalculateTriangleArea(sideA, sideB, sideC);

            Console.WriteLine($"Площадь круга с радиусом {radius}: {circleArea}");
            Console.WriteLine($"Площадь треугольника со сторонами {sideA}, {sideB}, {sideC}: {triangleArea}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
