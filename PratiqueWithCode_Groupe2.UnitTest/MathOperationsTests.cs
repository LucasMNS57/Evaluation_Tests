using System;
using EvaluationSampleCode;

namespace PratiqueWithCode_Groupe2.UnitTest
{
    [TestClass]
    public class MathOperationsTests
    {
        private MathOperations mathOperations;

        [TestInitialize]
        public void Setup()
        {
            mathOperations = new MathOperations();
        }

        [TestMethod]
        [DataRow(5, 2, 3)]
        [DataRow(10, 5, 5)]
        [DataRow(100, 50, 50)]
        public void Subtract_ValidNumbers_ReturnsCorrectResult(int numberOne, int numberTwo, int expectedResult)
        {
            // Act
            var result = mathOperations.Subtract(numberOne, numberTwo);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [DataRow(10, 15)]
        [DataRow(1200, 0)]
        [DataRow(5, 10)] // Scénario d'échec: numberTwo > numberOne
        [DataRow(1200, 1200)] // Scénario d'échec: numberOne >= 1200
        public void Subtract_InvalidNumbers_ThrowsArgumentException(int numberOne, int numberTwo)
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => mathOperations.Subtract(numberOne, numberTwo));
        }

        [TestMethod]
        [DataRow(0, "Red")]
        [DataRow(1, "Blue")]
        [DataRow(2, "Red")]
        public void GetColorFromOddsNumber_ValidNumber_ReturnsCorrectColor(int number, string expectedColor)
        {
            // Act
            var result = mathOperations.GetColorFromOddsNumber(number);

            // Assert
            Assert.AreEqual(expectedColor, result);
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(-5)]
        public void GetColorFromOddsNumber_NegativeNumber_ThrowsArgumentException(int number)
        {
            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => mathOperations.GetColorFromOddsNumber(number));
        }
    }
}

