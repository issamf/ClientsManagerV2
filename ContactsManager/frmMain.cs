using ContactsManager.Classes;
using ContactsManager.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsManager
{
    public partial class frmMain : Form
    {
        [Flags]
        public enum SearchOptions
        {
            Any = 1,
            Name = 2,
            Serial = 4,
            Status = 8,
            Phone = 16,
            Address = 32,
            Contact = 64,
            Email = 128
        }

        public SearchOptions searchOptions = SearchOptions.Any;
        BindingSource bindingSource = new BindingSource();
        public delegate void ContactChangedHandler(ContactsManager.Classes.Contact newContact);
        protected event ContactChangedHandler ContactChanged;
        protected void OnContactChanged(ContactsManager.Classes.Contact newContact)
        {
            if (newContact != null)
            {
                cmbName.SelectedIndexChanged -= cmbName_SelectedIndexChanged;
                cmbInternalSerial.SelectedIndexChanged -= cmbInternalSerial_SelectedIndexChanged;
                cmbName.SelectedItem = newContact;
                cmbInternalSerial.SelectedItem = newContact;
                cmbStatus.SelectedItem = newContact.Status;
                //txtContact.DataBindings.Clear();
                //txtContact.DataBindings.Add("Text", newContact, "ContactPerson");
                txtContact.Text = newContact.ContactPerson;
                txtFax.Text = newContact.Fax;
                txtEmail.Text = newContact.Email;
                txtCity.Text = newContact.Address?.City; txtStreet.Text = newContact.Address?.Street; txtApartment.Text = newContact.Address?.ZipCode;
                txtNotes.Text = newContact.Notes;
                txtPhone1.Text = newContact.Phone1;
                txtPhone2.Text = newContact.Phone2;
                txtPhone3.Text = newContact.Phone3;


                cmbStatus.SelectedItem = newContact.Status;
                cmbID.SelectedItem = newContact.Id;
                cmbHoleya.SelectedItem = newContact.Holeya;
                cmbPakeedShouma.SelectedItem = newContact.PakeedShouma;
                cmbCaseNumber.SelectedItem = newContact.CaseNumber;



                cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
                cmbInternalSerial.SelectedIndexChanged += cmbInternalSerial_SelectedIndexChanged;
                if (ContactChanged != null)
                {
                    ContactChanged(newContact);
                }
            }
            else
            {
                cmbName.SelectedIndexChanged -= cmbName_SelectedIndexChanged;
                cmbInternalSerial.SelectedIndexChanged -= cmbInternalSerial_SelectedIndexChanged;
                cmbName.SelectedIndex = -1;
                cmbInternalSerial.SelectedIndex = -1;
                cmbStatus.SelectedIndex =-1;
                //txtContact.DataBindings.Clear();
                //txtContact.DataBindings.Add("Text", newContact, "ContactPerson");
                txtContact.Text = "";
                txtFax.Text = "";
                txtEmail.Text = "";
                txtCity.Text = ""; txtStreet.Text = ""; txtApartment.Text = "";
                txtNotes.Text = "";
                txtPhone1.Text = "";
                txtPhone2.Text = "";
                txtPhone3.Text = "";



                cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
                cmbInternalSerial.SelectedIndexChanged += cmbInternalSerial_SelectedIndexChanged;
                if (ContactChanged != null)
                {
                    ContactChanged(newContact);
                }

            }
        }

        protected ContactsManager.Classes.Contact currentContact = null;
        public ContactsManager.Classes.Contact CurrentContact
        {
            get
            {
                return currentContact;
            }
            set
            {
                currentContact = value;
                OnContactChanged(currentContact);
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void changeLanguageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frmLang = new Forms.frmChooseLanguage())
            {
                if (frmLang.ShowDialog() == DialogResult.OK)
                {
                    ChangeLanguage(Settings.Language);
                }
            }
        }

        private void ChangeLanguage(string language)
        {
            string lang = "en-EN";
            if (Settings.Language == "Hebrew")
            {
                lang = "he-IL";
            }
            else if (Settings.Language == "English")
            {
                lang = "En";
            }

            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMain));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            CurrentContact = null;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = "";
                }
            }
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.Text == "")
            {
                return;
            }
            LoadContactByName(cmbName.Text);
            CurrentContact = (Contact)cmbName.SelectedItem;
        }

        private void LoadContactByName(string text)
        {
            //cmbName.SelectedIndexChanged -= cmbName_SelectedIndexChanged;
            //cmbInternalSerial.SelectedIndexChanged -= cmbInternalSerial_SelectedIndexChanged;
            //CurrentContact = (ContactsManager.Classes.Contact)cmbName.SelectedItem;
            //cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            //cmbInternalSerial.SelectedIndexChanged += cmbInternalSerial_SelectedIndexChanged;
            //throw new NotImplementedException();
            //currentContact = ''
        }

        private void cmbInternalSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInternalSerial.Text == "")
            {
                return;
            }
            LoadContactBySerial(cmbInternalSerial.Text);
            CurrentContact = (Contact)cmbInternalSerial.SelectedItem;
        }

        private void LoadContactBySerial(string text)
        {
           // throw new NotImplementedException();
            //currentContact = ; ;
        }

        private void cmbName_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (!cmbName.Items.Contains(cmbName.Text))
            //    {
            //        MessageBox.Show("New Name!");
            //        cmbName.Items.Add(cmbName.Text);
            //    }
            //}
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbName.DisplayMember = nameof(ContactsManager.Classes.Contact.Name);
            cmbInternalSerial.DisplayMember = nameof(ContactsManager.Classes.Contact.InternalSerialNumber);
            cmbStatus.DisplayMember = nameof(ContactsManager.Classes.Contact.Status);
            FillFields();
        }

        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FillFields()
        {
            //cmbName.DataSource = Program.Contacts.Contacts;
            //cmbInternalSerial.DataSource = Program.Contacts.Contacts;
            cmbName.Items.Clear();
            cmbInternalSerial.Items.Clear();
            cmbStatus.Items.Clear();
            foreach (var contact in Program.Contacts.Contacts)
            {
                cmbName.Items.Add(contact);
                cmbInternalSerial.Items.Add(contact);
                if (!cmbStatus.Items.Contains(contact.Status) && contact.Status.Trim() != "")
                {
                    cmbStatus.Items.Add(contact.Status);
                }
                cmbStatus.SelectedIndex = -1;
                //cmbStatus.SelectedItem = contact.Status;

                txtContact.Text = contact.ContactPerson;
                txtFax.Text = contact.Fax;
                txtEmail.Text = contact.Email;
                txtCity.Text = contact.Address?.City; txtStreet.Text = contact.Address?.Street; txtApartment.Text = contact.Address?.ZipCode;
                txtNotes.Text = contact.Notes;
                txtPhone1.Text = contact.Phone1;
                txtPhone2.Text = contact.Phone2;
                txtPhone3.Text = contact.Phone3;


                if (!cmbID.Items.Contains(contact.Id) && contact.Id.Trim() != "")
                {
                    cmbID.Items.Add(contact.Id);
                }
                //cmbID.SelectedItem = contact.Id;
                cmbID.SelectedIndex = -1;

                if (!cmbHoleya.Items.Contains(contact.Holeya) && contact.Holeya.Trim() != "")
                {
                    cmbHoleya.Items.Add(contact.Holeya);
                }
                //cmbHoleya.SelectedItem = contact.Holeya;
                cmbHoleya.SelectedIndex = -1;

                if (!cmbPakeedShouma.Items.Contains(contact.PakeedShouma) && contact.PakeedShouma.Trim() != "")
                {
                    cmbPakeedShouma.Items.Add(contact.PakeedShouma);
                }
                //cmbPakeedShouma.SelectedItem = contact.Status;
                cmbPakeedShouma.SelectedIndex = -1;

                if (!cmbCaseNumber.Items.Contains(contact.CaseNumber) && contact.CaseNumber.Trim() != "")
                {
                    cmbCaseNumber.Items.Add(contact.CaseNumber);
                }
                //cmbCaseNumber.SelectedItem = contact.CaseNumber;
                cmbCaseNumber.SelectedIndex = -1;

            }
            FillGrid(Program.Contacts.Contacts);
        }

        private void FillGrid(List<Contact> contacts)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = contacts;
            //dataGridView1.Rows.Clear();
            //foreach (var contact in contacts)
            //{
            //    dataGridView1.Rows.Add(contact);
            //}
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (CurrentContact == null)
            {
                return;
            }
            using (frmAreYouSure ask = new frmAreYouSure())
            {
                if (ask.ShowDialog() == DialogResult.No)
                {
                    return;
                }
            }
            //txtContact.DataBindings.Add("Text",)
            //CurrentContact.Name = cmbName.Text;
            //CurrentContact.InternalSerialNumber = cmbInternalSerial.Text;
            CurrentContact.ContactPerson = txtContact.Text.Trim();
            CurrentContact.Fax = txtFax.Text.Trim();
            CurrentContact.Email = txtEmail.Text.Trim();
            CurrentContact.Address = new Address(txtCity.Text.Trim(), txtStreet.Text.Trim(), txtApartment.Text.Trim());
            CurrentContact.InternalSerialNumber = cmbInternalSerial.Text.Trim();
            CurrentContact.Notes = txtNotes.Text.Trim();
            CurrentContact.Status = cmbStatus.Text.Trim();
            CurrentContact.Phone1 = txtPhone1.Text.Trim();
            CurrentContact.Phone2 = txtPhone2.Text.Trim();
            CurrentContact.Phone3 = txtPhone3.Text.Trim();
            CurrentContact.Id = cmbID.Text.Trim();
            CurrentContact.Holeya = cmbHoleya.Text.Trim();
            CurrentContact.PakeedShouma = cmbPakeedShouma.Text.Trim();
            CurrentContact.CaseNumber = cmbCaseNumber.Text.Trim();
            Program.SaveContacts();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrentContact == null)
            {
                return;
            }
            var frmEdit = new frmAddEditContact(CurrentContact);
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                FillFields();
            }

            CurrentContact = frmEdit.Contact;
            frmEdit.Dispose();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrentContact == null)
            {
                return;
            }
            var frmEdit = new frmAddEditContact(CurrentContact);
            if (frmEdit.ShowDialog() == DialogResult.OK)
            {
                FillFields();
            }

            CurrentContact = frmEdit.Contact;
            frmEdit.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (var ask = new frmAreYouSure())
            {
                if (ask.ShowDialog() == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                CurrentContact = dataGridView1.SelectedRows[0].DataBoundItem as Contact;
                //var contacts = Program.Contacts.Get(dataGridView1.SelectedRows[0].Cells[clmName.Name].Value.ToString(), dataGridView1.SelectedRows[0].Cells[clmInternalSerial.Name].Value.ToString());
                //if (contact != null)
                //{
                //    CurrentContact = contact;
                //}
            }
        }

        private void lblSearchOptions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var options = new frmSearch(searchOptions))
            {
                options.ShowDialog();
                searchOptions = options.Options;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string str = txtSearch.Text.ToLower().Trim();
            List<ContactsManager.Classes.Contact> contacts = new List<Contact>();
            foreach (var contact in Program.Contacts.Contacts)
            {

                if (searchOptions.HasFlag(SearchOptions.Any) || searchOptions.HasFlag(SearchOptions.Address))
                {
                    if (contact.Address != null)
                    {
                        if (contact.Address.City.ToLower().Trim().Contains(str) ||
                            contact.Address.Street.ToLower().Trim().Contains(str) ||
                            contact.Address.ZipCode.ToLower().Trim().Contains(str))
                        {
                            contacts.Add(contact);
                            continue;
                        }
                    }
                }
                if (searchOptions.HasFlag(SearchOptions.Any) || searchOptions.HasFlag(SearchOptions.Contact))
                {
                    if (contact.ContactPerson.ToLower().Trim().Contains(str))
                    {
                        contacts.Add(contact);
                        continue;
                    }
                }
                if (searchOptions.HasFlag(SearchOptions.Any) || searchOptions.HasFlag(SearchOptions.Email))
                {
                    if (contact.Email.ToLower().Trim().Contains(str))
                    {
                        contacts.Add(contact);
                        continue;
                    }
                }
                if (searchOptions.HasFlag(SearchOptions.Any) || searchOptions.HasFlag(SearchOptions.Name))
                {
                    if (contact.Name.ToLower().Trim().Contains(str))
                    {
                        contacts.Add(contact);
                        continue;
                    }
                }
                if (searchOptions.HasFlag(SearchOptions.Any) || searchOptions.HasFlag(SearchOptions.Phone))
                {
                    if (contact.Phone1.ToLower().Trim().Contains(str) ||
                        contact.Phone2.ToLower().Trim().Contains(str) ||
                        contact.Phone3.ToLower().Trim().Contains(str))
                    {
                        contacts.Add(contact);
                        continue;
                    }
                }
                if (searchOptions.HasFlag(SearchOptions.Any) || searchOptions.HasFlag(SearchOptions.Serial))
                {
                    if (contact.InternalSerialNumber.ToLower().Trim().Contains(str))
                    {
                        contacts.Add(contact);
                        continue;
                    }
                }
                if (searchOptions.HasFlag(SearchOptions.Any) || searchOptions.HasFlag(SearchOptions.Status))
                {
                    if (contact.Status.ToLower().Trim().Contains(str))
                    {
                        contacts.Add(contact);
                        continue;
                    }
                }

            }
            FillGrid(contacts);
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (var frmAdd = new frmAddEditContact())
            {
                if (frmAdd.ShowDialog() == DialogResult.OK)
                {
                    ContactsManager.Program.Contacts.Add(frmAdd.Contact);
                    FillFields();
                }

                CurrentContact = frmAdd.Contact;
            }
        }
    }
}
