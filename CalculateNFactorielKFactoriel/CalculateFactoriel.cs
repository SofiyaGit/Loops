using System;
using System.Globalization;
using System.Threading;

//Problem 6. Calculate N! / K!
namespace CalculateNFactorielKFactoriel
{
    class CalculateFactoriel
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter n:");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter k:");

            int k = int.Parse(Console.ReadLine());

            int factorielN = 1;

            int factorielK = 1;

            int result = 0;

            for (int i = 1; i <=n; i++)
            {
                factorielN *= i;

            }
            for (int index = 1; index <= k; index++)
            {
                factorielK *= index;

            }
            result = factorielN / factorielK;
            Console.WriteLine(result);
        }
    }
}
