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
        public static Classes.ContactsCollection Contacts = new Classes.ContactsCollection();
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
            timer.Start();
            Application.Run(new frmMain());
        }

        private static void Timer_Tick(object sender, EventArgs e)
        {
            SaveContacts();
            SyncContacts();
            LoadContacts();
        }

        private static void SyncContacts()
        {
            if (File.Exists(Settings.SharedDBLocation))
            {
                File.Copy(Settings.LocalDBLocation, Settings.LocalDBLocation + ".bak"+DateTime.Now.ToFileTime());
                File.Copy(Settings.SharedDBLocation, Settings.LocalDBLocation);
            }
            //throw new NotImplementedException();
            System.Console.WriteLine("To-Do- Sync!");
        }

        private static void LoadContacts()
        {
            Contacts.Clear();
            if (!File.Exists(Settings.LocalDBLocation))
            {
                return;
            }
            XDocument doc = XDocument.Load(Settings.LocalDBLocation);
            var root = doc.Element("Root");
            var elmContacts = root.Elements("Contact");
            foreach (var elmContact in elmContacts)
            {
                ContactsManager.Classes.Contact contact = new Classes.Contact(elmContact);
                Contacts.Add(contact);
            }
        }

        public static void SaveContacts()
        {
            XDocument doc = new XDocument();
            XElement rootElm = new XElement("Root");
            foreach (var contact in Contacts.Contacts)
            {
                rootElm.Add(contact.Save());
            }
            doc.Add(rootElm);
            if (!Directory.Exists(Path.GetDirectoryName(Settings.LocalDBLocation)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Settings.LocalDBLocation));
            }
            doc.Save(Settings.LocalDBLocation);

        }

        private static void LoadSettings()
        {
            if (!File.Exists(Settings.SettingsLocation))
            {
                Settings.Language = "Hebrew";
                return;
            }
            using (StreamReader sr = new StreamReader(Settings.SettingsLocation))
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

        public static void SaveSettings()
        {
            if (!Directory.Exists(Path.GetDirectoryName(Settings.SettingsLocation)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Settings.SettingsLocation));
            }
            using (StreamWriter sw = new StreamWriter(Settings.SettingsLocation))
            {
                sw.WriteLine(Settings.Language.ToLower().Substring(0, 2));
                sw.WriteLine(Settings.SharedDBLocation);
            }
        }
    }
}
