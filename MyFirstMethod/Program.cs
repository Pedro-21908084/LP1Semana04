using System;

namespace MyFirstMethod
{
    class Program
    {
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
    }
}
