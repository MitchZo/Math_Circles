using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10
{
    class Circle
    {
        #region Fields
        private double radius;
        public const double pi = Math.PI;
        #endregion
        #region Properties
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        #endregion
        #region Constructors
        public Circle()
        {

        }
        public Circle(double _radius)
        {
            radius = _radius;
        }
        #endregion
        #region Methods
        public double CalculateCircumference()
        {
            double circumference = pi * 2 * radius;
            return circumference;
        }

        public double CalculateArea()
        {
            double area = (pi * (radius*radius));
            return area;
        }
        private string FormatNumber(double x)
        {
            string newNumber = Math.Round(x, 2).ToString();
            return newNumber;
        }
        public string CalculateFormattedArea()
        {
            return (FormatNumber(CalculateArea()));
        }
        public string CalculateFormattedCircumference()
        {
            return (FormatNumber(CalculateCircumference()));
        }

        #endregion
    }
    

}
