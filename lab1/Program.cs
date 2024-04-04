using System;

namespace CatalanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            long[] catalanNumbers = new long[n + 1];
            catalanNumbers[0] = 1;
            catalanNumbers[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                catalanNumbers[i] = (2 * (2 * i - 1) * catalanNumbers[i - 1]) / (i + 1);
            }

            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine($"Catalan number for n = {i} is {catalanNumbers[i]}");
            }

            Console.ReadKey();
        }
    }
}