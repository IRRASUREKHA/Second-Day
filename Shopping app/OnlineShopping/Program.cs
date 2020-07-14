using System;

namespace OnlineShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Register(120 ,"Mary" ,new DateTime(1998,12,25), "8897446774" , "marry77@gmail.com" ,
                "Mary143" , "Mary@143" );
            c1.Display();
        }
    }
}
