// Design a database application to keep track of inventory items.

using System;
using System.Globalization;


namespace Homework_7
{
    public struct Items
    {
        public int itemNumber;
        public string itemDescription;
        public string itemPrice;
        public string itemQuantity;
        public string itemCost;
        public decimal itemValue;
    }

    class Program
    { 
        static void Main()
        {
            var numberOfItems = 0;
            var items = new Items[100]; //container can hold 100 objects.

            while (true)
            {
                Console.Write(
                    "1. Add an item \n2. Change an item \n3. Delete an item \n4. List all items in the database \n5. List items ordered by the user (please give quantity) \n6. Quit \nPlease choose an option from the list( 1, 2, 3, 4, 5, or 6:)");
                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": //Add an item
                    {
                        Console.Write("Please enter the Item ID Number (3 digits):");
                        var item_number = int.Parse(Console.ReadLine());

                        Console.Write("Please enter the Item Description (3 words):");
                        var item_description = Console.ReadLine();
                        
                        Console.Write("Please enter the Item Price (X.XX format):");
                        var item_price = Console.ReadLine();

                        Console.Write("Please enter the Item Quantity on Hand:");
                        var item_quantity = Console.ReadLine();

                        Console.Write("Please enter our Item Cost (X.XX format):");
                        var item_cost = Console.ReadLine();
                        var item_value = (decimal.Parse(item_price, NumberStyles.Currency) *
                                          decimal.Parse(item_quantity));

                        items[numberOfItems].itemNumber = item_number;
                        items[numberOfItems].itemDescription = item_description;
                        items[numberOfItems].itemPrice = item_price;
                        items[numberOfItems].itemQuantity = item_quantity;
                        items[numberOfItems].itemCost = item_cost;
                        items[numberOfItems].itemValue = item_value;

                        numberOfItems++;

                        break;
                    }

                    case "2": //Change an item
                    {
                        Console.Write("Which item number needs to be changed?");
                        var itemNumberToChange = int.Parse(Console.ReadLine());

                        for (int i = 0; i < numberOfItems; i++)
                        {
                            if (itemNumberToChange.Equals(items[i].itemNumber))
                            {
                                // enter in the information for the item change.
                                Console.WriteLine("What is the new Item ID Number (3 digits)?");
                                var new_item_number = int.Parse(Console.ReadLine());

                                Console.WriteLine("What is the new Item Description (3 words)?");
                                var new_item_description = Console.ReadLine();

                                Console.WriteLine("What is the new Item Price (X.XX format)?");
                                var new_item_price = Console.ReadLine();

                                Console.WriteLine("What is the new Item Quantity?");
                                var new_item_quantity = Console.ReadLine();

                                Console.WriteLine("What is our new Item Cost (X.XX format)?");
                                var new_item_cost = Console.ReadLine();

                                var new_item_value = (decimal.Parse(new_item_price, NumberStyles.Currency) *
                                                      decimal.Parse(new_item_quantity));

                                // change the item from the old info to new info.
                                items[i].itemNumber = new_item_number;
                                items[i].itemDescription = new_item_description;
                                items[i].itemPrice = new_item_price;
                                items[i].itemQuantity = new_item_quantity;
                                items[i].itemCost = new_item_cost;
                                items[i].itemValue = new_item_value;
                            }
                            if (!itemNumberToChange.Equals(items[i].itemNumber))
                            {
                                Console.WriteLine("No inventory item could be found matching the input number.");
                            }
                        }

                        break;
                    }

                    case "3": //Delete an item

                    {
                        Console.Write("Which item number needs to be deleted?");
                        var itemNumberToDelete = int.Parse(Console.ReadLine());

                        for (int i = 0; i < numberOfItems; i++)
                        {
                            if (itemNumberToDelete != items[i].itemNumber)
                            {
                                items[i].itemNumber = items[i + 1].itemNumber;
                                items[i].itemDescription = items[i + 1].itemDescription;
                                items[i].itemPrice = items[i + 1].itemPrice;
                                items[i].itemQuantity = items[i + 1].itemQuantity;
                                items[i].itemCost = items[i + 1].itemCost;
                                items[i].itemValue = items[i + 1].itemValue;
                            }

                            numberOfItems--;

                            if (!itemNumberToDelete.Equals(items[i].itemNumber))
                            {
                                Console.WriteLine("No inventory item could be found matching the input number.");
                            }

                        }

                        break;
                    }

                    case "4": //List all items in the database
                    {
                        if (numberOfItems == 0)
                        {
                            Console.WriteLine("No items are in the database.");
                        }

                        Console.WriteLine(
                            "Item Number\tItem Description\tItem Price\tItem Quantity\tItem Cost\tItem Value");
                        Console.WriteLine(
                            "-----------\t----------------\t----------\t-------------\t---------\t----------");
                        for (int index = 0; index < numberOfItems; index++)
                        {
                            Console.WriteLine("{0,10}\t{1,15}\t{2,17}\t{3,13}\t{4,8}\t{5,10:$,##0.00}",
                                items[index].itemNumber,
                                items[index].itemDescription, items[index].itemPrice, items[index].itemQuantity,
                                items[index].itemCost, items[index].itemValue);
                        }

                        break;
                    }

                    case "5": //List the items ordered by the user.
                    {
                        Console.WriteLine("Enter in the item number.");
                        var user_item_number = int.Parse(Console.ReadLine());

                        for (int index = 0; index < numberOfItems; index++)
                        {
                            if (user_item_number != items[index].itemNumber)
                            {
                                Console.WriteLine("No items are in the database that match the user input.");
                            }
                            if (user_item_number == items[index].itemNumber)
                            {
                                Console.WriteLine(
                                    "Item Number\tItem Description\tItem Price\tItem Quantity\tItem Cost\tItem Value");
                                Console.WriteLine(
                                    "-----------\t----------------\t----------\t-------------\t---------\t----------");
                                Console.WriteLine("{0,10}\t{1,15}\t{2,17}\t{3,13}\t{4,8}\t{5,10:$,##0.00}",
                                    items[index].itemNumber,
                                    items[index].itemDescription, items[index].itemPrice, items[index].itemQuantity,
                                    items[index].itemCost, items[index].itemValue);
                            }
                        }
                        break;
                    }
                    case "6": //Quit
                    {
                        Console.WriteLine("Are you sure you want to quit ( Y / N )");
                        var user_input = Console.ReadLine();

                        if (user_input == "Y" || user_input == "y")
                        {
                            Environment.Exit(0);
                        }
                        if (user_input == "N" || user_input == "n")
                        {
                            Console.WriteLine("You selected No. The console will continue to run.");
                        }
                        break;
                    }
                }
                Console.ReadLine();
            }
        }
    }
}