using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapeArea
{
    public class Triangle : Shape
    {
        public override double[] side { get; set; } = new double[3];

        new readonly string Name = "Треугольник";

        /* Тут я привел пример как можно наполнить кастомнымы параметрами переменную, а в методе SetAdditionalParam их можно будет поменять.
            Добавление параметров не реализовал, т.к. предполагается, что они будут добавляться в ходе дорработок класса и 
                добавления новых методов расчета площади.
        */
        public override Dictionary<string, double> additionalParam { get; } = new Dictionary<string, double>()
        {
            { "CosAB", 0.5 } 
        };
   
        /// <summary>
        /// Класс для рассчета площади треугольника.
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        /// <param name="Side">Массив состоящий из длинн 3-х сторон треугольника, если вы считаете, что у вас прямоугольный 
        ///     треугольник и известно только 2 стороны, то добавьте массив из 3 элементов с 0 в последнем элементе.</param>
        public Triangle(double[] Side) : base(Side)
        {
            side = Side;
        }

        /// <inheritdoc/>
        public override double CalculateArea()
        {
            if (side[2] == 0)
            {
                SetArea(GetAreaRightTriangleBy2Side());
            } 
            else
            {
                SetArea(GetAreaBy3Side());
            }
            

            return GetArea();
        }

        /// <summary>
        /// Рассчет площади по трем сторонам.
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double GetAreaBy3Side()
        {
            var halfP = side.Sum() / 2;
            var sqrtArea = halfP * (halfP - side[0]) * (halfP - side[1]) * (halfP - side[2]);

            return Math.Sqrt(sqrtArea);
        }

        /// <summary>
        /// Рассчет площади прямоугольного треугольника по двум катетам.
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        /// <param name="sideAIndex">Индекс катета А в массиве сторон, если он не 1-й(отсчет индексов от 0).</param>
        /// <param name="sideBIndex">Индекс катета В в массиве сторон, если он не 2-й(отсчет индексов от 0).</param>
        public double GetAreaRightTriangleBy2Side(int sideAIndex = 0, int sideBIndex = 1)
        {
            var area = side[sideAIndex] * side[sideBIndex] / 2;

            return area;
        }
    }
}
