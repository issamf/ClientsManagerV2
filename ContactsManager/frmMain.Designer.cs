namespace ContactsManager
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblName = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbInternalSerial = new System.Windows.Forms.ComboBox();
            this.lblInternalSerial = new System.Windows.Forms.Label();
            this.lblPhone1 = new System.Windows.Forms.Label();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.txtPhone3 = new System.Windows.Forms.TextBox();
            this.lblPhone3 = new System.Windows.Forms.Label();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.lblFax = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblNotes = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caseNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.internalSerialNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtApartment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchOptions = new System.Windows.Forms.LinkLabel();
            this.lnkClearSearch = new System.Windows.Forms.LinkLabel();
            this.cmbCaseNumber = new System.Windows.Forms.ComboBox();
            this.lblCaseNumber = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lblId = new System.Windows.Forms.Label();
            this.cmbHoleya = new System.Windows.Forms.ComboBox();
            this.lblHoleya = new System.Windows.Forms.Label();
            this.cmbPakeedShouma = new System.Windows.Forms.ComboBox();
            this.lblPakeedShouma = new System.Windows.Forms.Label();
            this.cmbCaseType = new System.Windows.Forms.ComboBox();
            this.lblCaseType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // cmbName
            // 
            resources.ApplyResources(this.cmbName, "cmbName");
            this.cmbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Name = "cmbName";
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            this.cmbName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbName_KeyUp);
            this.cmbName.Validated += new System.EventHandler(this.cmbName_Validated);
            // 
            // cmbStatus
            // 
            resources.ApplyResources(this.cmbStatus, "cmbStatus");
            this.cmbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Name = "cmbStatus";
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.Name = "lblStatus";
            // 
            // cmbInternalSerial
            // 
            resources.ApplyResources(this.cmbInternalSerial, "cmbInternalSerial");
            this.cmbInternalSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbInternalSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbInternalSerial.FormattingEnabled = true;
            this.cmbInternalSerial.Name = "cmbInternalSerial";
            this.cmbInternalSerial.SelectedIndexChanged += new System.EventHandler(this.cmbInternalSerial_SelectedIndexChanged);
            // 
            // lblInternalSerial
            // 
            resources.ApplyResources(this.lblInternalSerial, "lblInternalSerial");
            this.lblInternalSerial.Name = "lblInternalSerial";
            // 
            // lblPhone1
            // 
            resources.ApplyResources(this.lblPhone1, "lblPhone1");
            this.lblPhone1.Name = "lblPhone1";
            // 
            // txtPhone1
            // 
            resources.ApplyResources(this.txtPhone1, "txtPhone1");
            this.txtPhone1.Name = "txtPhone1";
            // 
            // txtPhone2
            // 
            resources.ApplyResources(this.txtPhone2, "txtPhone2");
            this.txtPhone2.Name = "txtPhone2";
            // 
            // lblPhone2
            // 
            resources.ApplyResources(this.lblPhone2, "lblPhone2");
            this.lblPhone2.Name = "lblPhone2";
            // 
            // txtPhone3
            // 
            resources.ApplyResources(this.txtPhone3, "txtPhone3");
            this.txtPhone3.Name = "txtPhone3";
            // 
            // lblPhone3
            // 
            resources.ApplyResources(this.lblPhone3, "lblPhone3");
            this.lblPhone3.Name = "lblPhone3";
            // 
            // txtFax
            // 
            resources.ApplyResources(this.txtFax, "txtFax");
            this.txtFax.Name = "txtFax";
            // 
            // lblFax
            // 
            resources.ApplyResources(this.lblFax, "lblFax");
            this.lblFax.Name = "lblFax";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // lblEmail
            // 
            resources.ApplyResources(this.lblEmail, "lblEmail");
            this.lblEmail.Name = "lblEmail";
            // 
            // txtContact
            // 
            resources.ApplyResources(this.txtContact, "txtContact");
            this.txtContact.Name = "txtContact";
            // 
            // lblContact
            // 
            resources.ApplyResources(this.lblContact, "lblContact");
            this.lblContact.Name = "lblContact";
            // 
            // txtNotes
            // 
            resources.ApplyResources(this.txtNotes, "txtNotes");
            this.txtNotes.Name = "txtNotes";
            // 
            // lblNotes
            // 
            resources.ApplyResources(this.lblNotes, "lblNotes");
            this.lblNotes.Name = "lblNotes";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.caseNumberDataGridViewTextBoxColumn,
            this.internalSerialNumberDataGridViewTextBoxColumn,
            this.contactPersonDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phone1DataGridViewTextBoxColumn,
            this.phone2DataGridViewTextBoxColumn,
            this.phone3DataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.faxDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.contactBindingSource;
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            resources.ApplyResources(this.nameDataGridViewTextBoxColumn, "nameDataGridViewTextBoxColumn");
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            resources.ApplyResources(this.idDataGridViewTextBoxColumn, "idDataGridViewTextBoxColumn");
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            resources.ApplyResources(this.statusDataGridViewTextBoxColumn, "statusDataGridViewTextBoxColumn");
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // caseNumberDataGridViewTextBoxColumn
            // 
            this.caseNumberDataGridViewTextBoxColumn.DataPropertyName = "CaseNumber";
            resources.ApplyResources(this.caseNumberDataGridViewTextBoxColumn, "caseNumberDataGridViewTextBoxColumn");
            this.caseNumberDataGridViewTextBoxColumn.Name = "caseNumberDataGridViewTextBoxColumn";
            this.caseNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // internalSerialNumberDataGridViewTextBoxColumn
            // 
            this.internalSerialNumberDataGridViewTextBoxColumn.DataPropertyName = "InternalSerialNumber";
            resources.ApplyResources(this.internalSerialNumberDataGridViewTextBoxColumn, "internalSerialNumberDataGridViewTextBoxColumn");
            this.internalSerialNumberDataGridViewTextBoxColumn.Name = "internalSerialNumberDataGridViewTextBoxColumn";
            this.internalSerialNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            this.contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            resources.ApplyResources(this.contactPersonDataGridViewTextBoxColumn, "contactPersonDataGridViewTextBoxColumn");
            this.contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            this.contactPersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            resources.ApplyResources(this.notesDataGridViewTextBoxColumn, "notesDataGridViewTextBoxColumn");
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            resources.ApplyResources(this.emailDataGridViewTextBoxColumn, "emailDataGridViewTextBoxColumn");
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phone1DataGridViewTextBoxColumn
            // 
            this.phone1DataGridViewTextBoxColumn.DataPropertyName = "Phone1";
            resources.ApplyResources(this.phone1DataGridViewTextBoxColumn, "phone1DataGridViewTextBoxColumn");
            this.phone1DataGridViewTextBoxColumn.Name = "phone1DataGridViewTextBoxColumn";
            this.phone1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phone2DataGridViewTextBoxColumn
            // 
            this.phone2DataGridViewTextBoxColumn.DataPropertyName = "Phone2";
            resources.ApplyResources(this.phone2DataGridViewTextBoxColumn, "phone2DataGridViewTextBoxColumn");
            this.phone2DataGridViewTextBoxColumn.Name = "phone2DataGridViewTextBoxColumn";
            this.phone2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phone3DataGridViewTextBoxColumn
            // 
            this.phone3DataGridViewTextBoxColumn.DataPropertyName = "Phone3";
            resources.ApplyResources(this.phone3DataGridViewTextBoxColumn, "phone3DataGridViewTextBoxColumn");
            this.phone3DataGridViewTextBoxColumn.Name = "phone3DataGridViewTextBoxColumn";
            this.phone3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            resources.ApplyResources(this.addressDataGridViewTextBoxColumn, "addressDataGridViewTextBoxColumn");
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // faxDataGridViewTextBoxColumn
            // 
            this.faxDataGridViewTextBoxColumn.DataPropertyName = "Fax";
            resources.ApplyResources(this.faxDataGridViewTextBoxColumn, "faxDataGridViewTextBoxColumn");
            this.faxDataGridViewTextBoxColumn.Name = "faxDataGridViewTextBoxColumn";
            this.faxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataSource = typeof(ContactsManager.Classes.Contact);
            // 
            // txtCity
            // 
            resources.ApplyResources(this.txtCity, "txtCity");
            this.txtCity.Name = "txtCity";
            // 
            // lblAddress
            // 
            resources.ApplyResources(this.lblAddress, "lblAddress");
            this.lblAddress.Name = "lblAddress";
            // 
            // txtStreet
            // 
            resources.ApplyResources(this.txtStreet, "txtStreet");
            this.txtStreet.Name = "txtStreet";
            // 
            // txtApartment
            // 
            resources.ApplyResources(this.txtApartment, "txtApartment");
            this.txtApartment.Name = "txtApartment";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importContactsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            // 
            // importContactsToolStripMenuItem
            // 
            resources.ApplyResources(this.importContactsToolStripMenuItem, "importContactsToolStripMenuItem");
            this.importContactsToolStripMenuItem.Name = "importContactsToolStripMenuItem";
            this.importContactsToolStripMenuItem.Click += new System.EventHandler(this.importContactsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            resources.ApplyResources(this.toolsToolStripMenuItem, "toolsToolStripMenuItem");
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewContactToolStripMenuItem,
            this.changeLanguageToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            // 
            // addNewContactToolStripMenuItem
            // 
            resources.ApplyResources(this.addNewContactToolStripMenuItem, "addNewContactToolStripMenuItem");
            this.addNewContactToolStripMenuItem.Name = "addNewContactToolStripMenuItem";
            this.addNewContactToolStripMenuItem.Click += new System.EventHandler(this.addNewContactToolStripMenuItem_Click);
            // 
            // changeLanguageToolStripMenuItem
            // 
            resources.ApplyResources(this.changeLanguageToolStripMenuItem, "changeLanguageToolStripMenuItem");
            this.changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
            this.changeLanguageToolStripMenuItem.Click += new System.EventHandler(this.changeLanguageToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            // 
            // aboutToolStripMenuItem
            // 
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // btnClearFields
            // 
            resources.ApplyResources(this.btnClearFields, "btnClearFields");
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.TabStop = false;
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // btnSearch
            // 
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.TabStop = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSaveChanges
            // 
            resources.ApplyResources(this.btnSaveChanges, "btnSaveChanges");
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.TabStop = false;
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // linkLabel1
            // 
            resources.ApplyResources(this.linkLabel1, "linkLabel1");
            this.linkLabel1.LinkColor = System.Drawing.Color.DodgerBlue;
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.TabStop = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txtSearch
            // 
            resources.ApplyResources(this.txtSearch, "txtSearch");
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TabStop = false;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // lblSearchOptions
            // 
            resources.ApplyResources(this.lblSearchOptions, "lblSearchOptions");
            this.lblSearchOptions.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lblSearchOptions.Name = "lblSearchOptions";
            this.lblSearchOptions.TabStop = true;
            this.lblSearchOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSearchOptions_LinkClicked);
            // 
            // lnkClearSearch
            // 
            resources.ApplyResources(this.lnkClearSearch, "lnkClearSearch");
            this.lnkClearSearch.LinkColor = System.Drawing.Color.DodgerBlue;
            this.lnkClearSearch.Name = "lnkClearSearch";
            this.lnkClearSearch.TabStop = true;
            // 
            // cmbCaseNumber
            // 
            resources.ApplyResources(this.cmbCaseNumber, "cmbCaseNumber");
            this.cmbCaseNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCaseNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCaseNumber.FormattingEnabled = true;
            this.cmbCaseNumber.Name = "cmbCaseNumber";
            // 
            // lblCaseNumber
            // 
            resources.ApplyResources(this.lblCaseNumber, "lblCaseNumber");
            this.lblCaseNumber.Name = "lblCaseNumber";
            // 
            // cmbID
            // 
            resources.ApplyResources(this.cmbID, "cmbID");
            this.cmbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Name = "cmbID";
            // 
            // lblId
            // 
            resources.ApplyResources(this.lblId, "lblId");
            this.lblId.Name = "lblId";
            // 
            // cmbHoleya
            // 
            resources.ApplyResources(this.cmbHoleya, "cmbHoleya");
            this.cmbHoleya.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHoleya.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHoleya.FormattingEnabled = true;
            this.cmbHoleya.Name = "cmbHoleya";
            // 
            // lblHoleya
            // 
            resources.ApplyResources(this.lblHoleya, "lblHoleya");
            this.lblHoleya.Name = "lblHoleya";
            // 
            // cmbPakeedShouma
            // 
            resources.ApplyResources(this.cmbPakeedShouma, "cmbPakeedShouma");
            this.cmbPakeedShouma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPakeedShouma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPakeedShouma.FormattingEnabled = true;
            this.cmbPakeedShouma.Name = "cmbPakeedShouma";
            // 
            // lblPakeedShouma
            // 
            resources.ApplyResources(this.lblPakeedShouma, "lblPakeedShouma");
            this.lblPakeedShouma.Name = "lblPakeedShouma";
            // 
            // cmbCaseType
            // 
            resources.ApplyResources(this.cmbCaseType, "cmbCaseType");
            this.cmbCaseType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCaseType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCaseType.FormattingEnabled = true;
            this.cmbCaseType.Name = "cmbCaseType";
            // 
            // lblCaseType
            // 
            resources.ApplyResources(this.lblCaseType, "lblCaseType");
            this.lblCaseType.Name = "lblCaseType";
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbCaseType);
            this.Controls.Add(this.lblCaseType);
            this.Controls.Add(this.cmbHoleya);
            this.Controls.Add(this.lblHoleya);
            this.Controls.Add(this.cmbPakeedShouma);
            this.Controls.Add(this.lblPakeedShouma);
            this.Controls.Add(this.cmbID);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.cmbCaseNumber);
            this.Controls.Add(this.lblCaseNumber);
            this.Controls.Add(this.lnkClearSearch);
            this.Controls.Add(this.lblSearchOptions);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApartment);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.lblFax);
            this.Controls.Add(this.txtPhone3);
            this.Controls.Add(this.lblPhone3);
            this.Controls.Add(this.txtPhone2);
            this.Controls.Add(this.lblPhone2);
            this.Controls.Add(this.txtPhone1);
            this.Controls.Add(this.lblPhone1);
            this.Controls.Add(this.cmbInternalSerial);
            this.Controls.Add(this.lblInternalSerial);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbInternalSerial;
        private System.Windows.Forms.Label lblInternalSerial;
        private System.Windows.Forms.Label lblPhone1;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.TextBox txtPhone3;
        private System.Windows.Forms.Label lblPhone3;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtApartment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeLanguageToolStripMenuItem;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.LinkLabel lblSearchOptions;
        private System.Windows.Forms.LinkLabel lnkClearSearch;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseNekoyeemDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbCaseNumber;
        private System.Windows.Forms.Label lblCaseNumber;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox cmbHoleya;
        private System.Windows.Forms.Label lblHoleya;
        private System.Windows.Forms.ComboBox cmbPakeedShouma;
        private System.Windows.Forms.Label lblPakeedShouma;
        private System.Windows.Forms.ToolStripMenuItem addNewContactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importContactsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn caseNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn internalSerialNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faxDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbCaseType;
        private System.Windows.Forms.Label lblCaseType;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

