using System;

namespace EmailDatabase
{
    class ChangeEmail
    {
        private string firstName;
        private string lastName;
        private string password;
        private int defaultPasswordLength = 8;
        private string department;
        private string mailboxCapacity;
        private string companySuffix = "sillycompany.com";

        //Constructor to receive the first and last name
        public ChangeEmail(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
            //determine if department is changing then call for a method if yes.
            Console.WriteLine("Has the department changed? (Y/N)");
            string answer1 = Console.ReadLine();
            if (answer1.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
              department = setDepartment();
            }

            //call a method to generate a new password (not optional)
            password = setPassword(defaultPasswordLength);
            Console.WriteLine(password);

            //combine elements to generate an email
            string email = firstName + "." + lastName + "@" + department + "." + companySuffix;
            Console.WriteLine(email);

            //determine if the mailbox capacity is changing then call for a method if yes.
            Console.WriteLine("Will the mailbox capacity change? (Y/N)");
            string answer2 = Console.ReadLine();
            if (answer2.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("What is the new mailbox capacity (in GB)?");
                mailboxCapacity = Console.ReadLine();
            }

            //write to database
            Database changeDatabase = new Database();
           changeDatabase.ChangeTo(this.firstName, this.lastName, department, password, email, mailboxCapacity);

        }

        //Ask for the department
        private string setDepartment()
        {
            Console.WriteLine("What is the department of the employee? \n1.Accounting \n2.Development \n3.Engineering Technology \n4.Finance \n5.Management \n6.Manufacturing \n7.Supply Chain \n8.Warehouse \n9.Human Resources \n10.N/A");
            int departmentChoice = int.Parse(Console.ReadLine());
            switch (departmentChoice)
            {
                case 1:
                    department = "Accounting";
                    break;
                case 2:
                    department = "Development";
                    break;
                case 3:
                    department = "Engineering_Technology";
                    break;
                case 4:
                    department = "Finance";
                    break;
                case 5:
                    department = "Management";
                    break;
                case 6:
                    department = "Manfacturing";
                    break;
                case 7:
                    department = "Supply_Chain";
                    break;
                case 8:
                    department = "Warehouse";
                    break;
                case 9:
                    department = "Human_Resources";
                    break;
                case 10:
                    department = "N/A";
                    break;
            }
            return department;
        }

        //Generate a new random password
        private string setPassword(int defaultPasswordLength)
        {
            string passwordNumberSet = "1234567890";
            string passwordLetterSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz!@#$%^&*";
            char[] password = new char[defaultPasswordLength];
            Random random = new Random();

            for (int i = 0; i < defaultPasswordLength; i++)
            {
                if (i % 2 == 0)
                {
                    password[i] = passwordNumberSet[random.Next(0, passwordNumberSet.Length)];
                }
                else
                {
                    password[i] = passwordLetterSet[random.Next(0, passwordLetterSet.Length)];
                }

            }
            return new string(password);

        }
    }
}
