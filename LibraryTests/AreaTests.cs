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

            FigureAreaCalculatorAPI calculatorAPI = new(Type.Triangle);
            float calculatedArea = calculatorAPI.CalculateArea(new AreaParameter(sideA, sideB, sideC));

            Assert.AreEqual(expectedArea, calculatedArea, 0.001, "Calculated value is not correct (triangle)");
        }

        [TestMethod]
        public void TestCircle()
        {
            float radius = 1.6f;
            float expectedArea = 8.042f;

            FigureAreaCalculatorAPI calculatorAPI = new(Type.Circle);
            float calculatedArea = calculatorAPI.CalculateArea(new AreaParameter(radius));

            Assert.AreEqual(expectedArea, calculatedArea, 0.001, "Calculated value is not correct (circle)");
        }

        [TestMethod]
        public void TestSquad()
        {
            float side = 1.6f;
            float expectedArea = 2.56f;

            FigureAreaCalculatorAPI calculatorAPI = new(Type.Squad);
            float calculatedArea = calculatorAPI.CalculateArea(new AreaParameter(side));

            Assert.AreEqual(expectedArea, calculatedArea, 0.001, "Calculated value is not correct (squad)");
        }

        [TestMethod]
        public void TestRectangle()
        {
            float sideA = 1.4f;
            float sideB = 12.6f;
            float expectedArea = 17.64f;

            FigureAreaCalculatorAPI calculatorAPI = new(Type.Rectangle);
            float calculatedArea = calculatorAPI.CalculateArea(new AreaParameter(sideA, sideB));

            Assert.AreEqual(expectedArea, calculatedArea, 0.001, "Calculated value is not correct (rectangle)");
        }
    }
}
