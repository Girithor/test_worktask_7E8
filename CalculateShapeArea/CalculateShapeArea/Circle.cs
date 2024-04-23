using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapeArea
{
    public class Circle : Shape
    {
        new readonly string Name = "Круг";
        public override double[] side { get; set; } =  new double[1];

        /// <summary>
        /// Класс для рассчета площади круга по радиусу.
        /// </summary>
        /// <param name="Side">Массив содержащий в себе радиус круга.</param>
        public Circle(double[] Side) :base(Side)
        {
            side = Side;
        }

        public override double CalculateArea()
        {
            SetArea(GetAreaByRadius());

            return GetArea();
        }

        /// <summary>
        /// Рассчет площади по радиусу.
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double GetAreaByRadius()
        {
            double area = Math.PI * Math.Pow(side[0], 2);

            return area;
        }
    }
}
