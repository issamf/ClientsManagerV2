using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsManager.Classes
{
    public class ContactsCollection
    {
        protected System.Collections.Concurrent.ConcurrentBag<Contact> contacts = new System.Collections.Concurrent.ConcurrentBag<Contact>();

        //public delegate void ItemsChangedHandler(EventArgs e);
        //protected event ItemsChangedHandler ItemsChanged;
        //protected void OnItemsChanged(EventArgs e)
        //{
        //   // var x = bindingSource.AddNew();
        //    if (ItemsChanged != null)
        //    {
        //        ItemsChanged(e);
        //    }
        //}

        public Contact[] GetByName(string name)
        {
            List<Contact> result = new List<Contact>();
            foreach(var contact in contacts)
            {
                if (contact.Name.ToLower().Trim() == name.ToLower().Trim())
                {
                    result.Add(contact);
                }
            }
            return result.ToArray();
        }

        public Contact[] GetBySerial(string serialNum)
        {
            List<Contact> result = new List<Contact>();
            foreach (var contact in contacts)
            {
                if (contact.InternalSerialNumber.ToLower().Trim() == serialNum.ToLower().Trim())
                {
                    result.Add(contact);
                }
            }
            return result.ToArray();
        }

        public Contact[] GetById(string id)
        {
            List<Contact> result = new List<Contact>();
            foreach (var contact in contacts)
            {
                if (contact.Id.ToLower().Trim() == id.ToLower().Trim())
                {
                    result.Add(contact);
                }
            }
            return result.ToArray();
        }

        public Contact[] Get(string name, string serialNum)
        {
            List<Contact> result = new List<Contact>();
            foreach (var contact in contacts)
            {
                if (contact.Name.ToLower().Trim() == name.ToLower().Trim() &&
                    contact.InternalSerialNumber.ToLower().Trim() == serialNum.ToLower().Trim())
                {
                    result.Add(contact);
                }
            }
            return result.ToArray();
        }
        //public BindingSource bindingSource = new BindingSource();
        public bool Add(Contact contact)
        {
            if (!contacts.Contains(contact))
            {
                contacts.Add(contact);
               // OnItemsChanged(new EventArgs());
                return true;
            }
            else
            {
                return false;
            }    
        }

        public int Count
        {
            get
            {
                return contacts.Count;
            }
        }

        public void Clear()
        {
            contacts = new System.Collections.Concurrent.ConcurrentBag<Contact>();
        }

        public List<Contact> Contacts
        {
            get
            {
                return contacts.ToList();
            }
        }
    }
}
