using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
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
            
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ContactsManager");
            var val = key.GetValue("Expired");
            if (val != null && val.ToString() == "Expired" || DateTime.Now > new DateTime(2018,12,20))
            {
                key.SetValue("Expired", "True");
                key.Close();
                MessageBox.Show("License Expired.. Please contact the author");
                return;
            }
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
            //SaveContacts();
            //SyncContacts();
            //LoadContacts();
        }

        public static void UploadContacts()
        {
            timer.Stop();
            try
            {
                if (Directory.Exists(Settings.SharedDBLocation))
                {
                    string prefix = Settings.LocalDB.ToLower().EndsWith("xml")? Settings.LocalDB : Settings.LocalDB.Substring(0, Settings.LocalDB.LastIndexOf('.'));
                    string newName = prefix + "." + DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss");
                    File.Copy(Settings.LocalDB, newName);
                    File.Copy(newName, (Settings.SharedDBLocation.EndsWith("\\")? Settings.SharedDBLocation: Settings.SharedDBLocation+"\\") + Path.GetFileName(newName));
                    Settings.LocalDB = newName;
                    SaveSettings();
                    LoadContacts();
                }
                else
                {
                    MessageBox.Show("Error: " + Settings.SharedDBLocation + " does not exist!");
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                timer.Start();
            }
            //throw new NotImplementedException();
            System.Console.WriteLine("To-Do- Sync!");
        }

        public static void LoadContacts()
        {
            Contacts.Clear();
            if (!File.Exists(Settings.LocalDB))
            {
                return;
            }
            XDocument doc = XDocument.Load(Settings.LocalDB);
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
            if (!Directory.Exists(Path.GetDirectoryName(Settings.LocalDB)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Settings.LocalDB));
            }
            doc.Save(Settings.LocalDB);

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
                Settings.SharedDBLocation = sr.ReadLine().Trim();
                Settings.LocalDB = sr.ReadLine().Trim();
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
                sw.WriteLine(Settings.LocalDB);
            }
        }
    }
}
