using System;

namespace FigureAreaLib
{
    public class Triangle : Figure, ITriangleFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public override double Area { get; set; }
        public override double Perimeter { get; set; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override void CalculateArea()
        {
            if (CheckSideIsPositive() == false)
            {
                throw new ArgumentException("Стороны треугольника должны быть > 0");
            }

            double semiPerimeter = GetSemiPerimeterOfTriangle();

            if (ChecIsSemiperimeterMoreThanSide(semiPerimeter, A, B, C) == false)
            {
                throw new ArgumentException("Полупериметер должен быть больше или равен любой из сторон");
            }

            this.Area = Math.Pow((semiPerimeter * (semiPerimeter - A) * (semiPerimeter - B) * (semiPerimeter - C)), 0.5);
        }
        public bool IsTriangleRight()
        {
            if (CheckSideIsPositive() == false)
            {
                throw new ArgumentException("Стороны треугольника должны быть > 0");
            }
            var powASide = Math.Pow(A, 2);
            var powBSide = Math.Pow(B, 2);
            var powCSide = Math.Pow(C, 2);

            if ((powASide + powBSide == powCSide) 
                || (powASide + powCSide == powBSide) 
                || (powCSide + powBSide == powASide) ) 
                return true;

            else return false;
        }
        public double GetGreaterTriangleSide()
        {
            if (A > B && A > C) return A;
            else if (B > A && B > C) return B;
            else if (C > A && C > B) return C;
            else return 0;
        }
        public double GetSemiPerimeterOfTriangle()
        {
            return SumOfTriangleSides() / 2;
        }
        public bool ChecIsSemiperimeterMoreThanSide(double semiPerimeter, params double[] sides)
        {
            foreach (double side in sides)
            {
                if (semiPerimeter < side) return false;
            }

            return true;
        }
        public override bool CheckSideIsPositive()
        {
            if (this.A < 0 || this.B < 0 || this.C < 0) return false;
            return true;
        }
        private double SumOfTriangleSides()
        {
            return A + B + C;
        }
    }
}