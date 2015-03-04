using System;

//Problem 1. Numbers from 1 to N
namespace NumbersFrom1ToN
{
    class NumbersToN
    {
        static void Main()
        {
            Console.WriteLine("Enter a number:");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < number+1; i++)
            {   
                Console.Write("{0} ",i);
            }
        }
    }
}
