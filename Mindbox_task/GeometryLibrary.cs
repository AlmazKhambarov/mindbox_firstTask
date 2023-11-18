using System;

namespace GeometryLibrary
{
    public class GeometryCalculator
    {
        // Метод для вычисления площади круга по радиусу
        public static double CalculateCircleArea(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть отрицательным");
            }

            return Math.PI * Math.Pow(radius, 2);
        }

        // Метод для вычисления площади треугольника по трем сторонам с использованием формулы Герона
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Длины сторон должны быть положительными числами");
            }

            if (!IsTriangleValid(sideA, sideB, sideC))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует");
            }

            // Полупериметр треугольника
            double s = (sideA + sideB + sideC) / 2;

            // Формула Герона для вычисления площади треугольника
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        // Метод для проверки существования треугольника по трем сторонам
        private static bool IsTriangleValid(double sideA, double sideB, double sideC)
        {
            return (sideA + sideB > sideC) && (sideA + sideC > sideB) && (sideB + sideC > sideA);
        }
    }
}
