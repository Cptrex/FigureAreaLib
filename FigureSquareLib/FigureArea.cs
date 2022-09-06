using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    /// <summary>
    /// Класс для вычисления площадей заданных математических фигур.
    /// </summary>
    public class FigureArea
    {
        /// <summary>
        /// Метод CalculateAreaCircle() предназначен для вычисления площади круга по радиусу.
        /// </summary>
        /// <param name="radius">Заданный радиус круга</param>
        /// <returns>Возвращает вычисленную площадь по радиусу</returns>
        public static double CalculateAreaCircle(double radius)
        {
            if (CheckSideIsPositive(radius) == false)
            {
                throw new ArgumentException("Радиус должен быть > 0");
            }
            return Math.PI * Math.Pow(radius, 2);
        }

        /// <summary>
        /// Метод CalculateAreaTriangle() предназначен для вычисления площади треугольника по трем сторонам.
        /// </summary>
        /// <param name="sideA">Сторона треугольника А</param>
        /// <param name="sideB">Сторона треугольника B</param>
        /// <param name="sideC">Сторона треугольника C</param>
        /// <returns>Возвращает вычисленную площадь по сторонам</returns>
        public static double CalculateAreaTriangle(double sideA, double sideB, double sideC)
        {
            if (CheckSideIsPositive(sideA, sideB, sideC) == false)
            {
                throw new ArgumentException("Стороны треугольника должны быть > 0");
            }

            double semiPerimeter = GetSemiPerimeterOfTriangle(sideA, sideB, sideC);

            if(ChecIsSemiperimeterMoreThanSide(semiPerimeter, sideA, sideB, sideC) == false)
            {
                throw new ArgumentException("Полупериметер должен быть больше или равен любой из сторон");
            }

            return Math.Pow((semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC)), 0.5);
        }

        /// <summary>
        /// Метод CalculateAreaTriangle() предназначен для вычисления площади треугольника по основанию и высоте.
        /// </summary>
        /// <param name="baseSide">Основание треугольника</param>
        /// <param name="height">Высота треугольника</param>
        /// <returns>Возвращает площадь треугольника по заданному основанию и высоте треугольника</returns>
        public static double CalculateAreaTriangle(double baseSide, double height)
        {
            if (CheckSideIsPositive(baseSide, height) == false)
            {
                throw new ArgumentException("Основание и высота должны быть > 0");
            }

            return 0.5 * baseSide * height;
        }

        /// <summary>
        /// Метод IsTriangleRight() предназначен для выявления является ли заданный треугольник прямоугольным.
        /// </summary>
        /// <param name="sideA">Сторона треугольника А</param>
        /// <param name="sideB">Сторона треугольника B</param>
        /// <param name="sideC">Сторона треугольника C</param>
        /// <returns>Возвращает true если треугольник прямоугольный и false если нет</returns>
        public static bool IsTriangleRight(double sideA, double sideB, double sideC)
        {
            if(CheckSideIsPositive() == false)
            {
                throw new ArgumentException("Стороны треугольника должны быть > 0");
            }

            double maxSide = GetGreaterTriangleSide(sideA, sideB, sideC);
            double tempSideCalc = 0;

            if (maxSide <= 0) return false;

            if(maxSide == sideA) tempSideCalc = Math.Pow(sideB, 2) + Math.Pow(sideC, 2);
            else if (maxSide == sideB) tempSideCalc = Math.Pow(sideA, 2) + Math.Pow(sideC, 2);
            else if (maxSide == sideC) tempSideCalc = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
            
            return maxSide == tempSideCalc;
        }

        private static double GetGreaterTriangleSide(double sideA, double sideB, double sideC)
        {
            if (sideA > sideB && sideA > sideC) return sideA;
            else if (sideB > sideA && sideB > sideC) return sideB;
            else if (sideC > sideA && sideC > sideB) return sideC;
            else return 0;
        }
        private static double SumOfTriangleSides(double sideA, double sideB, double sideC)
        {
            return sideA + sideB + sideC;
        }
        private static double GetSemiPerimeterOfTriangle(double sideA, double sideB, double sideC)
        {
            return SumOfTriangleSides(sideA, sideB, sideC) / 2;
        }
        private static bool CheckSideIsPositive(params  double[] sides)
        {
            foreach(double side in sides)
            {
                if (side <= 0) return false;
            }

            return true;
        }
        private static bool ChecIsSemiperimeterMoreThanSide(double semiPerimeter, params double[] sides)
        {
            foreach (double side in sides)
            {
                if (semiPerimeter < side) return false;
            }

            return true;
        }
    }
}