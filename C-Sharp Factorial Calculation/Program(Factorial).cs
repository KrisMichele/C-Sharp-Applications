//Write a program that calculates the factorial of an integer n given by the user. Please enter a small integer.
using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter in a number that will be used to calculate the factorial.");
            string str = Console.ReadLine();
            double result = 1;

            try
            {
                double n = double.Parse(str);

                if (n > 0)
                {
                    for (double i = 1; i <= n; i++)    
                    {
                        result = result * i;     //note: The factorial of numbers >170 is infinity 

                    }
                    Console.WriteLine("The factorial for the number {0} that was entered is: {1}", n, result);  
                }
                if (n < 0)

                {
                    for (double i = -1; i >= n; i--)
                    {
                        result = result * i;   //note: The factorial of numbers <-170 is infinity 
                    }
                    Console.WriteLine("The factorial for the number {0} that was entered is: {1}", n, result);
                }
            }
            catch (Exception SystemFormatException)
            {

                Console.WriteLine("The following error occured: {0}", SystemFormatException);
            }
            Console.ReadLine();
        }
    }
}