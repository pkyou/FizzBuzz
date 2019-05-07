namespace FizzBuzzBusiness
{
    public class FizzBuzzHandler : AbstractHandler
    {
        protected override bool CanCurrentHandle(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        protected override string HandleResult(int number)
        {
            return "FizzBuzz";
        }
    }
}