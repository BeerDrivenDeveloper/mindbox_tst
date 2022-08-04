namespace SquareCalculator.Tests
{
    public class SquareCalculatorTests
    {
        [Test]
        public void Circle_NegativeRadius_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-10));
        }
        [Test]
        public void Circle_ZeroRadius_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
        }
        [Test]
        public void Triangle_ZeroSide_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 0, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, 0));
        }
        [Test]
        public void Triangle_NegativeSide_Throws()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, -2, 3));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(1, 2, -3));
        }
        [Test]
        public void Triangle_IsRight_Checks()
        {
            var rightTriangle = new Triangle(4, 5, 3);
            Assert.IsTrue(rightTriangle.IsRight);
        }
        [Test]
        public void Triangle_IsRight_Fails()
        {
            var nonRightTriangle = new Triangle(4, 5, 2);
            Assert.IsFalse(nonRightTriangle.IsRight);
        }
        [Test]
        public void Triangle_Square_IsCorrect()
        {
            var triangle = new Triangle(6, 8, 10);
            //прямоугольник прямой; 6*8/2 = 24

            var triangleSquare = triangle.CalculateSquare();

            Assert.AreEqual(triangleSquare, 24);
        }
        [Test]
        public void Circle_Square_IsCorrect()
        {
            var circle = new Circle(2);
            //возьмём радиус = 2, тогда площадь будет равна четырём пи

            var circleSquare = circle.CalculateSquare();

            Assert.AreEqual(circleSquare, 4*Math.PI);
        }
    }
}