using System;
using System.Collections.Generic;


namespace CalculateShapeArea
{
    using Errors = ResoucesConstant.ErrorMessages;
    public class Shape
    {
        private double _area = 0;


        public virtual double[] side { get; set; } = new double[0];

        public virtual Dictionary<string, double> additionalParam { get; } = new Dictionary<string, double>();

        public readonly string Name;

        public Shape(double[] Side) { 
            if (Side.Length != side.Length)
            {
                throw new Exception(string.Format(Errors.IndexSideError, side.Length.ToString()));
            }
        }

        public virtual double GetArea()
        {
            return _area;
        }

        public void SetArea(double area)
        {
             _area = area;
        }

        /// <summary>
        /// Для добавление дополнительных параметров.
        /// </summary>
        public void SetAdditionalParam(string paramName, double value)
        {
            additionalParam[paramName] = value;
        }

        /// <summary>
        /// Базовый метод для расчета площади фигуры.
        /// </summary>
        /// <returns>Площадь фигуры.</returns>
        public virtual double CalculateArea() => GetArea(); 
    }
}