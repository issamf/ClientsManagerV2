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
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            txtDBLocation.Text = Settings.SharedDBLocation;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Settings.SharedDBLocation = txtDBLocation.Text;
            Settings.LocalDBLocation = txtLocalDBLocation.Text;
            Program.SaveSettings();
        }
    }
}
