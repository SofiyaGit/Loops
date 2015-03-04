using System;

//Problem 9. Matrix of Numbers
namespace Matrix_OfNumbers
{
    class Matrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int colum = row; colum < n + row ; colum++)
                {
                    Console.Write(colum+ " ");
                }
                Console.WriteLine();
            }

        }
    }
}

