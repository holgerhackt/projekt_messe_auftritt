namespace WebcamApp
{
    partial class CameraForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForm));
            cboCamera = new System.Windows.Forms.ComboBox();
            CameraLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            StartCameraButton = new System.Windows.Forms.Button();
            PhotoButton = new System.Windows.Forms.Button();
            NameLabel = new System.Windows.Forms.Label();
            ForenameTextBox = new System.Windows.Forms.TextBox();
            CountryLabel = new System.Windows.Forms.Label();
            CountryTextbox = new System.Windows.Forms.TextBox();
            CityLabel = new System.Windows.Forms.Label();
            CityTextBox = new System.Windows.Forms.TextBox();
            ZipLabel = new System.Windows.Forms.Label();
            PostalcodeTextBox = new System.Windows.Forms.TextBox();
            StreetLabel = new System.Windows.Forms.Label();
            textBoxStreet = new System.Windows.Forms.TextBox();
            HousenumberLabel = new System.Windows.Forms.Label();
            HousenumberTextBox = new System.Windows.Forms.TextBox();
            interestsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            companyCheckedListBox = new System.Windows.Forms.CheckedListBox();
            Submit = new System.Windows.Forms.Button();
            NewCompanyBtn = new System.Windows.Forms.Button();
            NewCompanyPnl = new System.Windows.Forms.Panel();
            AddNewCompanyBtn = new System.Windows.Forms.Button();
            CompanyHouseNrTxtBox = new System.Windows.Forms.TextBox();
            CompanyHouseNrLbl = new System.Windows.Forms.Label();
            CompanyStreetTxtBox = new System.Windows.Forms.TextBox();
            CompanyStreetLbl = new System.Windows.Forms.Label();
            CompanyCityTxtBox = new System.Windows.Forms.TextBox();
            CompanyCityLbl = new System.Windows.Forms.Label();
            CompanyPostalTxtBox = new System.Windows.Forms.TextBox();
            CompanyPostalLbl = new System.Windows.Forms.Label();
            CompanyCountryTxtBox = new System.Windows.Forms.TextBox();
            CompanyCountryLbl = new System.Windows.Forms.Label();
            CompanyNameTxtBox = new System.Windows.Forms.TextBox();
            NewCompanyNameLbl = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            CamAreaHeaderLbl = new System.Windows.Forms.Label();
            NewUserPanel = new System.Windows.Forms.Panel();
            label5 = new System.Windows.Forms.Label();
            EmailTextBox = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            LastnameTextBox = new System.Windows.Forms.TextBox();
            ReturnToCompanies = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NewCompanyPnl.SuspendLayout();
            panel1.SuspendLayout();
            NewUserPanel.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cboCamera
            // 
            cboCamera.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboCamera.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            cboCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cboCamera.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cboCamera.ForeColor = System.Drawing.Color.White;
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new System.Drawing.Point(48, 38);
            cboCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new System.Drawing.Size(508, 22);
            cboCamera.TabIndex = 0;
            // 
            // CameraLabel
            // 
            CameraLabel.AutoSize = true;
            CameraLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CameraLabel.ForeColor = System.Drawing.Color.White;
            CameraLabel.Location = new System.Drawing.Point(4, 46);
            CameraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CameraLabel.Name = "CameraLabel";
            CameraLabel.Size = new System.Drawing.Size(36, 14);
            CameraLabel.TabIndex = 1;
            CameraLabel.Text = "Cams";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(13, 102);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(802, 650);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // StartCameraButton
            // 
            StartCameraButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            StartCameraButton.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            StartCameraButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            StartCameraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StartCameraButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StartCameraButton.ForeColor = System.Drawing.Color.White;
            StartCameraButton.Image = (System.Drawing.Image)resources.GetObject("StartCameraButton.Image");
            StartCameraButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            StartCameraButton.Location = new System.Drawing.Point(564, 35);
            StartCameraButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartCameraButton.Name = "StartCameraButton";
            StartCameraButton.Size = new System.Drawing.Size(103, 27);
            StartCameraButton.TabIndex = 3;
            StartCameraButton.Text = "&Start Cam";
            StartCameraButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            StartCameraButton.UseVisualStyleBackColor = false;
            StartCameraButton.Click += StartCameraButton_Click;
            // 
            // PhotoButton
            // 
            PhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            PhotoButton.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            PhotoButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            PhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            PhotoButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PhotoButton.ForeColor = System.Drawing.Color.White;
            PhotoButton.Image = (System.Drawing.Image)resources.GetObject("PhotoButton.Image");
            PhotoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            PhotoButton.Location = new System.Drawing.Point(686, 35);
            PhotoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PhotoButton.Name = "PhotoButton";
            PhotoButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            PhotoButton.Size = new System.Drawing.Size(110, 27);
            PhotoButton.TabIndex = 4;
            PhotoButton.Text = "TakePicture";
            PhotoButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            PhotoButton.UseVisualStyleBackColor = false;
            PhotoButton.Click += PhotoButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NameLabel.ForeColor = System.Drawing.Color.White;
            NameLabel.Location = new System.Drawing.Point(12, 38);
            NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(62, 14);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Forename";
            // 
            // ForenameTextBox
            // 
            ForenameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ForenameTextBox.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            ForenameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            ForenameTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForenameTextBox.ForeColor = System.Drawing.Color.White;
            ForenameTextBox.Location = new System.Drawing.Point(12, 55);
            ForenameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ForenameTextBox.Name = "ForenameTextBox";
            ForenameTextBox.Size = new System.Drawing.Size(300, 22);
            ForenameTextBox.TabIndex = 7;
            ForenameTextBox.Tag = "Forename";
            // 
            // CountryLabel
            // 
            CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CountryLabel.AutoSize = true;
            CountryLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CountryLabel.ForeColor = System.Drawing.Color.White;
            CountryLabel.Location = new System.Drawing.Point(8, 141);
            CountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new System.Drawing.Size(47, 14);
            CountryLabel.TabIndex = 8;
            CountryLabel.Text = "Country";
            // 
            // CountryTextbox
            // 
            CountryTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CountryTextbox.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            CountryTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            CountryTextbox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CountryTextbox.ForeColor = System.Drawing.Color.White;
            CountryTextbox.Location = new System.Drawing.Point(10, 158);
            CountryTextbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CountryTextbox.Name = "CountryTextbox";
            CountryTextbox.Size = new System.Drawing.Size(640, 22);
            CountryTextbox.TabIndex = 9;
            CountryTextbox.Tag = "Country";
            // 
            // CityLabel
            // 
            CityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CityLabel.AutoSize = true;
            CityLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CityLabel.ForeColor = System.Drawing.Color.White;
            CityLabel.Location = new System.Drawing.Point(173, 199);
            CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new System.Drawing.Size(26, 14);
            CityLabel.TabIndex = 10;
            CityLabel.Text = "City";
            // 
            // CityTextBox
            // 
            CityTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CityTextBox.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            CityTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CityTextBox.ForeColor = System.Drawing.Color.White;
            CityTextBox.Location = new System.Drawing.Point(173, 216);
            CityTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new System.Drawing.Size(477, 22);
            CityTextBox.TabIndex = 11;
            CityTextBox.Tag = "City";
            // 
            // ZipLabel
            // 
            ZipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ZipLabel.AutoSize = true;
            ZipLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ZipLabel.ForeColor = System.Drawing.Color.White;
            ZipLabel.Location = new System.Drawing.Point(10, 199);
            ZipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new System.Drawing.Size(67, 14);
            ZipLabel.TabIndex = 12;
            ZipLabel.Text = "Postalcode";
            // 
            // PostalcodeTextBox
            // 
            PostalcodeTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            PostalcodeTextBox.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            PostalcodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PostalcodeTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            PostalcodeTextBox.ForeColor = System.Drawing.Color.White;
            PostalcodeTextBox.Location = new System.Drawing.Point(10, 216);
            PostalcodeTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PostalcodeTextBox.Name = "PostalcodeTextBox";
            PostalcodeTextBox.Size = new System.Drawing.Size(155, 22);
            PostalcodeTextBox.TabIndex = 13;
            PostalcodeTextBox.Tag = "Postalcode";
            // 
            // StreetLabel
            // 
            StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            StreetLabel.AutoSize = true;
            StreetLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            StreetLabel.ForeColor = System.Drawing.Color.White;
            StreetLabel.Location = new System.Drawing.Point(12, 255);
            StreetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new System.Drawing.Size(39, 14);
            StreetLabel.TabIndex = 14;
            StreetLabel.Text = "Street";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxStreet.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            textBoxStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            textBoxStreet.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            textBoxStreet.ForeColor = System.Drawing.Color.White;
            textBoxStreet.Location = new System.Drawing.Point(10, 275);
            textBoxStreet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new System.Drawing.Size(525, 22);
            textBoxStreet.TabIndex = 15;
            textBoxStreet.Tag = "Street";
            // 
            // HousenumberLabel
            // 
            HousenumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            HousenumberLabel.AutoSize = true;
            HousenumberLabel.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            HousenumberLabel.ForeColor = System.Drawing.Color.White;
            HousenumberLabel.Location = new System.Drawing.Point(543, 258);
            HousenumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HousenumberLabel.Name = "HousenumberLabel";
            HousenumberLabel.Size = new System.Drawing.Size(84, 14);
            HousenumberLabel.TabIndex = 16;
            HousenumberLabel.Text = "Housenumber";
            // 
            // HousenumberTextBox
            // 
            HousenumberTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            HousenumberTextBox.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            HousenumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            HousenumberTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            HousenumberTextBox.ForeColor = System.Drawing.Color.White;
            HousenumberTextBox.Location = new System.Drawing.Point(543, 275);
            HousenumberTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            HousenumberTextBox.Name = "HousenumberTextBox";
            HousenumberTextBox.Size = new System.Drawing.Size(107, 22);
            HousenumberTextBox.TabIndex = 17;
            HousenumberTextBox.Tag = "Housenumber";
            // 
            // interestsCheckedListBox
            // 
            interestsCheckedListBox.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            interestsCheckedListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            interestsCheckedListBox.ForeColor = System.Drawing.Color.White;
            interestsCheckedListBox.FormattingEnabled = true;
            interestsCheckedListBox.Location = new System.Drawing.Point(10, 339);
            interestsCheckedListBox.Name = "interestsCheckedListBox";
            interestsCheckedListBox.Size = new System.Drawing.Size(300, 310);
            interestsCheckedListBox.TabIndex = 18;
            // 
            // companyCheckedListBox
            // 
            companyCheckedListBox.BackColor = System.Drawing.Color.FromArgb(90, 90, 90);
            companyCheckedListBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            companyCheckedListBox.ForeColor = System.Drawing.Color.White;
            companyCheckedListBox.FormattingEnabled = true;
            companyCheckedListBox.Name = "companyCheckedListBox";
            companyCheckedListBox.Size = new System.Drawing.Size(300, 310);
            companyCheckedListBox.TabIndex = 19;
            companyCheckedListBox.Location = new System.Drawing.Point(340, 339);
            // 
            // Submit
            // 
            Submit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Submit.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Submit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Submit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            Submit.ForeColor = System.Drawing.Color.White;
            Submit.Location = new System.Drawing.Point(285, 14);
            Submit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Submit.Name = "Submit";
            Submit.Size = new System.Drawing.Size(88, 27);
            Submit.TabIndex = 20;
            Submit.Text = "Submit";
            Submit.UseMnemonic = false;
            Submit.UseVisualStyleBackColor = false;
            Submit.Click += Submit_Click;
            // 
            // NewCompanyBtn
            // 
            NewCompanyBtn.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            NewCompanyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            NewCompanyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            NewCompanyBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewCompanyBtn.ForeColor = System.Drawing.Color.White;
            NewCompanyBtn.Location = new System.Drawing.Point(540, 316);
            NewCompanyBtn.Name = "NewCompanyBtn";
            NewCompanyBtn.Size = new System.Drawing.Size(110, 23);
            NewCompanyBtn.TabIndex = 21;
            NewCompanyBtn.Text = "New Company";
            NewCompanyBtn.UseVisualStyleBackColor = false;
            NewCompanyBtn.Click += NewCompanyBtn_Click;
            // 
            // NewCompanyPnl
            // 
            NewCompanyPnl.Controls.Add(AddNewCompanyBtn);
            NewCompanyPnl.Controls.Add(CompanyHouseNrTxtBox);
            NewCompanyPnl.Controls.Add(CompanyHouseNrLbl);
            NewCompanyPnl.Controls.Add(CompanyStreetTxtBox);
            NewCompanyPnl.Controls.Add(CompanyStreetLbl);
            NewCompanyPnl.Controls.Add(CompanyCityTxtBox);
            NewCompanyPnl.Controls.Add(CompanyCityLbl);
            NewCompanyPnl.Controls.Add(CompanyPostalTxtBox);
            NewCompanyPnl.Controls.Add(CompanyPostalLbl);
            NewCompanyPnl.Controls.Add(CompanyCountryTxtBox);
            NewCompanyPnl.Controls.Add(CompanyCountryLbl);
            NewCompanyPnl.Controls.Add(CompanyNameTxtBox);
            NewCompanyPnl.Controls.Add(NewCompanyNameLbl);
            NewCompanyPnl.Location = new System.Drawing.Point(340, 339);
            NewCompanyPnl.Name = "NewCompanyPnl";
            NewCompanyPnl.Size = new System.Drawing.Size(310, 310);
            NewCompanyPnl.TabIndex = 22;
            NewCompanyPnl.Visible = false;
            // 
            // AddNewCompanyBtn
            // 
            AddNewCompanyBtn.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            AddNewCompanyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            AddNewCompanyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            AddNewCompanyBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            AddNewCompanyBtn.ForeColor = System.Drawing.Color.White;
            AddNewCompanyBtn.Image = (System.Drawing.Image)resources.GetObject("AddNewCompanyBtn.Image");
            AddNewCompanyBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            AddNewCompanyBtn.Location = new System.Drawing.Point(133, 202);
            AddNewCompanyBtn.Name = "AddNewCompanyBtn";
            AddNewCompanyBtn.Size = new System.Drawing.Size(62, 23);
            AddNewCompanyBtn.TabIndex = 12;
            AddNewCompanyBtn.Text = "Add";
            AddNewCompanyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            AddNewCompanyBtn.UseVisualStyleBackColor = false;
            AddNewCompanyBtn.Click += AddNewCompanyBtn_Click;
            // 
            // CompanyHouseNrTxtBox
            // 
            CompanyHouseNrTxtBox.Location = new System.Drawing.Point(218, 160);
            CompanyHouseNrTxtBox.Name = "CompanyHouseNrTxtBox";
            CompanyHouseNrTxtBox.Size = new System.Drawing.Size(77, 23);
            CompanyHouseNrTxtBox.TabIndex = 11;
            CompanyHouseNrTxtBox.Tag = "Housenumber";
            // 
            // CompanyHouseNrLbl
            // 
            CompanyHouseNrLbl.AutoSize = true;
            CompanyHouseNrLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CompanyHouseNrLbl.ForeColor = System.Drawing.Color.White;
            CompanyHouseNrLbl.Location = new System.Drawing.Point(212, 142);
            CompanyHouseNrLbl.Name = "CompanyHouseNrLbl";
            CompanyHouseNrLbl.Size = new System.Drawing.Size(84, 14);
            CompanyHouseNrLbl.TabIndex = 10;
            CompanyHouseNrLbl.Text = "Housenumber";
            // 
            // CompanyStreetTxtBox
            // 
            CompanyStreetTxtBox.Location = new System.Drawing.Point(3, 160);
            CompanyStreetTxtBox.Name = "CompanyStreetTxtBox";
            CompanyStreetTxtBox.Size = new System.Drawing.Size(210, 23);
            CompanyStreetTxtBox.TabIndex = 9;
            CompanyStreetTxtBox.Tag = "Street";
            // 
            // CompanyStreetLbl
            // 
            CompanyStreetLbl.AutoSize = true;
            CompanyStreetLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CompanyStreetLbl.ForeColor = System.Drawing.Color.White;
            CompanyStreetLbl.Location = new System.Drawing.Point(3, 142);
            CompanyStreetLbl.Name = "CompanyStreetLbl";
            CompanyStreetLbl.Size = new System.Drawing.Size(39, 14);
            CompanyStreetLbl.TabIndex = 8;
            CompanyStreetLbl.Text = "Street";
            // 
            // CompanyCityTxtBox
            // 
            CompanyCityTxtBox.Location = new System.Drawing.Point(74, 116);
            CompanyCityTxtBox.Name = "CompanyCityTxtBox";
            CompanyCityTxtBox.Size = new System.Drawing.Size(221, 23);
            CompanyCityTxtBox.TabIndex = 7;
            CompanyCityTxtBox.Tag = "City";
            // 
            // CompanyCityLbl
            // 
            CompanyCityLbl.AutoSize = true;
            CompanyCityLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CompanyCityLbl.ForeColor = System.Drawing.Color.White;
            CompanyCityLbl.Location = new System.Drawing.Point(74, 98);
            CompanyCityLbl.Name = "CompanyCityLbl";
            CompanyCityLbl.Size = new System.Drawing.Size(26, 14);
            CompanyCityLbl.TabIndex = 6;
            CompanyCityLbl.Text = "City";
            // 
            // CompanyPostalTxtBox
            // 
            CompanyPostalTxtBox.Location = new System.Drawing.Point(3, 116);
            CompanyPostalTxtBox.Name = "CompanyPostalTxtBox";
            CompanyPostalTxtBox.Size = new System.Drawing.Size(68, 23);
            CompanyPostalTxtBox.TabIndex = 5;
            CompanyPostalTxtBox.Tag = "Postalcode";
            // 
            // CompanyPostalLbl
            // 
            CompanyPostalLbl.AutoSize = true;
            CompanyPostalLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CompanyPostalLbl.ForeColor = System.Drawing.Color.White;
            CompanyPostalLbl.Location = new System.Drawing.Point(3, 98);
            CompanyPostalLbl.Name = "CompanyPostalLbl";
            CompanyPostalLbl.Size = new System.Drawing.Size(67, 14);
            CompanyPostalLbl.TabIndex = 4;
            CompanyPostalLbl.Text = "Postalcode";
            // 
            // CompanyCountryTxtBox
            // 
            CompanyCountryTxtBox.Location = new System.Drawing.Point(3, 72);
            CompanyCountryTxtBox.Name = "CompanyCountryTxtBox";
            CompanyCountryTxtBox.Size = new System.Drawing.Size(292, 23);
            CompanyCountryTxtBox.TabIndex = 3;
            CompanyCountryTxtBox.Tag = "Country";
            // 
            // CompanyCountryLbl
            // 
            CompanyCountryLbl.AutoSize = true;
            CompanyCountryLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            CompanyCountryLbl.ForeColor = System.Drawing.Color.White;
            CompanyCountryLbl.Location = new System.Drawing.Point(3, 54);
            CompanyCountryLbl.Name = "CompanyCountryLbl";
            CompanyCountryLbl.Size = new System.Drawing.Size(47, 14);
            CompanyCountryLbl.TabIndex = 2;
            CompanyCountryLbl.Text = "Country";
            // 
            // CompanyNameTxtBox
            // 
            CompanyNameTxtBox.Location = new System.Drawing.Point(3, 28);
            CompanyNameTxtBox.Name = "CompanyNameTxtBox";
            CompanyNameTxtBox.Size = new System.Drawing.Size(292, 23);
            CompanyNameTxtBox.TabIndex = 1;
            // 
            // NewCompanyNameLbl
            // 
            NewCompanyNameLbl.AutoSize = true;
            NewCompanyNameLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            NewCompanyNameLbl.ForeColor = System.Drawing.Color.White;
            NewCompanyNameLbl.Location = new System.Drawing.Point(3, 10);
            NewCompanyNameLbl.Name = "NewCompanyNameLbl";
            NewCompanyNameLbl.Size = new System.Drawing.Size(91, 14);
            NewCompanyNameLbl.TabIndex = 0;
            NewCompanyNameLbl.Text = "Company Name";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(CamAreaHeaderLbl);
            panel1.Controls.Add(CameraLabel);
            panel1.Controls.Add(cboCamera);
            panel1.Controls.Add(StartCameraButton);
            panel1.Controls.Add(PhotoButton);
            panel1.Location = new System.Drawing.Point(13, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(802, 89);
            panel1.TabIndex = 23;
            // 
            // CamAreaHeaderLbl
            // 
            CamAreaHeaderLbl.AutoSize = true;
            CamAreaHeaderLbl.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            CamAreaHeaderLbl.ForeColor = System.Drawing.Color.White;
            CamAreaHeaderLbl.Location = new System.Drawing.Point(4, 7);
            CamAreaHeaderLbl.Name = "CamAreaHeaderLbl";
            CamAreaHeaderLbl.Size = new System.Drawing.Size(124, 23);
            CamAreaHeaderLbl.TabIndex = 5;
            CamAreaHeaderLbl.Text = "Take a picture:";
            // 
            // NewUserPanel
            // 
            NewUserPanel.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            NewUserPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            NewUserPanel.Controls.Add(label5);
            NewUserPanel.Controls.Add(EmailTextBox);
            NewUserPanel.Controls.Add(label4);
            NewUserPanel.Controls.Add(LastnameTextBox);
            NewUserPanel.Controls.Add(ReturnToCompanies);
            NewUserPanel.Controls.Add(label3);
            NewUserPanel.Controls.Add(label2);
            NewUserPanel.Controls.Add(label1);
            NewUserPanel.Controls.Add(NameLabel);
            NewUserPanel.Controls.Add(ForenameTextBox);
            NewUserPanel.Controls.Add(NewCompanyBtn);
            NewUserPanel.Controls.Add(NewCompanyPnl);
            NewUserPanel.Controls.Add(CountryLabel);
            NewUserPanel.Controls.Add(companyCheckedListBox);
            NewUserPanel.Controls.Add(interestsCheckedListBox);
            NewUserPanel.Controls.Add(CountryTextbox);
            NewUserPanel.Controls.Add(ZipLabel);
            NewUserPanel.Controls.Add(PostalcodeTextBox);
            NewUserPanel.Controls.Add(CityLabel);
            NewUserPanel.Controls.Add(HousenumberTextBox);
            NewUserPanel.Controls.Add(CityTextBox);
            NewUserPanel.Controls.Add(HousenumberLabel);
            NewUserPanel.Controls.Add(StreetLabel);
            NewUserPanel.Controls.Add(textBoxStreet);
            NewUserPanel.Location = new System.Drawing.Point(863, 12);
            NewUserPanel.Name = "NewUserPanel";
            NewUserPanel.Size = new System.Drawing.Size(668, 664);
            NewUserPanel.TabIndex = 24;
            // 
            // label5
            // 
            label5.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(15, 89);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(38, 14);
            label5.TabIndex = 30;
            label5.Text = "Email";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            EmailTextBox.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            EmailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            EmailTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            EmailTextBox.ForeColor = System.Drawing.Color.White;
            EmailTextBox.Location = new System.Drawing.Point(12, 106);
            EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new System.Drawing.Size(638, 22);
            EmailTextBox.TabIndex = 3;
            EmailTextBox.Tag = "Email";
            // 
            // label4
            // 
            label4.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(343, 38);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(60, 14);
            label4.TabIndex = 28;
            label4.Text = "Lastname";
            // 
            // LastnameTextBox
            // 
            LastnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            LastnameTextBox.BackColor = System.Drawing.Color.FromArgb(80, 80, 80);
            LastnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            LastnameTextBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LastnameTextBox.ForeColor = System.Drawing.Color.White;
            LastnameTextBox.Location = new System.Drawing.Point(342, 55);
            LastnameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LastnameTextBox.Name = "LastnameTextBox";
            LastnameTextBox.Size = new System.Drawing.Size(308, 22);
            LastnameTextBox.TabIndex = 2;
            LastnameTextBox.Tag = "Lastname";
            // 
            // ReturnToCompanies
            // 
            ReturnToCompanies.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            ReturnToCompanies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            ReturnToCompanies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ReturnToCompanies.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ReturnToCompanies.ForeColor = System.Drawing.Color.White;
            ReturnToCompanies.Location = new System.Drawing.Point(537, 316);
            ReturnToCompanies.Name = "ReturnToCompanies";
            ReturnToCompanies.Size = new System.Drawing.Size(110, 23);
            ReturnToCompanies.TabIndex = 26;
            ReturnToCompanies.Text = "Return";
            ReturnToCompanies.UseVisualStyleBackColor = false;
            ReturnToCompanies.Visible = false;
            ReturnToCompanies.Click += ReturnToCompanies_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(340, 318);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(182, 18);
            label3.TabIndex = 25;
            label3.Text = "Select or add your company:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(10, 318);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(139, 18);
            label2.TabIndex = 24;
            label2.Text = "Select your interests:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(10, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(268, 23);
            label1.TabIndex = 23;
            label1.Text = "Enter your personal information:";
            // 
            // panel3
            // 
            panel3.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            panel3.Controls.Add(Submit);
            panel3.Location = new System.Drawing.Point(863, 699);
            panel3.Name = "panel3";
            panel3.Size = new System.Drawing.Size(668, 53);
            panel3.TabIndex = 25;
            // 
            // CameraForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            ClientSize = new System.Drawing.Size(1543, 764);
            Controls.Add(panel3);
            Controls.Add(NewUserPanel);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CameraForm";
            Text = "Gather personal data";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NewCompanyPnl.ResumeLayout(false);
            NewCompanyPnl.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            NewUserPanel.ResumeLayout(false);
            NewUserPanel.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label CameraLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartCameraButton;
        private System.Windows.Forms.Button PhotoButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox ForenameTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox CountryTextbox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox PostalcodeTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label HousenumberLabel;
        private System.Windows.Forms.TextBox HousenumberTextBox;
        private System.Windows.Forms.CheckedListBox interestsCheckedListBox;
        private System.Windows.Forms.CheckedListBox companyCheckedListBox;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button NewCompanyBtn;
        private System.Windows.Forms.Panel NewCompanyPnl;
        private System.Windows.Forms.Label NewCompanyNameLbl;
        private System.Windows.Forms.Label CompanyCountryLbl;
        private System.Windows.Forms.TextBox CompanyNameTxtBox;
        private System.Windows.Forms.Button AddNewCompanyBtn;
        private System.Windows.Forms.TextBox CompanyHouseNrTxtBox;
        private System.Windows.Forms.Label CompanyHouseNrLbl;
        private System.Windows.Forms.TextBox CompanyStreetTxtBox;
        private System.Windows.Forms.Label CompanyStreetLbl;
        private System.Windows.Forms.TextBox CompanyCityTxtBox;
        private System.Windows.Forms.Label CompanyCityLbl;
        private System.Windows.Forms.TextBox CompanyPostalTxtBox;
        private System.Windows.Forms.Label CompanyPostalLbl;
        private System.Windows.Forms.TextBox CompanyCountryTxtBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CamAreaHeaderLbl;
        private System.Windows.Forms.Panel NewUserPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button ReturnToCompanies;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastnameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox EmailTextBox;
    }
}

