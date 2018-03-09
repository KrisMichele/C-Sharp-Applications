/* 
Problem Statement:

Create a Queue class to grow as elements are added. Right now it throws and IndexOutOfRangeException when the number 
elements added is larger than the array size.Create an Enqueue class to call a GrowQueue function when the count+1 
is greater than or equal to the array.Length instead of throwing an IndexOutOfRangeException.

Create the GrowQueue function as follows:
// Exercise: grow queue
private void GrowQueue()
{
    // TODO: Create the bigger new array

    // TODO: Copy the elements from the old
    // array to the new array

    // TODO: Reset the head and tail indexes

    // TODO: Point to new queue
}
*/


using System;
using System.Collections.Generic;


namespace OptionalExamProblem
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                Queue queue = new Queue();

                for (int i = 0; i < 5; i++)   //note: chose 5 as the length since 5 will be greater 
                                              //than queuelength in public class Queue and GrowQueue() needs to be used.
                {
                    Console.WriteLine("enter number");
                    queue.Enqueue(int.Parse(Console.ReadLine()));
                }

                foreach (int i in queue)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }

            catch (Exception e)
            {
                System.Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }

    public class Queue
    {
        // create empty array and index fields

        private int[] _array;
        private int _count;
        private int _queuelength;


        // initiate queue
        public Queue()
        {
            _queuelength = 3;
            _array = new int[_queuelength];
            _count = -1;
        }


        //Enqueue function
        public void Enqueue(int number)
        {
            if ((_count + 1) >= _queuelength)
            {
                GrowQueue();
                _array[++_count] = number;
            }
            else
            {
                _array[++_count] = number;
            }
        }


        private void GrowQueue()
        {
            // create bigger array and copy elements to it.
            int[] temp = _array;
            _queuelength = _queuelength * 2;
            _array = new int[_queuelength];

            // reset indexes and point to new array.
            for (int i = 0; i <= _count; i++)
            {
                _array[i] = temp[i];

            }
        }

        // allow a foreach loop to be used.
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _queuelength; i++)
                yield return _array[i];
        }
    }
}