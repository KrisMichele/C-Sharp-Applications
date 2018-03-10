using System;

/*This is actually an phone interview question.
  Basically, you have an array of numbers and you need to determine if the 
array is in ascending order, descending order, or sequential. */

class Program
{
    static void Main()
    {
        // get elements within the array.
        int element;
        int[] array = new int[5];
        bool ascending_result;
        bool descending_result;
        bool sequential_ascending_result;
        bool sequential_descending_result;


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Please enter a number. This will be number {0} of 5 entered:", i);
            element = int.Parse(Console.ReadLine());

            array[i] = element;
        }

        Console.WriteLine("The array content is: {0} ", string.Join(",", array));


        // determine if arrays are sequential, ascending, descending, or none of the above.

        ascending_result = Ascending_Determination(array);
        descending_result = Descending_Determination(array);
        sequential_ascending_result = Sequential_Ascending_Determination(array);
        sequential_descending_result = Sequential_Descending_Determination(array);

        Console.WriteLine("The numbers are ascending is: '{0}'.", ascending_result);
        Console.WriteLine("The numbers are descending is: '{0}'.", descending_result);
        Console.WriteLine("The numbers are sequential and ascending is: '{0}'.", sequential_ascending_result);
        Console.WriteLine("The numbers are sequential and descending is: '{0}'.", sequential_descending_result);

        if (ascending_result == false && descending_result == false && sequential_ascending_result == false && sequential_descending_result == false)
        {
            Console.WriteLine("The numbers are not sequential, ascending or descending.");
        }

        Console.ReadLine();
    }

    
    //Methods:
    static bool Ascending_Determination(int[] array1)
    {
        bool result = true;

        for (int i = 1; i < array1.Length; i++)
        {
            if (array1[i] > array1[i - 1])
            {
                result = true;
            }
            else
            {
                result = false;
                break;
            }
        }
        return result;
    }


    static bool Descending_Determination(int[] array1)
    {
        bool result = true;

        for (int i = (array1.Length - 1); i > 0; i--)
        {
            if (array1[i] < array1[i - 1])
            {
                result = true;
            }
            else
            {
                result = false;
                break;
            }
        }
        return result;
    }


    static bool Sequential_Ascending_Determination(int[] array1)
    {
        bool result = true;

        for (int i = 1; i < array1.Length; i++)
        {
            if (array1[i] == array1[i - 1] + 1)
            {
                result = true;
            }
            else
            {
                result = false;
                break;
            }
        }
        return result;
    }

    static bool Sequential_Descending_Determination(int[] array1)
    {
        bool result = true;
        for (int i = (array1.Length - 2); i >= 0; i--)
        {
            if (array1[i] == array1[i + 1] + 1)
            {
                result = true;
            }
            else
            {
                result = false;
                break;
            }
        }
        return result;
    }
}



