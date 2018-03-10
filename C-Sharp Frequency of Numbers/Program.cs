//Determine the frequency of numbers in an array 
//({1,1,2,3,1,4,5,1,2} = 4 1's, 2 2's, 1 3's, 1 4's, 1 5's). 
//Assume that the numbers in the array are between 1 and 100 only.

using System;
using System.Linq;


namespace S5_Op_Challenge_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter in a string of integers.");
            string str = Console.ReadLine();
            char[] array = str.ToCharArray();
            int[] sequence = array.Select(x => int.Parse(x.ToString())).ToArray();


            int [] resultcount =  DetermineDuplicates(sequence);
            for (int i = 0; i < sequence.Length; i++)
            {
                if (resultcount[i] != 0)
                {
                    Console.Write("{0} {1}s\n", resultcount[i], sequence[i]);
                }
            }
            Console.ReadLine();
        }


       static int [] DetermineDuplicates(int[] array)    //find duplicates method
       {
            int i, index, count;

            int [] frequency = new int[100];   //create a frequency array to hold counts of numbers.

           for (i = 0; i < array.Length; i++)
           {
               frequency[i] = 1;   //initialize frequency.
           }
           
           //time complexity is O(n^2) because there are two for loops. Not best solution.
            for (i = 0; i < (array.Length); i++)
           {
               count = 1;

               for (index = i + 1; index < array.Length; index++)
               {
                   if (array[i] == array[index])   //if duplicate element is found
                   {
                       count++;
                       frequency[index] = 0; //makes sure not to count the frequency of the same element again.
                   }
                   if (frequency[i] != 0)    //if frequency of current element is not counted.
                   {
                       frequency[i] = count;
                   }
               }
           }
            return frequency;
        }
    }
}