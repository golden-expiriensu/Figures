using System;

namespace Figures
{
    public class TriangleAreaCalculator : IAreaCalculator
    {
        public float CalculateArea(AreaParameter parameter)
        {
            float sideA = parameter.TriangleSides.SideA,
                  sideB = parameter.TriangleSides.SideB,
                  sideC = parameter.TriangleSides.SideC;
            
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
