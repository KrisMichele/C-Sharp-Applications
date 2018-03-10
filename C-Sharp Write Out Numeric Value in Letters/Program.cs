// Write a program that when given a number, prints the appropriate text (up to 1 million).

using System;

namespace NumberToWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            string result = ConvertToString(number);
            Console.WriteLine("Display is {0}.", result);
            Console.Read();
        }

        static string ConvertToString(int integer)
        {
            string[] ones = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            {
                char[] digits = integer.ToString().ToCharArray();
                string words = " ";

                {
                    if (integer >= 0 && integer <= 19)
                    {
                        words = words + ones[integer];
                    }
                    else if (integer >= 20 && integer <= 99)
                    {
                        int firstDigit = (int)Char.GetNumericValue(digits[0]);
                        int secondPart = integer % 10;

                        words = words + tens[firstDigit];

                        if (secondPart > 0)
                        {
                            words = words + " " + ConvertToString(secondPart);
                        }
                    }
                    else if (integer >= 100 && integer <= 999)
                    {
                        int firstDigit = (int)Char.GetNumericValue(digits[0]);
                        int secondPart = integer % 100;

                        words = words + ones[firstDigit] + " hundred";

                        if (secondPart > 0)
                        {
                            words = words + " and " + ConvertToString(secondPart);
                        }
                    }
                    else if (integer >= 1000 && integer <= 19999)
                    {
                        int firstPart = (int)Char.GetNumericValue(digits[0]);
                        if (integer >= 10000)
                        {
                            string twoDigits = digits[0].ToString() + digits[1].ToString();
                            firstPart = Convert.ToInt16(twoDigits);
                        }
                        int secondPart = integer % 1000;

                        words = words + ones[firstPart] + " thousand";

                        if (secondPart > 0 && secondPart <= 99)
                        {
                            words = words + " and " + ConvertToString(secondPart);
                        }
                        else if (secondPart >= 100)
                        {
                            words = words + " " + ConvertToString(secondPart);
                        }
                    }
                    else if (integer >= 20000 && integer <= 999999)
                    {
                        string firstStringPart = Char.GetNumericValue(digits[0]).ToString() + Char.GetNumericValue(digits[1]).ToString();

                        if (integer >= 100000)
                        {
                            firstStringPart = firstStringPart + Char.GetNumericValue(digits[2]).ToString();
                        }

                        int firstPart = Convert.ToInt16(firstStringPart);
                        int secondPart = integer - (firstPart * 1000);

                        words = words + ConvertToString(firstPart) + " thousand";

                        if (secondPart > 0 && secondPart <= 99)
                        {
                            words = words + " and " + ConvertToString(secondPart);
                        }
                        else if (secondPart >= 100)
                        {
                            words = words + " " + ConvertToString(secondPart);
                        }

                    }
                    else if (integer == 1000000)
                    {
                        words = words + "One million";
                    }
                    return words;
                }
            }
        }
    }
}

