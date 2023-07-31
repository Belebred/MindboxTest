using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MindboxTest.Base;

namespace MindboxTest
{
    /// <summary>
    /// Класс фигуры круг
    /// </summary>
    public class Circle : Figure
    {
        private readonly double _radius;
        public Circle(double radius) 
        {
            _radius = radius;
            ValidateFigure();
        }
        ///<inheritdoc/>
        public override double CalculateSquare()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }
        ///<inheritdoc/>
        protected override void ValidateFigure()
        {
            if (_radius < 0) throw new ArgumentException("Не может существовать круга с радиусом меньше 0");
        }
    }
}
