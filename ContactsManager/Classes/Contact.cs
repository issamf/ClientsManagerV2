﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsManager.Classes
{
    public class Contact
    {
        public string Name { get; set; } = "";
        public string Status { get; set; } = "";
        public string InternalSerialNumber { get; set; } = "";
        public string ContactPerson { get; set; } = "";
        public string Notes { get; set; } = "";
        public string Email { get; set; } = "";
        public string Phone1 { get; set; } = "";
        public string Phone2 { get; set; } = "";
        public string Phone3 { get; set; } = "";
        public Address Address { get; set; } = null;
        public string Fax { get; set; } = "";

        public Contact(string name, string status, string internalSerialNumber)
        {
            Name = name;
            Status = status;
            InternalSerialNumber = internalSerialNumber;
        }
        public XElement Save()
        {
            return new XElement("Contact",
                new XElement(nameof(Name), Name),
                new XElement(nameof(Status), Status),
                new XElement(nameof(InternalSerialNumber), InternalSerialNumber),
                new XElement(nameof(ContactPerson), ContactPerson),
                new XElement(nameof(Notes), Notes),
                new XElement(nameof(Email), Email),
                new XElement(nameof(Fax), Fax),
                new XElement(nameof(Phone1), Phone1),
                new XElement(nameof(Phone2), Phone2),
                new XElement(nameof(Phone3), Phone3),
                new XElement(nameof(Address),
                    new XAttribute(nameof(Address.City), Address == null? "" : Address.City ),
                    new XAttribute(nameof(Address.Street), Address == null ? "":Address.Street),
                    new XAttribute(nameof(Address.Apartment), Address == null ? "":Address.Apartment)));
        }

        public Contact(XElement node)
        {
            Name = node.Element(nameof(Name)).Value;
            Status = node.Element(nameof(Status)).Value;
            InternalSerialNumber = node.Element(nameof(InternalSerialNumber)).Value;
            ContactPerson = node.Element(nameof(ContactPerson)).Value;
            Notes = node.Element(nameof(Notes)).Value;
            Email = node.Element(nameof(Email)).Value;
            Fax = node.Element(nameof(Fax)).Value;
            Phone1 = node.Element(nameof(Phone1)).Value;
            Phone2 = node.Element(nameof(Phone2)).Value;
            Phone3 = node.Element(nameof(Phone3)).Value;
            Address = new Address(node.Element(nameof(Address)).Attribute(nameof(Address.City)).Value,
                node.Element(nameof(Address)).Attribute(nameof(Address.Street)).Value,
                node.Element(nameof(Address)).Attribute(nameof(Address.Apartment)).Value);
        }
    }
}
