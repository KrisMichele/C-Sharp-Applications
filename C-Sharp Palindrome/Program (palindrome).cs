using System;

namespace S5_Op_Challenge_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a string.");
            string str = Console.ReadLine();

            string revstring = "";
            
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstring += str[i].ToString();
            }
            if (revstring.Equals(str))
            {
            Console.WriteLine("The string entered IS a palindrome.\nThe string entered is {0} and reverse of the string is {1}.", str,revstring);
            }
            else
            {
            Console.WriteLine("The string entered IS NOT a palindrome.\nThe string entered is {0} and reverse of the string is {1}.", str, revstring);
            }
            Console.ReadLine();

        }
    }
}

/* Others solutions to Reference (Not Performed by Me):
 using System;

namespace Challenge4_1
// Determine if a string is a palindrome ("abc" - is not, "abccba" is a palindrome).
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "abccba";
            var array = value.ToCharArray();
            Array.Reverse(array);
            if (value.Equals(new string(array)))
            {
                Console.WriteLine(value + " is palindrome");
            }
            else
            {
                Console.WriteLine(value + " is not palindrome");
            }
        }
    }
}


    Note: //note: Array.Reverse is reading through the array and then equals the array again.
    You are creating a new array and a new string array. 
    It is better to write code that only loops through the string once without additional objects.
    See below for another example:

using System;

namespace Challenge4_1
// Determine if a string is a palindrome ("abc" - is not, "abccba" is a palindrome).
{
    class Program
    {
        static void Main(string[] args)
        {
            // Another version to play with. From https://www.dotnetperls.com/palindrome
            string str = "abccba";
            int min = 0;
            int max = str.Length - 1;

            bool isPalindrome = false;

            while (isPalindrome == false)
            {
                if (min > max)
                {
                    isPalindrome = true;
                    Console.WriteLine("{0} is a palindrome", str);
                }
                char a = str[min];
                char b = str[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    isPalindrome = false;
                    Console.WriteLine("{0} is not a palindrome", str);
                    break;
                }
                min++;
                max--;
            }
        }
    }
}
*/

 
