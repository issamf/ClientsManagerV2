using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsManager.Forms
{
    public partial class frmAddEditContact : Form
    {
        public ContactsManager.Classes.Contact Contact = null;
        public frmAddEditContact(ContactsManager.Classes.Contact contact = null)
        {
            InitializeComponent();
            if (contact != null)
            {
                Contact = contact;
                txtName.Text = Contact.Name;
                txtInternalSerial.Text = Contact.InternalSerialNumber;
            }
            else
            {
                Contact = new Classes.Contact();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtInternalSerial.Text == "")
            {
                MessageBox.Show("Some fields are not filled");
                return;
            }
            Contact.Name = txtName.Text.Trim();
            Contact.InternalSerialNumber = txtInternalSerial.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
