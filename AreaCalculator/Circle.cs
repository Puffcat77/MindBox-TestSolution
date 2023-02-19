namespace AreaCalculator
{
    public class Circle : Figure
    {
        private double radius;

        public override double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new ArgumentOutOfRangeException("Radius can not be negative");
            }
            this.radius = radius;
        }
    }
}