namespace FigureTest
{
    public class TriangleTest
    {
        [Fact]
        public void CalculateSquareBySidesLengthTest()
        {
            var sides = new List<double>() { 3.0, 4.0, 5.0 };
            var triangle = new Triangle(sides[0], sides[1], sides[2]);
            
            var result = triangle.CalculateSquare();

            Assert.Equal(6, result);
        }
        [Fact]
        public void CalculateSquareByPointsTest()
        {
            var triangle = new Triangle(0.0, 0.0, -3.0, 0.0, 0.0, -4.0);

            var result = triangle.CalculateSquare();

            Assert.Equal(6, result);
        }
        [Fact]
        public void CalculateNullTriangle()
        {
            var triangle =  new Triangle(0, 0, 0);
            var result = triangle.CalculateSquare();
            Assert.Equal(0, result);
        }
        [Fact]
        public void CatchNegativeSideException()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(-1.0, -2.0, 3.0));
        }
        
    }
}