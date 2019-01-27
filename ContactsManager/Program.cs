using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;



namespace ContactsManager
{
    static class Program
    {
        public static Classes.ContactsCollection Contacts = new Classes.ContactsCollection();
        public static Timer timer = new Timer();

        public static long CONTACTS_XML_VERSION = 0;
        public static string LastMD5 = "";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ContactsManager");
            var val = key.GetValue("Expired");
            if (val != null && val.ToString() == "Expired" || DateTime.Now > new DateTime(2019,3,1))
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
            SaveContacts();
            //CheckForUpdates();
        }

        public static void EnableAutoUpdate()
        {
            timer.Start();
        }

        public static void DisableAutoUpdate()
        {
            timer.Stop();
        }

        public static void UploadContacts()
        {
            timer.Stop();
            try
            {
                string sharedDir = Path.GetDirectoryName(Settings.SharedDBLocation);
                if (!Directory.Exists(sharedDir))
                {
                    Directory.CreateDirectory(sharedDir);
                }
                if (File.Exists(Settings.SharedDBLocation))
                {
                    if (!Directory.Exists(sharedDir + "\\Backup"))
                    {
                        Directory.CreateDirectory(sharedDir + "\\Backup");
                    }
                    File.Copy(Settings.SharedDBLocation, sharedDir + "\\Backup\\" + Path.GetFileName(Settings.SharedDBLocation) + "." + DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss"));
                }
                File.Copy(Settings.LocalDB, Settings.SharedDBLocation, true);
                File.WriteAllText(sharedDir + "\\FileVersion", CONTACTS_XML_VERSION.ToString());
                //else
                //{
                //    MessageBox.Show("Error: " + Settings.SharedDBLocation + " does not exist!");
                //    return;
                //}
            }
            catch (Exception ex)
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

        public static bool UpdateContacts()
        {
            timer.Stop();
            try
            {
                string sharedDir = Path.GetDirectoryName(Settings.SharedDBLocation);
                string localDir = Path.GetDirectoryName(Settings.LocalDB);
                if (Directory.Exists(sharedDir) && Directory.Exists(localDir))
                {
                    if (File.Exists(Settings.LocalDB))
                    {
                        if (!Directory.Exists(localDir + "\\Backup"))
                        {
                            Directory.CreateDirectory(localDir + "\\Backup");
                        }
                        File.Copy(Settings.LocalDB, localDir + "\\Backup\\" + Path.GetFileName(Settings.LocalDB) + "." + DateTime.Now.ToString("yyyy.MM.dd_HH.mm.ss"));
                    }
                    
                    File.Copy(Settings.SharedDBLocation, Settings.LocalDB, true);
                    File.Copy(sharedDir + "\\FileVersion", localDir + "\\FileVersion", true);
                    LoadContacts();
                }
                //else
                //{
                //    MessageBox.Show("Error: " + sharedDir + " does not exist!");
                //    return false;
                //}
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                timer.Start();
            }
        }

        public static void LoadContacts()
        {
            Contacts.DisableNotifications();
            Contacts.Clear();
            if (!File.Exists(Settings.LocalDB))
            {
                return;
            }
            XDocument doc = XDocument.Load(Settings.LocalDB);
            var root = doc.Element("Root");
            if (root.Element("Info") != null)
            {
                var info = root.Element("Info");
                CONTACTS_XML_VERSION = info.Attribute("Version") != null ? long.Parse(info.Attribute("Version").Value) : 0;
            }

            var elmContacts = root.Element("Contacts");
            var contactsElements = elmContacts.Elements("Contact");
            foreach (var elmContact in contactsElements)
            {
                ContactsManager.Classes.Contact contact = new Classes.Contact(elmContact);
                Contacts.Add(contact);
            }
            LastMD5 = Contacts.GetMD5();
            Contacts.EnableNotifications();
            Contacts.TriggerUpdateNotification();
        }

        public static void CheckForUpdates()
        {
            bool shouldStart = false;
            if (timer.Enabled)
            {
                timer.Stop();
                shouldStart = true;
            }
            try
            {
                string sharedDir = Path.GetDirectoryName(Settings.SharedDBLocation);
                if (Utils.GetSharedFileVersion(sharedDir + "\\FileVersion") > CONTACTS_XML_VERSION)
                {
                    DialogResult res = MessageBox.Show("There is an update available, please update first.\nUpdate now?\n(IMPORTANT: Your current changes will be lost!)",
                        "An update is available."
                        , MessageBoxButtons.YesNo,
                        MessageBoxIcon.Information);
                    if (res == DialogResult.Yes)
                    {
                        UpdateContacts();
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (shouldStart)
                {
                    timer.Start();
                }
            }
        }

        public static void SaveContacts()
        {
            CheckForUpdates();
            string sharedDir = Path.GetDirectoryName(Settings.SharedDBLocation);
            if (Directory.Exists(sharedDir) && !File.Exists(Settings.SharedDBLocation))
            {
                File.Copy(Settings.LocalDB, Settings.SharedDBLocation);
                File.WriteAllText(sharedDir + "\\FileVersion", CONTACTS_XML_VERSION.ToString());
            }
            var currentMD5 = Contacts.GetMD5();
            if (LastMD5 == currentMD5)
            {
                return;
            }
            LastMD5 = currentMD5;
            CONTACTS_XML_VERSION++;
            XDocument doc = new XDocument();
            XElement rootElm = new XElement("Root");
            XElement infoElm = new XElement("Info", new XAttribute("Version", CONTACTS_XML_VERSION));
            rootElm.Add(infoElm);
            XElement contactsElm = new XElement("Contacts");
            foreach (var contact in Contacts.Contacts)
            {
                contactsElm.Add(contact.Save());
            }
            rootElm.Add(contactsElm);
            doc.Add(rootElm);
            if (!Directory.Exists(Path.GetDirectoryName(Settings.LocalDB)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Settings.LocalDB));
            }
            doc.Save(Settings.LocalDB);
            UploadContacts();
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
