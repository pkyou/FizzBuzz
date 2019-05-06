using FizzBuzzBusiness;
using Xunit;

namespace FizzBuzzTest
{
    public class BuzzHandlerTest
    {
        private AbstractHandler handler = new BuzzHandler();
        private string fizzString = "Buzz";

        [Fact]
        public void ShouldReturnFizz()
        {
            for (var i = 1; i < 40; i++)
            {
                Assert.Equal(fizzString, handler.GetHandleResult(5 * i));
            }
        }

        [Fact]
        public void ShouldReturnNull()
        {
            Assert.Equal(string.Empty, handler.GetHandleResult(0));
            Assert.Equal(string.Empty, handler.GetHandleResult(-6));
            for (var i = 1; i < 40; i++)
            {
                if (i % 5 == 0)
                {
                    continue;
                }

                Assert.Equal((1 * i).ToString(), handler.GetHandleResult(1 * i));
                Assert.Equal((2 * i).ToString(), handler.GetHandleResult(2 * i));
                Assert.Equal((3 * i).ToString(), handler.GetHandleResult(3 * i));
                Assert.Equal((4 * i).ToString(), handler.GetHandleResult(4 * i));
                Assert.Equal((6 * i).ToString(), handler.GetHandleResult(6 * i));
                Assert.Equal((7 * i).ToString(), handler.GetHandleResult(7 * i));
                Assert.Equal((8 * i).ToString(), handler.GetHandleResult(8 * i));
                Assert.Equal((9 * i).ToString(), handler.GetHandleResult(9 * i));
            }
        }

    }
}