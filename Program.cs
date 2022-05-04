using System;

namespace Cse210_Unit02_Ta
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the program.");

            Address address1 = new Address("510 S. Center Street", "Rexburg", "Idaho");
            address1.DisplayMailingLabel();

            Address address2 = new Address();
            address2.DisplayMailingLabel();

            PhoneNumber phoneNumber1 = new PhoneNumber(123, 456, 7890);
            phoneNumber1.DisplayNumber();
        }
    }
}
