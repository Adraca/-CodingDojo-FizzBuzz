using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FizzBuzz.Tests
{
    public class CounterTests
    {
        [Fact]
        public void OneIterationIsOneResult()
        {
            // Arrange
            var counter = new FizzBuzzCounter();
            var expectedResult = 1;

            // Act
            var result = counter.CalculateResultsForNIterations(1);

            // Assert
            Assert.Equal(expectedResult, result.Count);
        }

        [Fact]
        public void OneIterationFirstValueIsOne()
        {
            // Arrange
            var counter = new FizzBuzzCounter();
            var expectedList = new List<string>(1) { "1" };

            // Act
            var result = counter.CalculateResultsForNIterations(1);

            // Assert
            Assert.Equal(expectedList.FirstOrDefault(), result.FirstOrDefault());
        }

        [Fact]
        public void TwoIterationsIsTwoResults()
        {
            // Arrange
            var counter = new FizzBuzzCounter();
            var expectedResult = 2;

            // Act
            var result = counter.CalculateResultsForNIterations(2);

            // Assert
            Assert.Equal(expectedResult, result.Count);
        }

        [Fact]
        public void TwoIterationsSecondValueIsTwo()
        {
            // Arrange
            var counter = new FizzBuzzCounter();
            var expectedList = new List<string>(2) { "1", "2" };

            // Act
            var result = counter.CalculateResultsForNIterations(2);

            // Assert
            Assert.Equal(expectedList[1], result[1]);
        }

        [Fact]
        public void ThreeIterationsIsThreeResults()
        {
            // Arrange
            var counter = new FizzBuzzCounter();
            var expectedResult = 3;

            // Act
            var result = counter.CalculateResultsForNIterations(3);

            // Assert
            Assert.Equal(expectedResult, result.Count);
        }

        [Fact]
        public void ThreeIterationsThirdValueIsThree()
        {
            // Arrange
            var counter = new FizzBuzzCounter();
            var expectedList = new List<string>(3) { "1", "2", "Fizz" };

            // Act
            var result = counter.CalculateResultsForNIterations(3);

            // Assert
            Assert.Equal(expectedList[1], result[1]);
        }

        [Fact]
        public void ZeroIterationsAreNotAllowed()
        {
            // Arrange
            var counter = new FizzBuzzCounter();

            // Assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => counter.CalculateResultsForNIterations(0));
        }

        [Fact]
        public void MoreThanAHundredIterationsAreNotAllowed()
        {
            // Arrange
            var counter = new FizzBuzzCounter();

            // Assert
            Assert.Throws<System.ArgumentOutOfRangeException>(() => counter.CalculateResultsForNIterations(101));
        }
    }
}
