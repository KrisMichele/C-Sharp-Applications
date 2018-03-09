using System;

//Write a program that, given the number of hours an employee worked and the hourly wage, computes the employee's weekly pay. 
//Count any hours over 40 as overtime at time and a half. 

namespace Optional_Challenge_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter in the number of hours an employee worked over the week:");
            string str1 = Console.ReadLine();

            Console.WriteLine("Enter in the employee's hourly wage:");
            string str2 = Console.ReadLine();
                try
                {
                double hours = double.Parse(str1);
                double wage = double.Parse(str2);

                if (hours <= 40)
                    {
                        double weeklypay1 = ((hours * wage));
                        Console.WriteLine("The weekly pay if the employee worked 40 hours or less is: {0:C}", weeklypay1);
                    }

                    if ((hours > 40) && (hours < 168))
                    {
                        double weeklypay2 = ((40 * wage) + ((hours - 40) * (wage * 1.5)));
                        Console.WriteLine("The weekly pay if the employee worked greater than 40 hours: {0:C}", weeklypay2);
                    }

                    if (hours >= 168)
                    {
                        Console.WriteLine("You entered a greater number of hours than in a week. Please re-enter.");
                    }
                }

              catch (System.FormatException)
                {
                   Console.WriteLine("There appears to be an issue with the entry. Please retry and enter a numerical value for hours.");
                }
            Console.ReadLine();
        }
    }
}
