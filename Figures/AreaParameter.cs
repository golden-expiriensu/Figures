namespace Figures
{
    public class AreaParameter
    {
        public AreaParameter(float value)
        {
            SquadSides = new SquadSides(value);
            Radius = value;
        }

        public AreaParameter(float valueA, float valueB)
        {
            RectangleSides = new RectangleSides(valueA, valueB);
        }
        
        public AreaParameter(float valueA, float valueB, float valueC)
        {
            TriangleSides = new TriangleSides(valueA, valueB, valueC);
        }

        public SquadSides SquadSides { get; private set; }

        public RectangleSides RectangleSides { get; private set; }

        public TriangleSides TriangleSides { get; private set; }

        public float Radius { get; private set; }
    }

    public struct TriangleSides
    {
        public TriangleSides(float sideA, float sideB, float sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        public readonly float SideA, SideB, SideC;
    }

    public struct SquadSides
    {
        public SquadSides(float sideA)
        {
            SideA = sideA;
        }
        public readonly float SideA;
    }

    public struct RectangleSides
    {
        public RectangleSides(float sideA, float sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public readonly float SideA, SideB;
    }
}
