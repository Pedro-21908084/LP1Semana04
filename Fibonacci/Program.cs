using System;

namespace Fibonacci
{
    class Program
    {
        /// <summary>
        /// Uses arguments from the comand line as arguments for the fibonacci 
        /// method , else asks the user for a number and prints the number in 
        /// that position on the fibonacci sequence
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Variables
            int num;
            string input;

            //try to use args for input
            if(args.Length>=1)
                input = args[0];
            else
            {
                //Asks user for a number
                Console.Write("Write a int:");
                input = Console.ReadLine();
            }

            //Convert input to int
            num = int.Parse(input);

            //calls the fibonacci function with the user number
            Console.WriteLine($"Fibonacci number in the {num}º position: " + 
                Fibonacci(num));

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
