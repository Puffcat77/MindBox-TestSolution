using AreaCalculator;


namespace AreaCalculatorTests
{
    public class CircleTests
    {
        [Fact]
        public void NegativeSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Fact]
        public void ZeroRadiusAreaTest()
        {
            Assert.Equal(0, new Circle(0).Area);
        }

        [Theory]
        [InlineData(1, Math.PI)]
        [InlineData(3, Math.PI  * 9)]
        [InlineData(2.5, Math.PI * 2.5 * 2.5)]
        public void GeneralTest(double radius, double area)
        {
            Assert.Equal(area, new Circle(radius).Area);
        }
    }
}