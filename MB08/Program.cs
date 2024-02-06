
namespace MB08
{
    using MB08.FibonacciBeispiel;
    using MB08.RecursionBeispiel;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter which position of the fibonacci sequence you want to see");
            int fibonacciPosition = Convert.ToInt32(Console.ReadLine());
            //Recursion Beispiel: 
            long number = Fibonacci.FibIterativ(fibonacciPosition);
            Console.WriteLine(number);

            //Fibonacci Beispiel:
            //long number = Fibonacci.FibRecursiv(fibonacciPosition);
            //Console.WriteLine(number);
        }

    }
}