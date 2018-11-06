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
        BindingSource bindingSource = new BindingSource();
        public delegate void ContactChangedHandler(ContactsManager.Classes.Contact newContact);
        protected event ContactChangedHandler ContactChanged;
        protected void OnContactChanged(ContactsManager.Classes.Contact newContact)
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
            txtCity.Text = newContact.Address?.City; txtStreet.Text = newContact.Address?.Street; txtApartment.Text = newContact.Address?.Apartment;
            txtNotes.Text = newContact.Notes;
            txtPhone1.Text = newContact.Phone1;
            txtPhone2.Text = newContact.Phone2;
            txtPhone3.Text = newContact.Phone3;



            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            cmbInternalSerial.SelectedIndexChanged += cmbInternalSerial_SelectedIndexChanged;
            if (ContactChanged != null)
            {
                ContactChanged(newContact);
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
            var frmLang = new Forms.frmChooseLanguage();
            if (frmLang.ShowDialog() == DialogResult.OK)
            {
                ChangeLanguage(Settings.Language);
            }
            frmLang.Dispose();
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
            if (e.KeyCode == Keys.Enter)
            {
                if (!cmbName.Items.Contains(cmbName.Text))
                {
                    MessageBox.Show("New Name!");
                    cmbName.Items.Add(cmbName.Text);
                }
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            var frmAdd = new frmAddContact();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                ContactsManager.Program.Contacts.Add(frmAdd.Contact);
                FillFields();
            }

            CurrentContact = frmAdd.Contact;
            frmAdd.Dispose();
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
                if (!cmbStatus.Items.Contains(contact.Status))
                {
                    cmbStatus.Items.Add(contact.Status);
                }
                txtContact.Text = contact.ContactPerson;
                txtFax.Text = contact.Fax;
                txtEmail.Text = contact.Email;
                txtCity.Text = contact.Address?.City; txtStreet.Text = contact.Address?.Street; txtApartment.Text = contact.Address?.Apartment;
                txtNotes.Text = contact.Notes;
                txtPhone1.Text = contact.Phone1;
                txtPhone2.Text = contact.Phone2;
                txtPhone3.Text = contact.Phone3;

            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            //txtContact.DataBindings.Add("Text",)
            //CurrentContact.Name = cmbName.Text;
            //CurrentContact.InternalSerialNumber = cmbInternalSerial.Text;
            CurrentContact.ContactPerson = txtContact.Text;
            CurrentContact.Fax = txtFax.Text;
            CurrentContact.Email = txtEmail.Text;
            CurrentContact.Address = new Address(txtCity.Text, txtStreet.Text, txtApartment.Text);
            CurrentContact.InternalSerialNumber = cmbInternalSerial.Text;
            CurrentContact.Notes = txtNotes.Text;
            CurrentContact.Status = cmbStatus.Text;
            CurrentContact.Phone1 = txtPhone1.Text;
            CurrentContact.Phone2 = txtPhone2.Text;
            CurrentContact.Phone3 = txtPhone3.Text;
        }
    }
}
