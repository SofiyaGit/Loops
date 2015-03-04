using System;

using System.Collections.Generic;

//Problem 15. Hexadecimal to Decimal Number
namespace HexadecimalToDecimal_Number
{
    class HexadecimalToDecimal
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

            Console.WriteLine("Hecadecimal ");

            string input = Console.ReadLine();

            long toDecimal = 0;

            input = input.ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                char numberDecimal = input[input.Length - i - 1];

                toDecimal += hexValue[numberDecimal]*(int)Math.Pow(16, i);
            }

            Console.WriteLine("Decimal {0}", toDecimal);
        }
    }
}
