using System;

namespace CalculateShapeArea
{
    /// <summary>
    /// Класс для поиска площади, если неизвестна фигура, но есть входные данные в виде массива из длин сторон.
    /// </summary>
    public static class SomeShape
    {

        private static double[] _side { get; set; }

        /// <summary>
        /// Поиск площади, если вернулся 0, то значит функциональность по данным параметрам еще не была добавлена.
        /// </summary>
        /// <param name="side"></param>
        /// <returns>Площадь неизвестной фигуры</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static double GetArea(double[] side)
        {
            if (side == null || side.Length == 0)
            {
                throw new NullReferenceException();
            }

            double area = 0;

            if (side.Length == 1)
            {
                var shape = new Circle(side);
                area = shape.CalculateArea();
            }
            else if (side.Length == 2)
            {
                double[] triangleSide = { side[0], side[1], 0 }; 
                var shape = new Triangle(triangleSide);
                area = shape.CalculateArea();
            }
            else if (side.Length == 3)
            {
                var shape = new Triangle(side);
                area = shape.CalculateArea();
            }


            return area;
        }
    }
}
