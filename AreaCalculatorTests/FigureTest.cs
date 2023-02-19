using AreaCalculator;


namespace AreaCalculatorTests
{
    public class FigureTest
    {
        [Theory]
        [InlineData(3, 4, 5, 6)]
        [InlineData(2, 3, 4, 2.9047)]
        [InlineData(2, 3, 1, 0)]
        public void TriangleFigureTest(double a, double b, double c, double area)
        {
            Figure fig = new Triangle(a, b, c);

            Assert.Equal(fig.Area, area, 4);
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(3, Math.PI * 9)]
        [InlineData(2.5, Math.PI * 2.5 * 2.5)]
        public void CircleFigureTest(double r, double area)
        {
            Figure fig = new Circle(r);

            Assert.Equal(fig.Area, area, 4);
        }
    }
}