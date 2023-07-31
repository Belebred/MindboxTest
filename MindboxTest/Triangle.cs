using MindboxTest.Base;

namespace MindboxTest
{
    /// <summary>
    /// Класс геометрической фигуры треугольник
    /// </summary>
    public class Triangle : Figure
    {
        private List<double> _sides;
        private bool _isTriangleRight {  get; set; }
        /// <summary>
        /// Инициализация треугольника через длины сторон
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        public Triangle(double side1, double side2, double side3) 
        {
            _sides = new List<double>
            {
                side1,
                side2,
                side3
            };
            ValidateFigure();
            _isTriangleRight = CheckIsTriangleRight();
        }
        /// <summary>
        /// Инициализация треугольника через координаты
        /// </summary>
        /// <param name="x1"></param>
        /// <param name="y1"></param>
        /// <param name="x2"></param>
        /// <param name="y2"></param>
        /// <param name="x3"></param>
        /// <param name="y3"></param>

        public Triangle(
            double x1, double y1,
            double x2, double y2,
            double x3, double y3)
        {
            var points = new List<(double, double)>()
            {
                new (x1, y1),
                new (x2, y2),
                new (x3, y3),
            };
            GetSidesFromPoints(points);
            ValidateFigure();
            _isTriangleRight = CheckIsTriangleRight();
        }
        ///<inheritdoc/>
        public override double CalculateSquare()
        {
            var halfPerimeter = _sides.Sum(x => x) * 0.5;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _sides[0]) * (halfPerimeter - _sides[1]) *
                             (halfPerimeter - _sides[2]));
        }
        ///<inheritdoc/>
        protected override void ValidateFigure()
        {
            CheckNullSide();
            CheckBigSide();
        }

        private void GetSidesFromPoints(List<(double, double)> points)
        {
            var side1 = 
                Math.Sqrt(Math.Pow(points[0].Item1 - points[2].Item1, 2) + 
                Math.Pow(points[0].Item2 - points[2].Item2, 2));
            var side2 =
                Math.Sqrt(Math.Pow(points[1].Item1 - points[0].Item1, 2) +
                Math.Pow(points[1].Item2 - points[0].Item2, 2));
            var side3 =
                Math.Sqrt(Math.Pow(points[2].Item1 - points[1].Item1, 2) +
                Math.Pow(points[2].Item2 - points[1].Item2, 2));
            
            _sides = new List<double>() { side1, side2, side3};
        }

        private void CheckNullSide()
        {
            var resultMessage = "";
            for(var i  = 0; i < _sides.Count; i++)
            {
                if (_sides[i] < 0)
                    resultMessage += $"Сторона {i} меньше 0\n";
            }
            if (!string.IsNullOrWhiteSpace(resultMessage))
                throw new ArgumentException("Треугольник с такими сторонами не может существовать\n" + resultMessage);
        }

        private void CheckBigSide()
        {
            if (_sides.Any(x => x > (_sides.Sum() - x)))
                throw new ArgumentException("Треугольника со стороной больше суммы двух других не может существовать");
        }

        private bool CheckIsTriangleRight()
        {
            var _sidesCheck = _sides.OrderBy(s => s);
            return Math.Pow(_sides[0], 2) - Math.Pow(_sides[1] + _sides[2], 2) == 0;
        }
    }
}