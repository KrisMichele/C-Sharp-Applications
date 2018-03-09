// Write a program that determines if the first character typed in is alphabetic. 
using System;

class Program
{
    static void Main()
    {
        // Ask for a string
        Console.Write("Please enter a string of numbers and letters:");

        // Read the input and save it into a String Type
        string str = Console.ReadLine();
        char input = str[0];

        bool result = !String.IsNullOrEmpty(str) && Char.IsLetter(input);
            
            //note: !String.IsNullOrEmpty(input) is also added for the cases where string is blank

           if (result == true) 

        Console.WriteLine("The Value is Alphabetical and is the character {0}:", input);

        else 
       
                Console.WriteLine("The Value is Not Alphabetical and the character is {0}", input);

        Console.ReadLine();
    }

}
