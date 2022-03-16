using System;

namespace Fibonacci
{
    class Program
    {
        /// <summary>
        /// Asks the user for a number and prints the number in that position 
        /// on the fibonacci sequence
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Variables
            int num = 4;

            //Asks user for a number

            //calls the fibonacci function with the user number
            Console.WriteLine(Fibonacci(num));

        }

        /// <summary>
        /// Calculates the fibonacci number in the n position
        /// </summary>
        /// <param name="n">The position on the fibonacci sequence the method 
        /// looks</param>
        /// <returns>The Fibonacci number in the n position</returns>
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
