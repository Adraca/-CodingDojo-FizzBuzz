namespace FizzBuzz
{
    public class FizzBuzzCalculator
    {
        private const string parentOfThree = "Fizz";
        private const string parentOfFive = "Buzz";

        public string CalculateCurrentValue(int number)
        {
            var result = string.Empty;

            if (IsFizz(number))
            {
                result = parentOfThree;
            }

            if (IsBuzz(number))
            {
                result += parentOfFive;
            }

            if (result == string.Empty)
            {
                return number.ToString();
            }

            return result;
        }

        private bool IsFizz(int number)
        {
            return (number % 3 == 0 || number.ToString().Contains("3"));
        }

        private bool IsBuzz(int number)
        {
            return (number % 5 == 0 || number.ToString().Contains("5"));
        }
    }
}
