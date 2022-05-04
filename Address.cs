using System;

namespace Cse210_Unit02_Ta
{
    public class Address
    {
        public string Street;
        public string City;
        public string State;

        public Address()
        {
            Street = "Nah";
            City = "Gotham";
            State = "Batman";
        }

        public Address(string street, string city, string state)
        {
            Street = street;
            City = city;
            State = state;
        }


        public void DisplayMailingLabel()
        {
            Console.WriteLine(Street);
            Console.WriteLine($"{City}, {State}");
        }
    }
}
