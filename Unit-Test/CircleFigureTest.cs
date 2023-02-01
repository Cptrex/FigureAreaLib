using FigureAreaLib;

namespace Unit_Test
{
    public class CircleFigureTest
    {
        [Fact]
        public void Circle_CalculateArea_Test()
        {
            Circle circle = new Circle(15.5);
            circle.CalculateArea();
            Assert.Equal(754.76763502494782, circle.Area);
        }

        [Theory]
        [InlineData(15.5)]
        [InlineData(11)]
        [InlineData(0.1)]
        public void Circle_CheckSideIsPositive_Test1(double radius)
        {
            Circle circle = new Circle(radius);
            Assert.True(circle.CheckSideIsPositive());
        }

        [Theory]
        [InlineData(-15.5)]
        [InlineData(-11)]
        [InlineData(-0.1)]
        public void Circle_CheckSideIsPositive_Test2(double radius)
        {
            Circle circle = new Circle(radius);
            Assert.False(circle.CheckSideIsPositive());
        }
    }
}