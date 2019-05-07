using FizzBuzzBusiness;
using Xunit;

namespace FizzBuzzTest
{
    public class BuzzHandlerTest
    {
        private AbstractHandler handler = new BuzzHandler();
        private string fizzString = "Buzz";

        [Fact]
        public void BuzzResultTest()
        {
            for (var i = 1; i < 101; i++)
            {
                if (i % 5 == 0 || i.ToString().Contains("5"))
                {
                    Assert.Equal(fizzString, handler.GetHandleResult(i));
                }
                else
                {
                    Assert.NotEqual(fizzString,handler.GetHandleResult(i));
                    Assert.Equal(i.ToString(),handler.GetHandleResult(i));
                }
            }
        }
    }
}