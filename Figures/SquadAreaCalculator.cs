using System;

namespace Figures
{
    class SquadAreaCalculator : IAreaCalculator
    {
        public float CalculateArea(AreaParameter parameter)
        {
            return (float)Math.Pow(parameter.SquadSides.SideA, 2);
        }
    }
}
