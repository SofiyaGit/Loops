using System;

//Problem 12.* Randomize the Numbers 1…N
namespace RandomizeTheNumbersOneToN
{
    class RandomizeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");

            int length = int.Parse(Console.ReadLine());

            int[] n = new int[length];

            for (int i = 0; i < n.Length; i++)
            {
                Random r = new Random();

                n[i] = r.Next(1,length);

                Console.WriteLine(n[i]);
                
            }

        }
    }
}
