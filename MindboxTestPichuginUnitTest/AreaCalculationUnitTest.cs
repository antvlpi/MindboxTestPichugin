using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindboxTestPichuginDLL;
using System;

namespace MindboxTestPichuginUnitTest
{
    [TestClass]
    public class AreaCalculationUnitTest
    {
        [TestMethod]
        public void IsoscelesTriangleArea_5and12and13_returned30() // Тест прямоугольного треугольника
        {
            // Arrage
            double sideA = 5;
            double sideB = 12;
            double sideC = 13;
            string expected = "Площадь прямоугольного треугольника = 30,00";

            // Acr
            AreaCalculation areaCalc = new AreaCalculation();
            string actual = areaCalc.GetAreaInfo(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TriangleArea_10and12and13_returned30() // Тест треугольника
        {
            // Arrage
            double sideA = 10;
            double sideB = 12;
            double sideC = 13;
            string expected = "Площадь треугольника = 57,00";

            // Acr
            AreaCalculation areaCalc = new AreaCalculation();
            string actual = areaCalc.GetAreaInfo(sideA, sideB, sideC);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CircleArea_10_returned28_26() // Тест окружности
        {
            // Arrage
            double radius = 7;
            string expected = "Площадь круга = 153,86";

            // Acr
            AreaCalculation areaCalc = new AreaCalculation();
            string actual = areaCalc.GetAreaInfo(radius);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
