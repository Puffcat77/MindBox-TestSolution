namespace AreaCalculator
{
    public class Triangle : Figure
    {
        public const string NEGATIVE_SIDE_EXCEPTION_MESSAGE = "One or more sides are negative";
        public const string TRIANGLE_BASE_SIDE_RULE_EXCEPTION_MESSAGE = "Sum of two sides is less than third side";

        private double a, b, c;

        public bool IsRectangular { get; private set; }

        public double[] Cathets { get; private set; }

        public override double Area
        {
            get
            {
                if (IsRectangular)
                {
                    return Cathets[0] * Cathets[1] / 2.0;
                }
                double halfPerimeter = (a + b + c) / 2.0;
                return Math.Sqrt(halfPerimeter * 
                    (halfPerimeter-a) * (halfPerimeter - b)
                    * (halfPerimeter - c));
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentOutOfRangeException(NEGATIVE_SIDE_EXCEPTION_MESSAGE);
            }

            if (a + b < c || a + c < b || b + c < a)
            {
                throw new ArgumentOutOfRangeException(TRIANGLE_BASE_SIDE_RULE_EXCEPTION_MESSAGE);
            }

            this.a = a;
            this.b = b;
            this.c = c;

            if (a * b * c != 0 &&
                (a * a == b * b + c * c
                || b * b == c * c + a * a
                || c * c == b * b + a * a
                ))
            {
                IsRectangular = true;
                if (a * a == b * b + c * c)
                {
                    Cathets = new double[2] { b, c };
                }
                else if (b * b == c * c + a * a)
                {
                    Cathets = new double[2] { a, c };
                }
                else
                {
                    Cathets = new double[2] { a, b };
                }
            }
            else
            {
                Cathets = null;
            }
        }
    }
}