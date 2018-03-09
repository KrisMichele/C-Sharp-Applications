using System;

namespace EmailDatabase
{
    class DeleteEmail
    {
        private string firstName;
        private string lastName;
        private string password;
        private int defaultPasswordLength = 8;
        private string department;
        private string mailboxCapacity;
        private string companySuffix = "sillycompany.com";

        //Constructor to receive the first and last name
        public DeleteEmail(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            //write to database
            Database deleteDatabase = new Database();
            deleteDatabase.Delete(this.firstName, this.lastName);
        }
    }
}
