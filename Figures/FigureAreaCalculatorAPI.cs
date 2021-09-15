namespace Figures
{
    public enum Type
    {
        Triangle,
        Circle,
        Squad,
        Rectangle,
    }

    public class FigureAreaCalculatorAPI
    {
        public FigureAreaCalculatorAPI(Type type)
        {
            ChangeFigureType(type);
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
                case Type.Squad:
                    _areaCalculator = new SquadAreaCalculator();
                    break;
                case Type.Rectangle:
                    _areaCalculator = new RectangleAreaCalculator();
                    break;
            }
        }

        IAreaCalculator _areaCalculator;
    }
}
