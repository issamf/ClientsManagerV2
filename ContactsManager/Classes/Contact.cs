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

        public string CaseType { get; set; } = "";
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
                new XElement(nameof(CaseType), CaseType),
                new XElement(nameof(Address),
                    new XAttribute(nameof(Address.City), Address == null? "" : Address.City ),
                    new XAttribute(nameof(Address.Street), Address == null ? "":Address.Street),
                    new XAttribute(nameof(Address.ZipCode), Address == null ? "":Address.ZipCode)));
        }

        public Contact(XElement node)
        {
            Name = node.Element(nameof(Name)) == null ? "" : node.Element(nameof(Name))?.Value;
            Status = node.Element(nameof(Status)) == null ? "" : node.Element(nameof(Status))?.Value;
            InternalSerialNumber = node.Element(nameof(InternalSerialNumber)) == null ? "" : node.Element(nameof(InternalSerialNumber))?.Value;
            ContactPerson = node.Element(nameof(ContactPerson)) == null ? "" : node.Element(nameof(ContactPerson))?.Value;
            Notes = node.Element(nameof(Notes)) == null ? "" : node.Element(nameof(Notes))?.Value;
            Email = node.Element(nameof(Email)) == null ? "" : node.Element(nameof(Email))?.Value;
            Fax = node.Element(nameof(Fax)) == null ? "" : node.Element(nameof(Fax))?.Value;
            Phone1 = node.Element(nameof(Phone1)) == null ? "" : node.Element(nameof(Phone1))?.Value;
            Phone2 = node.Element(nameof(Phone2)) == null ? "" : node.Element(nameof(Phone2))?.Value;
            Phone3 = node.Element(nameof(Phone3)) == null ? "" : node.Element(nameof(Phone3))?.Value;
            PakeedShouma = node.Element(nameof(PakeedShouma)) == null ? "" : node.Element(nameof(PakeedShouma))?.Value;
            Holeya = node.Element(nameof(Holeya)) == null ? "" : node.Element(nameof(Holeya))?.Value;
            Id = node.Element(nameof(Id)) == null ? "" : node.Element(nameof(Id)).Value;
            CaseNumber = node.Element(nameof(CaseNumber)) == null ? "" : node.Element(nameof(CaseNumber))?.Value;
            CaseType = node.Element(nameof(CaseType)) == null ? "" : node.Element(nameof(CaseType))?.Value;
            Address = node.Element(nameof(Address)) == null ? new Address("", "", "") :
                new Address(
                 node.Element(nameof(Address)).Attribute(nameof(Address.City)) == null ? "" : node.Element(nameof(Address)).Attribute(nameof(Address.City)).Value,
                node.Element(nameof(Address)).Attribute(nameof(Address.Street)) == null ? "" : node.Element(nameof(Address)).Attribute(nameof(Address.Street)).Value,
                node.Element(nameof(Address)).Attribute(nameof(Address.ZipCode)) == null ? "" : node.Element(nameof(Address)).Attribute(nameof(Address.ZipCode)).Value);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append("+Name:");
            sb.Append(Name);
            sb.Append("+Status:");
            sb.Append(Status);
            sb.Append("+InternalSerialNumber:");
            sb.Append(InternalSerialNumber);
            sb.Append("+ContactPerson:");
            sb.Append(ContactPerson);
            sb.Append("+Notes:");
            sb.Append(Notes);
            sb.Append("+Email:");
            sb.Append(Email);
            sb.Append("+Fax:");
            sb.Append(Fax);
            sb.Append("+Phone1:");
            sb.Append(Phone1);
            sb.Append("+Phone2:");
            sb.Append(Phone2);
            sb.Append("+Phone3:");
            sb.Append(Phone1);
            sb.Append("+PakeedShouma:");
            sb.Append(PakeedShouma);
            sb.Append("+Holeya:");
            sb.Append(Holeya);
            sb.Append("+Id:");
            sb.Append(Id);
            sb.Append("+CaseNumber:");
            sb.Append(CaseNumber);
            sb.Append("+CaseType:");
            sb.Append(CaseType);
            sb.Append("+Address.City:");
            sb.Append(Address.City);
            sb.Append("+Address.Street:");
            sb.Append(Address.Street);
            sb.Append("+Address.ZipCode:");
            sb.Append(Address.ZipCode);
            return sb.ToString();
        }
    }
}
