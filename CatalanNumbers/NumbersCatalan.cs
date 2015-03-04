using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Problem 8. Catalan Numbers
namespace CatalanNumbers
{
    class NumbersCatalan
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");

            int n = int.Parse(Console.ReadLine());

            double result = (Factorial(2 * n)) / (Factorial(n + 1) * Factorial(n));

            Console.WriteLine("Catalan(n) {0}", result);
        }

        private static double Factorial(double n)
        {
            if (n == 0)
                return 1;

            return n * Factorial(n - 1);
        }
    }
}
