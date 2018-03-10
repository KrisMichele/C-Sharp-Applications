/* Calculate a prime numbers between 2 and 1000. 
A prime number is a number greater than 1 that is divisible 
by itself and 1. Prime numbers are 2, 3, 5, 7, ... 
*/

using System;

namespace S5_Op_Challenge_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = 2;

            Console.WriteLine("the prime numbers between 2 and 1000 are :\n");

            while (number >= 2 && number <= 1000)
            {
                int isPrime = 0;   //integer instead of boolean to keep track of counts.
                number++;

                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                        isPrime++;

                    if (isPrime == 2)
                        break;
                }
                if (isPrime != 2)
                    Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
