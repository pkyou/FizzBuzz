using System;

namespace FizzBuzzBusiness
{
    public abstract class AbstractHandler
    {
        private AbstractHandler nextHandler;

        public void SetNextHandler(AbstractHandler handler)
        {
            nextHandler = handler;
        }

        public string GetHandleResult(int number)
        {
            if (number <= 0)
            {
                return string.Empty;
            }
            
            if (CanCurrentHandle(number))
            {
                return HandleResult(number);
            }

            return nextHandler == null ? number.ToString() : nextHandler.GetHandleResult(number);
        }

        protected abstract bool CanCurrentHandle(int number);

        protected abstract string HandleResult(int number);

    }
}