using System;
using System.Linq;

//Problem 3. Min, Max, Sum and Average of N Numbers
namespace MinMaxSumAverageOfNNumbers
{
    class NumbersMaxMinAmount
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");

            int n = int.Parse(Console.ReadLine());

            int[] inputArray = new int[n];

            float average = 0;

            for (int i = 0; i < n; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());

                average += inputArray[i];

            }
                Console.WriteLine("avg={0} ",average/n);

                Console.WriteLine("min = {0}",inputArray.Min());

                Console.WriteLine("max = {0}",inputArray.Max());

                Console.WriteLine("sum = {0:0}",inputArray.Min() + inputArray.Max() + average/n);
        }
    }
}
