using FizzBuzzBusiness;

namespace FizzBuzzConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AbstractHandler buzzHandler = new BuzzHandler();
            AbstractHandler fizzHandler = new FizzHandler();
            AbstractHandler fizzBuzzHandler = new FizzBuzzHandler();
            
            fizzBuzzHandler.SetNextHandler(buzzHandler);
            buzzHandler.SetNextHandler(fizzHandler);

            for (var i = 0; i < 100; i++)
            {
                System.Console.WriteLine(fizzBuzzHandler.GetHandleResult(i));
            }
        }
    }
}