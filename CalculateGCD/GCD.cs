using System;

//Problem 17.* Calculate GCD
namespace CalculateGCD
{
    class GCD
    {
        static void Main(string[] args)
        {
            Console.Write("Enter A ");

            int A = int.Parse(Console.ReadLine());

            Console.Write("Enter B ");

            int B = int.Parse(Console.ReadLine());

            long remainder;

            if (A > B)
            {
                if (A % B ==0 )
                {
                    remainder = B;

                    Console.WriteLine("GCD(a,b) {0}",remainder);
                }
                else
                {
                    remainder = A % B;

                    if (remainder !=0)
                    {
                        remainder = remainder % B;

                        Console.WriteLine("GCD(a,b) {0}", remainder);
                    }
                }
            }
            else if (A == B || A < B )
            {
                if (B % A == 0 )
                {
                    remainder = A;

                    Console.WriteLine("GCD(a,b) {0}", remainder);
                }
                else
                {
                    remainder = B % A;
                    if (remainder !=0 )
                    {
                        remainder = remainder % A;

                        Console.WriteLine("GCD(a,b) {0}", remainder);
                    }
                }
            }
        }
    }
}
