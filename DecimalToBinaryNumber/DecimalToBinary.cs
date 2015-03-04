using System;

//Problem 14. Decimal to Binary Number
namespace DecimalToBinaryNumber
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            Console.Write("Decimal ");

            long input = long.Parse(Console.ReadLine());

            int number = Convert.ToInt32(input);

            int remainder;

            string toBinary = string.Empty;

            while (number > 0)
            {
                remainder = number % 2;

                number /= 2;

                toBinary = remainder.ToString() + toBinary;

            }
            Console.WriteLine("Binary {0}", toBinary);
        }
    }
}
