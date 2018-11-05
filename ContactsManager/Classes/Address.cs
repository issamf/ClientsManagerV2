using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager.Classes
{
    public class Address
    {
        public string City { get; set; } = "";
        public string Street { get; set; } = "";
        public string Apartment { get; set; } = "";

        public Address(string city, string street, string apartment)
        {
            City = city;
            Street = street;
            Apartment = apartment;
        }
    }
}
