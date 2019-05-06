namespace FizzBuzzBusiness
{
    public class FizzHandler : AbstractHandler
    {
        protected override bool CanCurrentHandle(int number)
        {
            return number % 3 == 0;
        }

        protected override string HandleResult(int number)
        {
            return "Fizz";
        }
    }
}