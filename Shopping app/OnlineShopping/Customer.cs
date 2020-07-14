using System;
namespace OnlineShopping
{
    class Customer
    {
        int customerID;
        string Name;
        DateTime dob;
        string phonenumber;
        string email;
        string userId;
        string password;

        internal void Register(int customerId, string Name, DateTime dob,
            string phonenumber, string email, string userId, string password)
        {
            this.customerID = customerId;
            this.Name = Name;
            this.dob = dob;
            this.phonenumber = phonenumber;
            this.email = email;
            this.userId = userId;
            this.password = password;

        }
        internal void Display()
        {
            Console.WriteLine($"ID : { customerID}  Name : {Name}  DOB : {dob}  Phonenumber : {phonenumber}" +
                $" Email : {email}  UserId : {userId}  Password : {password} ");
        }

    }

    
}
