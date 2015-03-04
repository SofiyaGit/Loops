using System;

//Problem 13. Binary to Decimal Number
namespace BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Binary ");

            string input = Console.ReadLine();

            long toDecimal = 0;

            for (int i = 0; i < input.Length; i++)
            {
                // we start with the least significant digit, and work our way to the left
                if (input[input.Length - i - 1] == '0') continue;
                toDecimal += (int)Math.Pow(2, i);
            }

            Console.WriteLine(toDecimal);

        }
    }
}
