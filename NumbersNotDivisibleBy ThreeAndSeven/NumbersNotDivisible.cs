using System;

//Problem 2. Numbers Not Divisible by 3 and 7
namespace NumbersNotDivisibleByThreeAndSeven
{
    class NumbersNotDivisible
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (!(i % 3 == 0) && !(i % 7 == 0)) 
                {
                    Console.Write("{0} ", i);
                }

                
            }
        }
    }
}
