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
    public partial class frmChooseLanguage : Form
    {
        public frmChooseLanguage()
        {
            InitializeComponent();
            if (Settings.Language == "Hebrew")
            {
                rbHebrew.Checked = true;
            }
            else if (Settings.Language == "English")
            {
                rbEnglish.Checked = true;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (rbHebrew.Checked)
            {
                Settings.Language = "Hebrew";
            }
            else if (rbEnglish.Checked)
            {
                Settings.Language = "English";
            }
            MessageBox.Show("You have to restart the application for changes to take place", "Restart required", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
