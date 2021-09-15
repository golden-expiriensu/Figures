namespace Figures
{
    interface IAreaCalculator
    {
        public float CalculateArea(AreaParameter parameter);
        public float CalculateArea(AreaParameter parameter, Type type);
    }
}
