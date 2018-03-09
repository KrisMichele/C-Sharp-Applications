using System;

namespace Homework3__Not_Using_TimeSpan_
{
    class Program
    {
        static void Main()
        {
            // Write a program that takes seconds and converts it into days, hours, minutes, and seconds. 
            // (Hint: Have a variable that has the number seconds per day, the number seconds per hour, and the number seconds per minute.)  

            Console.WriteLine("Enter a number to represent seconds:");
            string str = Console.ReadLine();   
            int seconds;                        // note: max int value is 2,147,483,647 for 32 bit integer. program will not work for higher second numbers.

            if (int.TryParse(str, out seconds))
            {
                //Convert seconds to days and then take the remainder
                int days = (seconds / 86400);
                int remainsec1 = (seconds % 86400);

                //Convert seconds to hours and then take the remainder
                int hours = (remainsec1 / 3600);
                int remainsec2 = (remainsec1 % 3600);

                //Convert seconds to minutes and then take the remainder
                int minutes = (remainsec2 / 60);
                int remainsec3 = (remainsec2 % 60);

                //Get final seconds after conversion to days, hours, minutes
                int finalsec = remainsec3;

                string display = string.Format(days.ToString("00") + ":" + hours.ToString("00") + ":" + minutes.ToString("00") + ":" + finalsec.ToString("000"));
                Console.WriteLine("The number of seconds entered is displayed in DD:HH:MM:SSS format as: {0}", display);
            }

            else
            {
                Console.WriteLine("Number entered is not a numerical value or is out of range for the int datatype");
            }

        Console.ReadLine();
        }
    }
}
