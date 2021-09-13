using System;

namespace Figures
{
    class CircleAreaCalculator : IAreaCalculator
    {
        public float CalculateArea(AreaParameter parameter)
        {
            return (float)(Math.PI * Math.Pow(parameter.Radius, 2));
        }
    }
}
