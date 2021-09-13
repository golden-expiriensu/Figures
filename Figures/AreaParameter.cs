namespace Figures
{
    public class AreaParameter
    {
        public AreaParameter(float sideA, float sideB, float sideC)
        {
            TriangleSides = new TriangleSides(sideA, sideB, sideC);
        }

        public AreaParameter(float radius)
        {
            Radius = radius;
        }

        public TriangleSides TriangleSides { get; private set; }
        public float Radius { get; private set; }
    }

    public struct TriangleSides
    {
        public TriangleSides(float sideA, float sideB, float sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public void GetTriangleSides(out float sideA, out float sideB, out float sideC)
        {
            sideA = _sideA;
            sideB = _sideB;
            sideC = _sideC;
        }

        float _sideA, _sideB, _sideC;
    }
}
