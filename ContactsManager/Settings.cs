using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsManager
{
    public static class Settings
    {
        public static string Language { get; set; } = "Hebrew";
        public static string SharedDBLocation { get; set; } = @"K:\ContactsManager\Contacts.xml";
        public static string LocalDB { get; set; } = @"C:\temp\ContactsManager\Contacts.xml";
        public static string SettingsLocation { get; set; } = @"C:\temp\ContactsManager\Settings.txt";
    }
}
