using System;

namespace EmailDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine(
                    "Please choose an option: \n'1' to Add email employee information \n'2' to Change email employee information \n'3' to Delete email employee information \n'4' to Open the database \n'5' to Exit the menu");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: //Add an item
                    {
                        Console.Write("What is the employees first name?");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What is the employees last name?");
                        string lastName = Console.ReadLine();
                        EmailAdd addEmail = new EmailAdd(firstName, lastName);
                        break;
                    }
                    case 2: //Change an item 
                    {
                        Console.Write("What is the employees first name for the info that needs to be changed?");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What is the employees last name for the info that needs to be changed?");
                        string lastName = Console.ReadLine();
                        ChangeEmail changeEmail = new ChangeEmail(firstName, lastName);
                        break;
                    }

                    case 3: //Delete an item
                    {
                        Console.Write("What is the employees first name for the info that needs to be deleted?");
                        string firstName = Console.ReadLine();
                        Console.WriteLine("What is the employees last name for the info that needs to be deleted?");
                        string lastName = Console.ReadLine();
                        DeleteEmail deleteEmail = new DeleteEmail(firstName, lastName);
                        break;
                    }

                    case 4: //open the excel file
                    {
                        Database openExcel = new Database();
                        openExcel.Open();
                        break;
                    }

                    case 5: //exit out of the menu
                    {
                        System.Environment.Exit(1);
                        break;
                    }
                }
            }
        }
    }
}