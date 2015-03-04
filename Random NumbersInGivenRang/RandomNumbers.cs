using System;

//Problem 11. Random Numbers in Given Range
namespace Random_NumbersInGivenRang
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");

            int length = int.Parse(Console.ReadLine());

            int[] n = new int[length];

            Console.WriteLine("Enter min:");

            int min = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter max:");

            int max = int.Parse(Console.ReadLine());

            if (min != max)
            {   
                Random r = new Random();

                for (int i = 0; i < n.Length; i++)
                {
                   //generate random numbers with method Next
                    n[i] = r.Next(min,max);

                   Console.WriteLine(n[i]);

                 }
                
            }
        }
    }
}
