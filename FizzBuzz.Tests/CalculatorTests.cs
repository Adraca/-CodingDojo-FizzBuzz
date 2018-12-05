using Xunit;

namespace FizzBuzz.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void FirstNumberIsOne()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "1";

            // Act
            var result = calculator.CalculateCurrentValue(1);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void SecondNumberIsTwo()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "2";

            // Act
            var result = calculator.CalculateCurrentValue(2);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void ThirdNumberIsFizz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedResult = "Fizz";

            // Act
            var result = calculator.CalculateCurrentValue(3);

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void FourthNumberIsFour()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "4";

            // Act
            var result = calculator.CalculateCurrentValue(4);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void FifthNumberIsBuzz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "Buzz";

            // Act
            var result = calculator.CalculateCurrentValue(5);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void SixthNumberIsFizz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "Fizz";

            // Act
            var result = calculator.CalculateCurrentValue(6);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void SeventhNumberIsSeven()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "7";

            // Act
            var result = calculator.CalculateCurrentValue(7);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void EigthNumberIsEigth()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "8";

            // Act
            var result = calculator.CalculateCurrentValue(8);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void NinthNumberIsFizz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "Fizz";

            // Act
            var result = calculator.CalculateCurrentValue(9);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void TenthNumberIsBuzz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "Buzz";

            // Act
            var result = calculator.CalculateCurrentValue(10);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void ThirteenthNumberIsFizz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "Fizz";

            // Act
            var result = calculator.CalculateCurrentValue(13);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void FifteenthNumberIsFizzBuzz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "FizzBuzz";

            // Act
            var result = calculator.CalculateCurrentValue(15);

            // Assert
            Assert.Equal(expectedNumber, result);
        }

        [Fact]
        public void FiftyThreeNumberIsFizzBuzz()
        {
            // Arrange
            var calculator = new FizzBuzzCalculator();
            string expectedNumber = "FizzBuzz";

            // Act
            var result = calculator.CalculateCurrentValue(53);

            // Assert
            Assert.Equal(expectedNumber, result);
        }
    }
}
