using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ContactsManager
{
    static class Program
    {
        public static Classes.ContactsCollection Contacts = new Classes.ContactsCollection();
        public static Timer timer = new Timer();



        private static DataTable ReadExcelFile(string filename)
        {
            // Initialize an instance of DataTable 
            DataTable dt = new DataTable();


            try
            {
                // Use SpreadSheetDocument class of Open XML SDK to open excel file 
                using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Open(filename, false))
                {
                    // Get Workbook Part of Spread Sheet Document 
                    WorkbookPart workbookPart = spreadsheetDocument.WorkbookPart;


                    // Get all sheets in spread sheet document  
                    IEnumerable<Sheet> sheetcollection = spreadsheetDocument.WorkbookPart.Workbook.GetFirstChild<Sheets>().Elements<Sheet>();


                    // Get relationship Id 
                    string relationshipId = sheetcollection.First().Id.Value;


                    // Get sheet1 Part of Spread Sheet Document 
                    WorksheetPart worksheetPart = (WorksheetPart)spreadsheetDocument.WorkbookPart.GetPartById(relationshipId);


                    // Get Data in Excel file 
                    SheetData sheetData = worksheetPart.Worksheet.Elements<SheetData>().First();
                    IEnumerable<Row> rowcollection = sheetData.Descendants<Row>();


                    if (rowcollection.Count() == 0)
                    {
                        return dt;
                    }


                    // Add columns 
                    foreach (Cell cell in rowcollection.ElementAt(0))
                    {
                        dt.Columns.Add(GetValueOfCell(spreadsheetDocument, cell));
                    }


                    // Add rows into DataTable 
                    foreach (Row row in rowcollection)
                    {
                        DataRow temprow = dt.NewRow();
                        int columnIndex = 0;
                        foreach (Cell cell in row.Descendants<Cell>())
                        {
                            // Get Cell Column Index 
                            int cellColumnIndex = GetColumnIndex(GetColumnName(cell.CellReference));


                            if (columnIndex < cellColumnIndex)
                            {
                                do
                                {
                                    temprow[columnIndex] = string.Empty;
                                    columnIndex++;
                                }


                                while (columnIndex < cellColumnIndex);
                            }


                            temprow[columnIndex] = GetValueOfCell(spreadsheetDocument, cell);
                            columnIndex++;
                        }


                        // Add the row to DataTable 
                        // the rows include header row 
                        dt.Rows.Add(temprow);
                    }
                }


                // Here remove header row 
                dt.Rows.RemoveAt(0);
                return dt;
            }
            catch (IOException ex)
            {
                throw new IOException(ex.Message);
            }
        }


        /// <summary> 
        ///  Get Value of Cell  
        /// </summary> 
        /// <param name="spreadsheetdocument">SpreadSheet Document Object</param> 
        /// <param name="cell">Cell Object</param> 
        /// <returns>The Value in Cell</returns> 
        private static string GetValueOfCell(SpreadsheetDocument spreadsheetdocument, Cell cell)
        {
            // Get value in Cell 
            SharedStringTablePart sharedString = spreadsheetdocument.WorkbookPart.SharedStringTablePart;
            if (cell.CellValue == null)
            {
                return string.Empty;
            }


            string cellValue = cell.CellValue.InnerText;

            // The condition that the Cell DataType is SharedString 
            if (cell.DataType != null && cell.DataType.Value == CellValues.SharedString)
            {
                return sharedString.SharedStringTable.ChildElements[int.Parse(cellValue)].InnerText;
            }
            else
            {
                return cellValue;
            }
        }

        private static string GetColumnName(string cellReference)
        {
            // Create a regular expression to match the column name of cell
            Regex regex = new Regex("[A-Za-z]+");
            Match match = regex.Match(cellReference);
            return match.Value;
        }
        private static int GetColumnIndex(string columnName)
        {
            int columnIndex = 0;
            int factor = 1;

            // From right to left
            for (int position = columnName.Length - 1; position >= 0; position--)
            {
                // For letters
                if (Char.IsLetter(columnName[position]))
                {
                    columnIndex += factor * ((columnName[position] - 'A') + 1) - 1;
                    factor *= 26;
                }
            }

            return columnIndex;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var dt = ReadExcelFile(@"C:\temp\test2.xlsx");
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("ContactsManager");
            var val = key.GetValue("Expired");
            if (val != null && val.ToString() == "Expired" || DateTime.Now > new DateTime(2018,12,1))
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
            SyncContacts();
            //LoadContacts();
        }

        private static void SyncContacts()
        {
            if (File.Exists(Settings.SharedDBLocation))
            {
                File.Copy(Settings.LocalDBLocation, Settings.LocalDBLocation + ".bak"+DateTime.Now.ToFileTime());
              //  File.Copy(Settings.SharedDBLocation, Settings.LocalDBLocation);
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
