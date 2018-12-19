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
    public partial class frmSearch : Form
    {
        public frmMain.SearchOptions Options = frmMain.SearchOptions.Any;
        public frmSearch(frmMain.SearchOptions options)
        {
            InitializeComponent();
            this.Options = options;
            chkAny.Checked = options.HasFlag(frmMain.SearchOptions.Any);
            if (!chkAny.Checked)
            {
                chkAddress.Checked = options.HasFlag(frmMain.SearchOptions.Address);
                chkContact.Checked = options.HasFlag(frmMain.SearchOptions.Contact);
                chkEmail.Checked = options.HasFlag(frmMain.SearchOptions.Email);
                chkName.Checked = options.HasFlag(frmMain.SearchOptions.Name);
                chkPhone.Checked = options.HasFlag(frmMain.SearchOptions.Phone);
                chkSerial.Checked = options.HasFlag(frmMain.SearchOptions.Serial);
                chkStatus.Checked = options.HasFlag(frmMain.SearchOptions.Status);
                chkId.Checked = options.HasFlag(frmMain.SearchOptions.Id);
                chkInternalCase.Checked = options.HasFlag(frmMain.SearchOptions.InternalCase);
                chkCaseNumber.Checked = options.HasFlag(frmMain.SearchOptions.Case);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options = 0;
            if (chkAny.Checked)
            {
                Options = frmMain.SearchOptions.Any;
            }
            else
            {
                if (chkAddress.Checked) Options |= frmMain.SearchOptions.Address;
                if (chkContact.Checked) Options |= frmMain.SearchOptions.Contact;
                if (chkEmail.Checked) Options |= frmMain.SearchOptions.Email;
                if (chkName.Checked) Options |= frmMain.SearchOptions.Name;
                if (chkSerial.Checked) Options |= frmMain.SearchOptions.Serial;
                if (chkPhone.Checked) Options |= frmMain.SearchOptions.Phone;
                if (chkStatus.Checked) Options |= frmMain.SearchOptions.Status;
                if (chkId.Checked) Options |= frmMain.SearchOptions.Id;
                if (chkInternalCase.Checked) Options |= frmMain.SearchOptions.InternalCase;
                if (chkCaseNumber.Checked) Options |= frmMain.SearchOptions.Case;
            }
            this.Close();
        }

        private void chkOther_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAny.Checked)
            {
                chkAny.CheckedChanged -= chkAny_CheckedChanged;
                chkAny.Checked = false;
                chkAny.CheckedChanged += chkAny_CheckedChanged;
            }
        }

        private void chkAny_CheckedChanged(object sender, EventArgs e)
        {
            chkAddress.CheckedChanged -= chkOther_CheckedChanged;
            chkContact.CheckedChanged -= chkOther_CheckedChanged;
            chkEmail.CheckedChanged -= chkOther_CheckedChanged;
            chkName.CheckedChanged -= chkOther_CheckedChanged;
            chkPhone.CheckedChanged -= chkOther_CheckedChanged;
            chkSerial.CheckedChanged -= chkOther_CheckedChanged;
            chkStatus.CheckedChanged -= chkOther_CheckedChanged;
            chkId.CheckedChanged -= chkOther_CheckedChanged;
            chkInternalCase.CheckedChanged -= chkOther_CheckedChanged;
            chkCaseNumber.CheckedChanged -= chkOther_CheckedChanged;

            chkAddress.Checked = false;
            chkContact.Checked = false;
            chkEmail.Checked = false;
            chkName.Checked = false;
            chkPhone.Checked = false;
            chkSerial.Checked = false;
            chkStatus.Checked = false;
            chkId.Checked = false;
            chkInternalCase.Checked = false; ;
            chkCaseNumber.Checked = false; ;

            chkAddress.CheckedChanged += chkOther_CheckedChanged;
            chkContact.CheckedChanged += chkOther_CheckedChanged;
            chkEmail.CheckedChanged += chkOther_CheckedChanged;
            chkName.CheckedChanged += chkOther_CheckedChanged;
            chkPhone.CheckedChanged += chkOther_CheckedChanged;
            chkSerial.CheckedChanged += chkOther_CheckedChanged;
            chkStatus.CheckedChanged += chkOther_CheckedChanged;
            chkId.CheckedChanged += chkOther_CheckedChanged;
            chkInternalCase.CheckedChanged += chkOther_CheckedChanged;
            chkCaseNumber.CheckedChanged += chkOther_CheckedChanged;
        }
    }
}
