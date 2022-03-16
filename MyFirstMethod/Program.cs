using System;

namespace MyFirstMethod
{
    /// <summary>
    /// Program made to test the use of methods
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calls function CountTo10 2 times and function CountToN 2 times with
        /// the arguments 3 and 12
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
            CountToN(3);
            CountToN(12);
        }

        /// <summary>
        /// Prints from 1 to 10
        /// ; Calls function CountToN to do it
        /// </summary>
        private static void CountTo10()
        {
            CountToN(10);
        }

        /// <summary>
        /// Prints from 1 to n
        /// </summary>
        /// <param name="n">The maximun the function should print to</param>
        private static void CountToN(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
