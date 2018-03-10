// Qu 1. Write a program to save data to text file. 
// There should be a function Save() that accepts 
// one, two or three values as parameter and then save that to the file. 

using System;
using System.IO;

namespace Kp1
{
    public class Characteristics
    {
        public string Name { get; set; }
        public string SSnumber { get; set; }
        public string sAge { get; set; }

        public virtual void Save()
        {
            Console.WriteLine("This is the base class. No Data is Saved.");
        }
    }

    public class Age : Characteristics
    {
        public string sAge { get; set; }
        public string Name { get; set; }
        public string SSnumber { get; set; }
        public string filepath = @"C:\Users\Kristen\Desktop\Test.txt";


        public override void Save()
        {
            string[] createText = { "Name: " + Name + ",  " + "Social: " + SSnumber + ",  " + "Age: " + sAge };

            if (!File.Exists(filepath))
            {
                File.WriteAllLines(filepath, createText);
            }
            else
            {
                File.AppendAllLines(filepath, createText);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            var list = new Characteristics[1000];
            var count = 0;

            while (true)
            {
                Console.Write("E)nterInfo Q)uit:");

                string option = Console.ReadLine();

                switch (option.ToLower())
                {
                    case "e":
                        {
                            var age = new Age();

                            Console.WriteLine("Enter Name:");
                            string EnteredName = Console.ReadLine();

                            Console.WriteLine("Enter Social Security Number:");
                            string EnteredSSnumber = Console.ReadLine();

                            Console.WriteLine("Enter Age:");
                            string EnteredAge = Console.ReadLine();

                            age.Name = EnteredName;
                            age.SSnumber = EnteredSSnumber;
                            age.sAge = EnteredAge;

                            list[count++] = age;

                            age.Save();


                            break;
                        }
                    case "q":
                        {
                            return;
                        }
                }
            }
        }
    }
}
