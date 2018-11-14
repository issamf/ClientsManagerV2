using System;
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
        public string CaseNumber { get; set; } = "";
        public string Id { get; set; } = "";
        public string PakeedShouma { get; set; } = "";
        public string Holeya { get; set; } = "";

        public Contact()
        {

        }
        public Contact(string name):this()
        {
            Name = name;
        }
        public XElement Save()
        {
            return new XElement("Contact",
                new XElement(nameof(Name), Name),
                new XElement(nameof(CaseNumber), CaseNumber),
                new XElement(nameof(Id), Id),
                new XElement(nameof(Status), Status),
                new XElement(nameof(InternalSerialNumber), InternalSerialNumber),
                new XElement(nameof(ContactPerson), ContactPerson),
                new XElement(nameof(Notes), Notes),
                new XElement(nameof(Email), Email),
                new XElement(nameof(Fax), Fax),
                new XElement(nameof(Phone1), Phone1),
                new XElement(nameof(Phone2), Phone2),
                new XElement(nameof(Phone3), Phone3),
                new XElement(nameof(PakeedShouma), PakeedShouma),
                new XElement(nameof(Holeya),Holeya),
                new XElement(nameof(Address),
                    new XAttribute(nameof(Address.City), Address == null? "" : Address.City ),
                    new XAttribute(nameof(Address.Street), Address == null ? "":Address.Street),
                    new XAttribute(nameof(Address.ZipCode), Address == null ? "":Address.ZipCode)));
        }

        public Contact(XElement node)
        {
            Name = node.Element(nameof(Name))?.Value;
            Status = node.Element(nameof(Status))?.Value;
            InternalSerialNumber = node.Element(nameof(InternalSerialNumber))?.Value;
            ContactPerson = node.Element(nameof(ContactPerson))?.Value;
            Notes = node.Element(nameof(Notes))?.Value;
            Email = node.Element(nameof(Email))?.Value;
            Fax = node.Element(nameof(Fax))?.Value;
            Phone1 = node.Element(nameof(Phone1))?.Value;
            Phone2 = node.Element(nameof(Phone2))?.Value;
            Phone3 = node.Element(nameof(Phone3))?.Value;
            PakeedShouma = node.Element(nameof(PakeedShouma))?.Value;
            Holeya = node.Element(nameof(Holeya))?.Value;
            Id = node.Element(nameof(Id))?.Value;
            CaseNumber = node.Element(nameof(CaseNumber))?.Value;
            Address = new Address(node.Element(nameof(Address))?.Attribute(nameof(Address.City)).Value,
                node.Element(nameof(Address))?.Attribute(nameof(Address.Street)).Value,
                node.Element(nameof(Address))?.Attribute(nameof(Address.ZipCode)).Value);
        }
    }
}
