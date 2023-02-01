namespace FigureAreaLib
{
    public interface ITriangleFigure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        /// <summary>
        /// Проверка является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        public bool IsTriangleRight();
        public bool ChecIsSemiperimeterMoreThanSide(double semiPerimeter, params double[] sides);
        public double GetSemiPerimeterOfTriangle();
        public double GetGreaterTriangleSide();
    }
}