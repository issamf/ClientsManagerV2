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

        public Contact GetByName(string name)
        {
            foreach(var contact in contacts)
            {
                if (contact.Name.ToLower().Trim() == name.ToLower().Trim())
                {
                    return contact;
                }
            }
            return null;
        }

        public Contact GetBySerial(string serialNum)
        {
            foreach (var contact in contacts)
            {
                if (contact.InternalSerialNumber.ToLower().Trim() == serialNum.ToLower().Trim())
                {
                    return contact;
                }
            }
            return null;
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
            //contacts.Clear();
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
