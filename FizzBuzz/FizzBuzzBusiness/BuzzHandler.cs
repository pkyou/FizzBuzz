namespace FizzBuzzBusiness
{
    public class BuzzHandler : AbstractHandler
    {
        private int checkedNumber = 5;
        protected override bool CanCurrentHandle(int number)
        {
            return number % checkedNumber == 0 || number.ToString().Contains(checkedNumber.ToString());
        }

        protected override string HandleResult(int number)
        {
            return "Buzz";
        }
    }
}