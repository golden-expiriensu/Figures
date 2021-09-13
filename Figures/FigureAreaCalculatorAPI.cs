namespace Figures
{
    public enum Type
    {
        Triangle,
        Circle,
    }

    public class FigureAreaCalculatorAPI
    {
        public FigureAreaCalculatorAPI()
        {
            _areaCalculator = new TriangleAreaCalculator(); // default figure
        }

        public float CalculateArea(AreaParameter parameter)
        {
            return _areaCalculator.CalculateArea(parameter);
        }

        public void ChangeFigureType(Type type)
        {
            switch (type)
            {
                case Type.Triangle:
                    _areaCalculator = new TriangleAreaCalculator();
                    break;
                case Type.Circle:
                    _areaCalculator = new CircleAreaCalculator();
                    break;
            }
        }

        IAreaCalculator _areaCalculator;
    }
}
