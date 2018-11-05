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
    public partial class frmAddContact : Form
    {
        public ContactsManager.Classes.Contact Contact = null;
        public frmAddContact()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (cmbName.Text == "" || cmbStatus.Text == "" || cmbInternalSerial.Text == "")
            {
                MessageBox.Show("Some fields are not filled");
                return;
            }
            Contact = new Classes.Contact(cmbName.Text, cmbStatus.Text, cmbInternalSerial.Text);
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
