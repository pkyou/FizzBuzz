using System;
using FizzBuzzBusiness;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzHandlerTest
    {
        private AbstractHandler handler = new FizzBuzzHandler();
        private string fizzString = "FizzBuzz";
        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            for (var i = 1; i < 40; i++)
            {
                Assert.Equal(fizzString,handler.GetHandleResult(3*5*i));
            }
        }

        [Fact]
        public void ShouldNotReturnFizzBuzz()
        {
            for (var i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }

                Assert.NotEqual(fizzString, handler.GetHandleResult(i));
            }
        }
    }
}