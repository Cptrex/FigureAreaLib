using FigureAreaLib;

namespace Unit_Test
{
    public class TriangleFigureTest
    {
        [Fact]
        public void GetGreaterTriangleSide_Test()
        {
            Triangle triangle = new Triangle(7.0, 23.0, 25.0);
            Assert.Equal(25.0, triangle.GetGreaterTriangleSide());
        }

        [Theory]
        [InlineData(7, 24.0, 25.0)]
        public void IsTriangleRight_Test(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.True(triangle.IsTriangleRight());
        }

        [Theory]
        [InlineData(7.0, 7.0, 25.0)]
        public void IsTriangleRight_Test2(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.False(triangle.IsTriangleRight());
        }

        [Theory]
        [InlineData(7.0, 7.0, 13.0)]
        public void CalculateAreaTriangle_Test(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            triangle.CalculateArea();
            Assert.Equal(16.887495373796554, triangle.Area);
        }
    }
}