namespace ContactsManager.Forms
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.chkName = new System.Windows.Forms.CheckBox();
            this.chkSerial = new System.Windows.Forms.CheckBox();
            this.chkPhone = new System.Windows.Forms.CheckBox();
            this.chkAddress = new System.Windows.Forms.CheckBox();
            this.chkContact = new System.Windows.Forms.CheckBox();
            this.chkEmail = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkAny = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSearchBy
            // 
            resources.ApplyResources(this.lblSearchBy, "lblSearchBy");
            this.lblSearchBy.Name = "lblSearchBy";
            // 
            // chkName
            // 
            resources.ApplyResources(this.chkName, "chkName");
            this.chkName.Name = "chkName";
            this.chkName.UseVisualStyleBackColor = true;
            this.chkName.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkSerial
            // 
            resources.ApplyResources(this.chkSerial, "chkSerial");
            this.chkSerial.Name = "chkSerial";
            this.chkSerial.UseVisualStyleBackColor = true;
            this.chkSerial.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkPhone
            // 
            resources.ApplyResources(this.chkPhone, "chkPhone");
            this.chkPhone.Name = "chkPhone";
            this.chkPhone.UseVisualStyleBackColor = true;
            this.chkPhone.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkAddress
            // 
            resources.ApplyResources(this.chkAddress, "chkAddress");
            this.chkAddress.Name = "chkAddress";
            this.chkAddress.UseVisualStyleBackColor = true;
            this.chkAddress.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkContact
            // 
            resources.ApplyResources(this.chkContact, "chkContact");
            this.chkContact.Name = "chkContact";
            this.chkContact.UseVisualStyleBackColor = true;
            this.chkContact.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkEmail
            // 
            resources.ApplyResources(this.chkEmail, "chkEmail");
            this.chkEmail.Name = "chkEmail";
            this.chkEmail.UseVisualStyleBackColor = true;
            this.chkEmail.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkStatus
            // 
            resources.ApplyResources(this.chkStatus, "chkStatus");
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkOther_CheckedChanged);
            // 
            // chkAny
            // 
            resources.ApplyResources(this.chkAny, "chkAny");
            this.chkAny.Name = "chkAny";
            this.chkAny.UseVisualStyleBackColor = true;
            this.chkAny.CheckedChanged += new System.EventHandler(this.chkAny_CheckedChanged);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearch
            // 
            this.AcceptButton = this.button1;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chkAny);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.chkEmail);
            this.Controls.Add(this.chkContact);
            this.Controls.Add(this.chkAddress);
            this.Controls.Add(this.chkPhone);
            this.Controls.Add(this.chkSerial);
            this.Controls.Add(this.chkName);
            this.Controls.Add(this.lblSearchBy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.CheckBox chkName;
        private System.Windows.Forms.CheckBox chkSerial;
        private System.Windows.Forms.CheckBox chkPhone;
        private System.Windows.Forms.CheckBox chkAddress;
        private System.Windows.Forms.CheckBox chkContact;
        private System.Windows.Forms.CheckBox chkEmail;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkAny;
        private System.Windows.Forms.Button button1;
    }
}