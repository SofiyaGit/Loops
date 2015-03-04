using System;
using System.Collections.Generic;

//Problem 16. Decimal to Hexadecimal Number
namespace DecimalToHexadecimalNumber
{
    class DecimalToHexadecimal
    {
        static Dictionary<char, int> hexValue = new Dictionary<char, int>{
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9},
        {'a', 10},
        {'b', 11},
        {'c', 12},
        {'d', 13},
        {'e', 14},
        {'f', 15},
        };
        static void Main(string[] args)
        {
            Console.Write("Decimal ");

            int number = int.Parse(Console.ReadLine());

            int remainder;

            string toHexadecimal = string.Empty;

            while (number > 0)
            {
                remainder = number % 16;

                number /= 16;

                toHexadecimal = remainder.ToString("X") + toHexadecimal;

            }
            Console.WriteLine("Hexadecimal {0}",toHexadecimal);
        }
    }
}
