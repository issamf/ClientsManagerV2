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
        }

        private void LoadContactByName(string text)
        {
            throw new NotImplementedException();
        }

        private void cmbInternalSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbInternalSerial.Text == "")
            {
                return;
            }
            LoadContactBySerial(cmbInternalSerial.Text);
        }

        private void LoadContactBySerial(string text)
        {
            throw new NotImplementedException();
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
            }

            frmAdd.Dispose();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbName.DisplayMember = nameof(ContactsManager.Classes.Contact.Name);
            cmbInternalSerial.DisplayMember = nameof(ContactsManager.Classes.Contact.InternalSerialNumber);
            cmbStatus.DisplayMember = nameof(ContactsManager.Classes.Contact.Status);
            FillFields();
        }

        private void FillFields()
        {
            cmbName.Items.Clear();
            cmbInternalSerial.Items.Clear();
            cmbStatus.Items.Clear();
            foreach(var contact in Program.Contacts)
            {
                cmbName.Items.Add(contact);
                cmbInternalSerial.Items.Add(contact);
                cmbStatus.Items.Add(contact);
            }
        }
    }
}
