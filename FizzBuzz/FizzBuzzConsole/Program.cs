using FizzBuzzBusiness;

namespace FizzBuzzConsole
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            AbstractHandler buzzHandler = new BuzzHandler();
            AbstractHandler fizzHandler = new FizzHandler();
            
            buzzHandler.SetNextHandler(fizzHandler);

            for (int i = 0; i < 100; i++)
            {
                System.Console.WriteLine(buzzHandler.GetHandleResult(i));
            }
        }
    }
}