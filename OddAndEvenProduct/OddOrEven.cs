using System;


//Problem 10. Odd and Even Product
namespace OddAndEvenProduct
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers  : ");

            string input = Console.ReadLine();

            string[] numbers = input.Split(' ');

            int[] myInts = Array.ConvertAll(numbers, int.Parse);

            int productEven = 1;

            int productOdd = 1;

            for (int i = 0; i < myInts.Length; i++)
            {
                if (i % 2 ==0)
                {
                    productEven *= myInts[i];
                }
                else
                {
                    productOdd *= myInts[i];
                }

            }

            if (productEven == productOdd)
            {
                Console.WriteLine("yes");

                Console.WriteLine("product= {0}", productOdd);
            }
            else

            {   Console.WriteLine("no");

                Console.WriteLine("odd_product = {0} \neven_product = {1}", productOdd, productEven);
                
            }
        }

    }
}
