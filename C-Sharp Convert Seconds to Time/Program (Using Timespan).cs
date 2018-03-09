using System;

namespace Homework3__Using_TimeSpan_
{
    public class Program
    {
        public static void Main()
        {
            // Write a program that takes seconds and converts it into days, hours, minutes, and seconds. 
            // (Hint: Have a variable that has the number seconds per day, the number seconds per hour, and the number seconds per minute.)  

            Console.WriteLine("Enter a number to represent seconds:");
            string str = Console.ReadLine();
            double totalseconds;

           try

            { if (double.TryParse(str, out totalseconds))
                {
                    TimeSpan time = TimeSpan.FromSeconds(totalseconds);  
                    string display = string.Format("{0:00}:{1:00}:{2:00}:{3:000}", time.Days, time.Hours, time.Minutes, time.Seconds);
                    Console.WriteLine("The number of seconds entered is displayed in DD:HH:MM:SSS format as: {0}", display);
                }

                else
                {
                    Console.WriteLine("You did not enter numerical values. Please re-enter a number to represent seconds.");
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Number entered is out of range");
            }

            Console.ReadLine();
        }

    }
}