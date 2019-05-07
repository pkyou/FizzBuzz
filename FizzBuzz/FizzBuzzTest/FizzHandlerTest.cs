using FizzBuzzBusiness;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzHandlerTest
    {
        private AbstractHandler handler = new FizzHandler();
        private string fizzString = "Fizz";
        
        [Fact]
        public void FizzResultTest()
        {
            for (var i = 1; i < 101; i++)
            {
                if (i % 3 == 0 || i.ToString().Contains("3"))
                {
                    Assert.Equal(fizzString,handler.GetHandleResult(i));
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