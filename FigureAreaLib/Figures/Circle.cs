using System;

namespace FigureAreaLib
{
    public class Circle : Figure , ICircleFigure
    {
        public override double Area { get; set; }
        public override double Perimeter { get; set; }
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override void CalculateArea()
        {
            if (CheckSideIsPositive() == false)
            {
                throw new ArgumentException("Радиус должен быть > 0");
            }
            this.Area = Math.PI * Math.Pow(Radius, 2);
        }
        public override bool CheckSideIsPositive()
        {
            if (this.Radius < 0) return false;
            return true;
        }
    }
}
