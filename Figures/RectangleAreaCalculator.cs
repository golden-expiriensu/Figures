using System;

namespace Figures
{
    class RectangleAreaCalculator : IAreaCalculator
    {
        public float CalculateArea(AreaParameter parameter)
        {
            float a = parameter.RectangleSides.SideA,
                  b = parameter.RectangleSides.SideB;
            return a * b;
        }
    }
}
