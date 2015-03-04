using System;

//Problem 7. Calculate N! / (K! * (N-K)!)
namespace CalculateExpression
{
    class Combination
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter k:");

            int k = int.Parse(Console.ReadLine());

            int factorielN = 1;

            int factorielK = 1;

            int factorielNK = 1;

            int nMinusK = n - k;

            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;

            }
            for (int i = 1; i <= k; i++)
            {
                factorielK *= i;

            }
            for (int i = 1; i <= nMinusK; i++)
            {
                factorielNK *= i;

            }

            int result = factorielN / (factorielK * factorielNK);

            Console.WriteLine("n! /( k! * (n-k)!) {0}",result);

        }
    }
}
