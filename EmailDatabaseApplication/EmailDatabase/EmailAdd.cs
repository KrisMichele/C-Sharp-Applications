using System;

namespace EmailDatabase
{
    class EmailAdd
    {
        private string firstName;
        private string lastName;
        private string password;
        private int defaultPasswordLength = 8;
        private string department;
        private string mailboxCapacity = "500 GB";
        private string companySuffix = "sillycompany.com";

        //Constructor to receive the first and last name
        public EmailAdd(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            //call a method asking for the department
            department = setDepartment();

            //call a method to generate the password
            password = setPassword(defaultPasswordLength);
            Console.WriteLine(password);

            //combine elements to generate an email
            string email = firstName + "." + lastName + "@" + department + "." + companySuffix;
            Console.WriteLine(email);

            //set the mailbox capacity
            mailboxCapacity = setMailboxCapacity(mailboxCapacity);

            //write to database
            Database writeDatabase = new Database();
            writeDatabase.AddTo(this.firstName, this.lastName, department, password, email, mailboxCapacity);


        }

        //Ask for the department
        private string setDepartment()
        {
            Console.WriteLine(
                "What is the department of the employee? \n1.Accounting \n2.Development \n3.Engineering Technology \n4.Finance \n5.Management \n6.Manufacturing \n7.Supply Chain \n8.Warehouse \n9.Human Resources \n10.N/A");
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

        //Generate a random password
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

        //set the mailbox capacity
        private string setMailboxCapacity(string mailboxCapacity)
        {
            this.mailboxCapacity = mailboxCapacity;
            return mailboxCapacity;

        }

    }
}