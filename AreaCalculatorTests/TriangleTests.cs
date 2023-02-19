using AreaCalculator;


namespace AreaCalculatorTests
{
    public class TriangleTests
    {
        [Fact]
        public void NegativeSideTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
        }

        [Fact]
        public void BaseSideRuleTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 2, 5));
        }

        [Fact]
        public void IsRectangularTest()
        {
            Triangle tr = new(3, 5, 4);
            Assert.True(tr.IsRectangular);
            Assert.Equal(3.0, tr.Cathets[0]);
            Assert.Equal(4.0, tr.Cathets[1]);
            Assert.Equal(5.0, Math.Sqrt(tr.Cathets[0] * tr.Cathets[0] + tr.Cathets[1] * tr.Cathets[1]));
            Assert.Equal(6, tr.Area);
        }

        [Fact]
        public void GeneralTrianleTest()
        {
            Triangle tr = new Triangle(2, 3, 4);
            Assert.False(tr.IsRectangular);
            Assert.Null(tr.Cathets);
            Assert.Equal(2.9047, tr.Area, 4);
        }

        [Fact]
        public void ZeroAreaTest()
        {
            Triangle tr = new Triangle(2, 3, 1);
            Assert.False(tr.IsRectangular);
            Assert.Null(tr.Cathets);
            Assert.Equal(0 , tr.Area);
        }
    }
}