//Create a singly linked list to keep track of items in a database.

using System;

namespace Kristen_s_Linked_List
{
    class Program
    {
        static void Main()
        {
            // create a linked list
            SinglyLinkedList items = new SinglyLinkedList();
            

            // use a never ending loop that shows the user what options they can select 
            while (true) 
            {
                Console.Write(
                    "1. Add an item to the database \n2. Change an item in the database \n3. Delete an item in the database \n4. List all items in the database \n5. Quit \nPlease choose an option from the list( 1, 2, 3, 4, 5, or 6):");


                string str = Console.ReadLine(); // read user's input	

                int number= int.Parse(str); // convert the given string to integer to match our case types shown below

                Console.WriteLine(); // provide an extra blank line on screen

                switch (number)
                {
                    case 1:
                    {
                        Console.WriteLine("Type in the new item you want to add to the database:");
                        String key = Console.ReadLine();
                        items.InsertItem(key);
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("What is the item that you want to change?");
                        String key = Console.ReadLine();
                        items.DeleteItem(key);

                        Console.WriteLine("Type in the new item you want to change in the database:");
                        String newkey = Console.ReadLine();
                        items.InsertItem(newkey);
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Type in the item you want to delete:");
                        String key = Console.ReadLine();
                        items.DeleteItem(key);
                        break;
                    }
                    case 4:
                    {
                        items.DisplayList();
                        break;
                    }
                    case 5:
                    {
                        Environment.Exit(0);
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }

    //start with a simple Node class.
    public class Node
    {
        public string data;
        public Node Next;
        public Node Previous;

        public void DisplayNode()
        {
            Console.WriteLine("<" + data + ">");
        }
    }

    public class SinglyLinkedList
    {
        private Node head;
        private Node current;
        private Node previous;

        public void InsertItem(string data)
        {
            current = head;
            previous = null;

            try
            {
                if (head == null)
                {
                    Node newNode = new Node();
                    newNode.data = data;
                    //pointer. Newnode property of Next is equal to the head.
                    newNode.Next = head;
                    head = newNode;
                }
                else
                {
                    while (current != null)
                    {
                        int result = current.data.CompareTo(data);

                        //beginning of the list
                        if (result == -1 && current.Next != null)
                        {
                            previous = current;
                            current = current.Next;
                            continue;
                        }

                        if (result == -1 && current.Next == null)
                        {
                            Node newNode2 = new Node();
                            newNode2.data = data;
                            current.Next = newNode2;
                            break;
                        }

                        if (result == 1 && previous == null)
                        {
                            Node newNode1 = new Node();
                            newNode1.data = data;
                            //pointer. Newnode property of Next is equal to the head.
                            newNode1.Next = head;
                            head = newNode1;

                            break;
                        }

                        if (result == 1 && previous.Next != null)
                        {
                            Node newNode1 = new Node();
                            newNode1.data = data;
                            //pointer. Newnode property of Next is equal to the head.
                            newNode1.Next = previous.Next;
                            previous.Next = newNode1;
                            break;
                        }

                        if (result == 0) //note: won't work for the last item since current.Next is null.
                        {
                            previous = current;
                            current = current.Next;
                        }
                    }
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        public void DeleteItem(string data)
        {
            current = head;
            int count = 0;

            try
            {
                if (current.data == data)
                {
                    head = head.Next;
                }
                else
                {
                    while (current.Next != null)
                    {
                        if (current.Next.data == data)
                        {
                            current.Next = current.Next.Next;
                            count++;
                            continue;
                        }

                        current = current.Next;
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("This item does not exist in the database.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("There are no items in the database to delete.\n");
                Console.WriteLine(e);
                Console.WriteLine("\n");
                Console.WriteLine("\n");
            } 
        }


        public void DisplayList()
        {
            Console.WriteLine("Listed from First to Last:");
            Node current = head;
            while (current != null)
            {
                current.DisplayNode();
                current = current.Next;
            }
            Console.WriteLine();
        }

    }
}
