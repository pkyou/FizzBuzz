namespace FizzBuzzBusiness
{
    public class FizzHandler : AbstractHandler
    {
        private int checkedNumber = 3;
        protected override bool CanCurrentHandle(int number)
        {
            return number % checkedNumber == 0 || number.ToString().Contains(checkedNumber.ToString());
        }

        protected override string HandleResult(int number)
        {
            return "Fizz";
        }
    }
}