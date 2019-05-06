namespace FizzBuzzBusiness
{
    public class BuzzHandler : AbstractHandler
    {
        protected override bool CanCurrentHandle(int number)
        {
            return number % 5 == 0;
        }

        protected override string HandleResult(int number)
        {
            return "Buzz";
        }
    }
}