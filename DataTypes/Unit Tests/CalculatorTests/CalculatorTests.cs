using System;
using Utilities;
using Xunit;

namespace CalculatorTests
{
    public class CalculatorTests
    {
        // Existe Moq para simular que nos conectamos a la base de datos
        // Programar a interfaces y no implementacion
        [Fact]
        public void Should_SumTwoNumbers_Success()
        {
            // AAA: Arrange, Act, Assert
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            // var total = _moq.calculator.GetIncomes().Returns(1000);
            var actualValue = calculator.Sum(2, 2);
            var expectedValue = 4;


            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Should_RestTwoNumbers_Success()
        {
            // AAA: Arrange, Act, Assert
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var actualValue = calculator.Rest(2, 2);
            var expectedValue = 0;

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Should_MultiplyTwoNumbers_Success()
        {
            // AAA: Arrange, Act, Assert
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var actualValue = calculator.Multiply(2, 2);
            var expectedValue = 4;

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Should_DivideTwoNumbers_Success()
        {
            // AAA: Arrange, Act, Assert
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var actualValue = calculator.Divide(2, 2);
            var expectedValue = 1;

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void Should_DivideTwoNumbers_Failure()
        {
            // AAA: Arrange, Act, Assert
            // Arrange
            Calculator calculator = new Calculator();

            // Act
            var actualValue = calculator.Divide(2, 0);
            var expectedValue = 0;

            // Assert
            Assert.Equal(expectedValue, actualValue);
        }
        [Fact]
        public void SumTwoNumbers_Failure()
        {

        }
    }
}
