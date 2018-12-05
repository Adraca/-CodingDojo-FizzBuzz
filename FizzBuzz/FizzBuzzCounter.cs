using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzCounter
    {
        public List<string> CalculateResultsForNIterations(int numberOfIterations)
        {
            CheckIterationIsInRange(numberOfIterations);

            var resultList = new List<string>(numberOfIterations);
            var calculator = new FizzBuzzCalculator();

            for (int iterator = 1; iterator <= numberOfIterations; iterator++)
            {
                resultList.Add(calculator.CalculateCurrentValue(iterator));
            }

            return resultList;
        }

        private void CheckIterationIsInRange(int number)
        {
            if (number < 1 || number > 100)
            {
                throw new System.ArgumentOutOfRangeException(nameof(number), "number of iterations must be between 1 and 100");
            }
        }
    }
}
