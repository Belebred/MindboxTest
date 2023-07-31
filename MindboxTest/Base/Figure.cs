using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.Base
{
    /// <summary>
    /// Базовый класс геометрических фигур
    /// </summary>
    public abstract class Figure
    {

        /// <summary>
        /// Метод для получения площади фигуры
        /// </summary>
        /// <returns></returns>
        public abstract double CalculateSquare();
        /// <summary>
        /// Метод для проверки фигуры
        /// </summary>
        protected abstract void ValidateFigure();
    }
}
