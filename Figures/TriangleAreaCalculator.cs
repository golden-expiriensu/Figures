using System;

namespace Figures
{
    public class TriangleAreaCalculator : IAreaCalculator
    {
        public float CalculateArea(AreaParameter parameter)
        {
            parameter.TriangleSides.GetTriangleSides(out float sideA, out float sideB, out float sideC);
            
            float semiPerimeter = (sideA + sideB + sideC) / 2f;
            
            float sqrArea = semiPerimeter
                * (semiPerimeter - sideA)
                * (semiPerimeter - sideB)
                * (semiPerimeter - sideC);
            
            float area = (float)Math.Sqrt(sqrArea);
            
            return area;
        }
    }
}
