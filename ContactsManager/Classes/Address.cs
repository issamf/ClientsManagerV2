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
        public string ZipCode { get; set; } = "";

        public Address(string city, string street, string zipCode)
        {
            City = city;
            Street = street;
            ZipCode = zipCode;
        }
        public override string ToString()
        {
            return Street + "," + ZipCode + "," + City;
        }
    }
}
