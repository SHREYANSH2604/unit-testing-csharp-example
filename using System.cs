using System;

namespace RectangleAreaCalculator
{
    public class Calculator
    {
        public static double CalculateArea(double length, double width)
        {
            if (length <= 0 || width <= 0)
            {
                throw new ArgumentException("Length and width must be positive numbers.");
            }

            return length * width;
        }
    }
}
