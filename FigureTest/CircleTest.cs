using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace FigureTest
{
    public class CircleTest
    {
        [Fact]
        public void CalculateCircleSquare()
        {
            var circle = new Circle(3.0);

            var result = circle.CalculateSquare();

            Assert.Equal(Math.PI * 9, result);
        }
        [Fact]
        public void CalculateNullCircle()
        {
            var circle = new Circle(0);
            
            var result = circle.CalculateSquare();
            
            Assert.Equal(0, result);
        }
        [Fact]
        public void CatchNegativeRadiusException()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1.0));   
        }
    }
}
