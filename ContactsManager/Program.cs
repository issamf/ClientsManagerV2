using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactsManager
{
    static class Program
    {
        public static List<ContactsManager.Classes.Contact> Contacts = new List<Classes.Contact>();
        public static Timer timer = new Timer();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            timer.Interval = 1000 * 10;
            timer.Tick += Timer_Tick;
            LoadSettings();
            LoadContacts();
            if (Settings.Language == "Hebrew")
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("he-IL");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("he-IL");
            }
            else if (Settings.Language == "English")
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            //SaveContacts();
            SyncContacts();
        }

        private static void SyncContacts()
        {
            //throw new NotImplementedException();
            System.Console.WriteLine("To-Do- Sync!");
        }

        private static void LoadContacts()
        {
            Contacts.Clear();
            if (!File.Exists(@"c:\temp\contacts.xml"))
            {
                return;
            }
            XDocument doc = XDocument.Load(@"c:\temp\contacts.xml");
            var root = doc.Element("Root");
            var elmContacts = root.Elements("Contact");
            foreach(var elmContact in elmContacts)
            {
                ContactsManager.Classes.Contact contact = new Classes.Contact(elmContact);
                Contacts.Add(contact);
            }
        }

        public static void SaveContacts()
        {
            XDocument doc = new XDocument();
            XElement rootElm = new XElement("Root");
            foreach(var contact in Contacts)
            {
                rootElm.Add(contact.Save());
            }
            doc.Add(rootElm);
            doc.Save(@"c:\temp\contacts.xml");

        }

        private static void LoadSettings()
        {
            if (!File.Exists(@"C:\temp\Settings.txt"))
            {
                Settings.Language = "Hebrew";
                return;
            }
            using (StreamReader sr = new StreamReader(@"C:\temp\Settings.txt"))
            {
                string lang = sr.ReadLine();
                if (lang == "en")
                {
                    Settings.Language = "English";
                }
                else
                {
                    Settings.Language = "Hebrew";
                }
            }
        }
    }
}
