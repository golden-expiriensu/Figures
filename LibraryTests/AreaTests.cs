using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;

namespace LibraryTests
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void TestTriangle()
        {
            float sideA = 1.99f;
            float sideB = 2.3f;
            float sideC = 1.54f;
            float expectedArea = 1.51f;

            FigureAreaCalculatorAPI calculatorAPI = new FigureAreaCalculatorAPI();
            calculatorAPI.ChangeFigureType(Type.Triangle);
            float calculatedArea = calculatorAPI.CalculateArea(new AreaParameter(sideA, sideB, sideC));

            Assert.AreEqual(expectedArea, calculatedArea, 0.001, "Calculated value is not correct (triangle)");
        }

        [TestMethod]
        public void TestCircle()
        {
            float radius = 1.6f;
            float expectedArea = 8.042f;

            FigureAreaCalculatorAPI calculatorAPI = new FigureAreaCalculatorAPI();
            calculatorAPI.ChangeFigureType(Type.Circle);
            float calculatedArea = calculatorAPI.CalculateArea(new AreaParameter(radius));

            Assert.AreEqual(expectedArea, calculatedArea, 0.001, "Calculated value is not correct (circle)");
        }
    }
}
