using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1; // Ссылка на библиотеку

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Circle_CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double radius = 5;
            Circle circle = new Circle(radius);
            double expectedArea = Math.PI * radius * radius;

            // Act
            double actualArea = circle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001); // Точность сравнения
        }

        [TestMethod]
        public void Triangle_CalculateArea_ReturnsCorrectArea()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);
            double expectedArea = 6; // Площадь для треугольника с сторонами 3, 4, 5

            // Act
            double actualArea = triangle.CalculateArea();

            // Assert
            Assert.AreEqual(expectedArea, actualArea, 0.0001);
        }

        [TestMethod]
        public void Triangle_IsRightTriangle_ReturnsTrue()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;
            Triangle triangle = new Triangle(sideA, sideB, sideC);

            // Act
            bool isRight = triangle.IsRightTriangle();

            // Assert
            Assert.IsTrue(isRight);
        }
    }
}