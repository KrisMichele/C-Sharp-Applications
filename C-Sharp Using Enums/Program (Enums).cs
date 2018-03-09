using System;

// File: enum
// Create a program that determines the number of days for a month using a switch statement.  
// The program should accept the number of the month in question.

enum eMonthNames : int
{
    January = 1,
    February,
    March,
    April,
    May,
    June,
    July,
    August,
    September,
    October,
    November,
    December,

}
enum eMonthDays : int
{
    January = 31,
    February = 29,
    March = 31,
    April = 30,
    May = 31,
    June = 30,
    July = 31,
    August = 31,
    September = 30,
    October = 31,
    November = 30,
    December = 31,

}
class MonthSwitch
{

    static void Main()
    {
        while (true)
        {

            Console.Write("Please enter a Month Number: ");
            string strName = Console.ReadLine();

            int intmonth = int.Parse(strName);

            switch (intmonth)
            {
                case 1:
                    intmonth = (int)eMonthNames.January;

                    Console.WriteLine("The Days for the Month of January are {0}:", (int)eMonthDays.January);

                    break;

                case 2:
                    intmonth = (int)eMonthNames.February;

                    Console.WriteLine("The Days for the Month of February are {0}:", (int)eMonthDays.February);

                    break;


                case 3:

                    intmonth = (int)eMonthNames.March;

                    Console.WriteLine("The Days for the Month of March are {0}:", (int)eMonthDays.March);

                    break;

                case 4:

                    intmonth = (int)eMonthNames.April;

                    Console.WriteLine("The Days for the Month of April are {0}:", (int)eMonthDays.April);

                    break;

                case 5:

                    intmonth = (int)eMonthNames.May;

                    Console.WriteLine("The Days for the Month of May are {0}:", (int)eMonthDays.May);

                    break;

                case 6:

                    intmonth = (int)eMonthNames.June;

                    Console.WriteLine("The Days for the Month of June are {0}:", (int)eMonthDays.June);

                    break;

                case 7:

                    intmonth = (int)eMonthNames.July;

                    Console.WriteLine("The Days for the Month of July are {0}:", (int)eMonthDays.July);

                    break;

                case 8:

                    intmonth = (int)eMonthNames.August;

                    Console.WriteLine("The Days for the Month of August are {0}:", (int)eMonthDays.August);

                    break;

                case 9:

                    intmonth = (int)eMonthNames.September;

                    Console.WriteLine("The Days for the Month of September are {0}:", (int)eMonthDays.September);

                    break;

                case 10:

                    intmonth = (int)eMonthNames.October;

                    Console.WriteLine("The Days for the Month of October are {0}:", (int)eMonthDays.October);

                    break;

                case 11:

                    intmonth = (int)eMonthNames.November;

                    Console.WriteLine("The Days for the Month of November are {0}:", (int)eMonthDays.November);

                    break;

                case 12:

                    intmonth = (int)eMonthNames.December;

                    Console.WriteLine("The Days for the Month of December are {0}:", (int)eMonthDays.December);

                    break;


                default:
                    Console.WriteLine("You did not enter a correct month number. Please try again");

                    break;
            }
        }
    }
}