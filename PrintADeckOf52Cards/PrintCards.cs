using System;

//Problem 4. Print a Deck of 52 Cards
namespace PrintADeckOf52Cards
{
    class PrintCards
    {
        static void Main()
        {
            char[] symbol = { '\u2663', '\u2666', '\u2665', '\u2660' };


            for (int i = 2; i < 15; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    switch (i)
                    {
                        case 2: 
                        case 3: 
                        case 4: 
                        case 5: 
                        case 6: 
                        case 7: 
                        case 8: 
                        case 9:  
                        case 10: Console.Write("{0}{1} ", i, symbol[j]); break;  
                        case 11: Console.Write("{0}{1} ", "J", symbol[j]); break;
                        case 12: Console.Write("{0}{1} ", "Q", symbol[j]); break;
                        case 13: Console.Write("{0}{1} ", "K", symbol[j]); break;
                        case 14: Console.Write("{0}{1} ", "A", symbol[j]); break;

                    }
                    
                }
                Console.WriteLine();

            }
        }
    }
}

