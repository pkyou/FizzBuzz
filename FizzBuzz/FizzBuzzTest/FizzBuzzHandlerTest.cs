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
            for (var i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
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