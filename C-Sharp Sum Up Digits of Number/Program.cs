using System;

/* 1. Write a program that calculates the sum of the digits of an integer. 
 * Do not use the input string, convert the user inputted string to an integer 
 * and process that integer. For example, the sum of the digits of the integer 
 * number 2155 is 2 + 1 + 5 + 5 or 13. The program should accept any arbitrary 
 * integer typed in by the user and output the following: (Hint: Assume the number is 
 * never greater than 9999.)  2155  =  2 + 1 + 5 + 5 = 13 */

namespace Optional_Challenge_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Type in an integer that is between 0 and not greater than 9999:");
            string str = Console.ReadLine();
            bool result = int.TryParse(str, out int number);

            if (result == false)
            {
                Console.WriteLine("You entered a non-valid number.");
            }
            else if (number == 0)
            {
                Console.WriteLine("You entered the number zero which does not contain more than one digit to add.");
            }

            else if (number < 0)
            {
                Console.WriteLine("You entered a negative number. Please enter a positive number.");
            }
            else if (number > 0)
            {
                int finalsum = SumUpInteger(number);
                Console.WriteLine("The sum of the individual digits within the integer is: {0}", finalsum);
                Console.ReadLine();
            }
        }

        static int SumUpInteger(int integer)
        {
            int sum = 0;
            char[] character = integer.ToString().ToCharArray();
            {
                if ((integer >= 1) && (integer <= 9))
                {
                    sum = integer;
                }
                else if ((integer >= 10) && (integer <= 99))
                {
                    int firstdigit = (int) Char.GetNumericValue(character[0]);
                    int seconddigit = integer % 10;
                    sum = (firstdigit + seconddigit);
                }
                else if ((integer >= 100) && (integer <= 999))
                {
                    int firstdigit = (int)Char.GetNumericValue(character[0]);
                    int seconddigit = (int)Char.GetNumericValue(character[1]);
                    int thirddigit = integer % 10;
                    sum = (firstdigit + seconddigit + thirddigit);
                }
                   else  if ((integer >= 1000) && (integer <= 9999))
                {
                    int firstdigit = (int)Char.GetNumericValue(character[0]);
                    int seconddigit = (int)Char.GetNumericValue(character[1]);
                    int thirddigit = (int)Char.GetNumericValue(character[2]);
                    int fourthdigit = integer % 10;
                    sum = (firstdigit + seconddigit + thirddigit + fourthdigit);
                }
             return sum;
            }
        }
    }
}