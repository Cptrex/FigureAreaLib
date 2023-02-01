namespace FigureAreaLib
{
    public abstract class Figure
    {
        public abstract double Area { get; set; }
        public abstract double Perimeter { get; set; }

        /// <summary>
        /// Метод CalculateArea() предназначен для вычисления площади фигуры по сторонам.
        /// </summary>
        /// <returns>Возвращает вычисленную площадь по сторонам</returns>
        public abstract void CalculateArea();

        public abstract bool CheckSideIsPositive();
    }
}