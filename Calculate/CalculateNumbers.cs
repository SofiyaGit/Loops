using System;

//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
namespace Calculate
{
    class CalculateNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter x:");

            int x = int.Parse(Console.ReadLine());

            decimal factoriel = 1m;

            decimal amount = 1m;

            decimal degree = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;

                degree *= x;
            }

            amount += 1 + (factoriel / degree);

            Console.WriteLine("S {0:F5}", amount);

        }

    }
}
