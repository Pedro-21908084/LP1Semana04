using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num = 4;

            //Asks user for a number

            //calls the fibonacci function with the user number
            Console.WriteLine(Fibonacci(num));
            
        }

        private static int Fibonacci(int n)
        {
            int fib;
            if (n <= 2)
                fib = 1;
            else
                fib = Fibonacci(n - 1) + Fibonacci(n - 2);

            return fib;
        }
    }
}
