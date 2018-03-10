using System;
using System.Linq;

//Write a program to reverse a given string (apple will be reversed to elppa) 
//or to reverse a given number (1234 will become 4321).

namespace Optional_Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a string.");
            string input = Console.ReadLine();

            string output = "";

            for (int i = input.Length-1; i >= 0; i--)  //use decrementors to perform this.
            {
                output = output +input[i];
            }
            Console.WriteLine("The reverse of string {0} is {1}: ", input, output);
            Console.ReadLine();


            //Note, you can also use Array.Reverse() function to reverse an array

            char [] array = input.ToCharArray();
            Array.Reverse(array);
            string revresult = new string(array);
            Console.WriteLine("The reverse of string {0} is {1}: ", input, revresult);
            Console.ReadLine();


            //Note, you can also use System.LINQ to shorten it into a one-liner.

            string revstring = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine("The reverse of string {0} is {1}: ", input, revstring);
            Console.ReadLine();
        }
    }
}
