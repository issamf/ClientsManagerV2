using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsManager.Forms
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            StringBuilder sb = new StringBuilder();
            sb.Append(Assembly.GetExecutingAssembly().GetName().Name.ToString()+Environment.NewLine);
            sb.Append(Assembly.GetExecutingAssembly().GetName().Version.ToString()+Environment.NewLine);
            lblName.Text = sb.ToString();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
