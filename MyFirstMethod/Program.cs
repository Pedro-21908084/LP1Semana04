using System;

namespace MyFirstMethod
{
    /// <summary>
    /// Program made to test the use of methods
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calls function CountTo10 2 times, calls function CountToN 3 times 
        /// with the arguments 3 and 12 and then with both 2 and 7 as arguments
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
            CountToN(3);
            CountToN(12);
            CountToN(2, 7);
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

        /// <summary>
        /// Prints from n1 to n2
        /// </summary>
        /// <param name="n1">The first number the method prints</param>
        /// <param name="n2">The last number the method prints</param>
        private static void CountToN(int n1, int n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
