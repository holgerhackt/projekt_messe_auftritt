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
            cboCamera = new System.Windows.Forms.ComboBox();
            CameraLabel = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            StartCameraButton = new System.Windows.Forms.Button();
            PhotoButton = new System.Windows.Forms.Button();
            NameLabel = new System.Windows.Forms.Label();
            textBoxName = new System.Windows.Forms.TextBox();
            CountryLabel = new System.Windows.Forms.Label();
            textBoxCountry = new System.Windows.Forms.TextBox();
            CityLabel = new System.Windows.Forms.Label();
            textBoxCity = new System.Windows.Forms.TextBox();
            ZipLabel = new System.Windows.Forms.Label();
            textBoxPostcode = new System.Windows.Forms.TextBox();
            StreetLabel = new System.Windows.Forms.Label();
            textBoxStreet = new System.Windows.Forms.TextBox();
            HousenumberLabel = new System.Windows.Forms.Label();
            textBoxHousenumber = new System.Windows.Forms.TextBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            NewCompanyPnl.SuspendLayout();
            SuspendLayout();
            // 
            // cboCamera
            // 
            cboCamera.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cboCamera.FormattingEnabled = true;
            cboCamera.Location = new System.Drawing.Point(87, 35);
            cboCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            cboCamera.Name = "cboCamera";
            cboCamera.Size = new System.Drawing.Size(535, 23);
            cboCamera.TabIndex = 0;
            // 
            // CameraLabel
            // 
            CameraLabel.AutoSize = true;
            CameraLabel.Location = new System.Drawing.Point(42, 38);
            CameraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CameraLabel.Name = "CameraLabel";
            CameraLabel.Size = new System.Drawing.Size(37, 15);
            CameraLabel.TabIndex = 1;
            CameraLabel.Text = "Cams";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new System.Drawing.Point(42, 68);
            pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(779, 634);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // StartCameraButton
            // 
            StartCameraButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            StartCameraButton.Location = new System.Drawing.Point(630, 35);
            StartCameraButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartCameraButton.Name = "StartCameraButton";
            StartCameraButton.Size = new System.Drawing.Size(88, 27);
            StartCameraButton.TabIndex = 3;
            StartCameraButton.Text = "&Start Cam";
            StartCameraButton.UseVisualStyleBackColor = true;
            StartCameraButton.Click += StartCameraButton_Click;
            // 
            // PhotoButton
            // 
            PhotoButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            PhotoButton.Location = new System.Drawing.Point(737, 35);
            PhotoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PhotoButton.Name = "PhotoButton";
            PhotoButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            PhotoButton.Size = new System.Drawing.Size(88, 27);
            PhotoButton.TabIndex = 4;
            PhotoButton.Text = "TakePicture";
            PhotoButton.UseVisualStyleBackColor = true;
            PhotoButton.Click += PhotoButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(852, 35);
            NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(39, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name";
            // 
            // textBoxName
            // 
            textBoxName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxName.Location = new System.Drawing.Point(855, 53);
            textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new System.Drawing.Size(655, 23);
            textBoxName.TabIndex = 7;
            // 
            // CountryLabel
            // 
            CountryLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new System.Drawing.Point(852, 100);
            CountryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new System.Drawing.Size(50, 15);
            CountryLabel.TabIndex = 8;
            CountryLabel.Text = "Country";
            // 
            // textBoxCountry
            // 
            textBoxCountry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxCountry.Location = new System.Drawing.Point(855, 119);
            textBoxCountry.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxCountry.Name = "textBoxCountry";
            textBoxCountry.Size = new System.Drawing.Size(655, 23);
            textBoxCountry.TabIndex = 9;
            // 
            // CityLabel
            // 
            CityLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            CityLabel.AutoSize = true;
            CityLabel.Location = new System.Drawing.Point(852, 165);
            CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new System.Drawing.Size(28, 15);
            CityLabel.TabIndex = 10;
            CityLabel.Text = "City";
            // 
            // textBoxCity
            // 
            textBoxCity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxCity.Location = new System.Drawing.Point(855, 183);
            textBoxCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new System.Drawing.Size(655, 23);
            textBoxCity.TabIndex = 11;
            // 
            // ZipLabel
            // 
            ZipLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            ZipLabel.AutoSize = true;
            ZipLabel.Location = new System.Drawing.Point(852, 224);
            ZipLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ZipLabel.Name = "ZipLabel";
            ZipLabel.Size = new System.Drawing.Size(65, 15);
            ZipLabel.TabIndex = 12;
            ZipLabel.Text = "Postalcode";
            // 
            // textBoxPostcode
            // 
            textBoxPostcode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxPostcode.Location = new System.Drawing.Point(855, 242);
            textBoxPostcode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxPostcode.Name = "textBoxPostcode";
            textBoxPostcode.Size = new System.Drawing.Size(655, 23);
            textBoxPostcode.TabIndex = 13;
            // 
            // StreetLabel
            // 
            StreetLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new System.Drawing.Point(852, 287);
            StreetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new System.Drawing.Size(37, 15);
            StreetLabel.TabIndex = 14;
            StreetLabel.Text = "Street";
            // 
            // textBoxStreet
            // 
            textBoxStreet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxStreet.Location = new System.Drawing.Point(855, 306);
            textBoxStreet.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxStreet.Name = "textBoxStreet";
            textBoxStreet.Size = new System.Drawing.Size(655, 23);
            textBoxStreet.TabIndex = 15;
            // 
            // HousenumberLabel
            // 
            HousenumberLabel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            HousenumberLabel.AutoSize = true;
            HousenumberLabel.Location = new System.Drawing.Point(852, 345);
            HousenumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            HousenumberLabel.Name = "HousenumberLabel";
            HousenumberLabel.Size = new System.Drawing.Size(83, 15);
            HousenumberLabel.TabIndex = 16;
            HousenumberLabel.Text = "Housenumber";
            // 
            // textBoxHousenumber
            // 
            textBoxHousenumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            textBoxHousenumber.Location = new System.Drawing.Point(855, 363);
            textBoxHousenumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBoxHousenumber.Name = "textBoxHousenumber";
            textBoxHousenumber.Size = new System.Drawing.Size(655, 23);
            textBoxHousenumber.TabIndex = 17;
            // 
            // interestsCheckedListBox
            // 
            interestsCheckedListBox.FormattingEnabled = true;
            interestsCheckedListBox.Location = new System.Drawing.Point(852, 392);
            interestsCheckedListBox.Name = "interestsCheckedListBox";
            interestsCheckedListBox.Size = new System.Drawing.Size(364, 310);
            interestsCheckedListBox.TabIndex = 18;
            // 
            // companyCheckedListBox
            // 
            companyCheckedListBox.FormattingEnabled = true;
            companyCheckedListBox.Location = new System.Drawing.Point(1222, 392);
            companyCheckedListBox.Name = "companyCheckedListBox";
            companyCheckedListBox.Size = new System.Drawing.Size(288, 310);
            companyCheckedListBox.TabIndex = 19;
            // 
            // Submit
            // 
            Submit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            Submit.Location = new System.Drawing.Point(733, 708);
            Submit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Submit.Name = "Submit";
            Submit.Size = new System.Drawing.Size(88, 27);
            Submit.TabIndex = 20;
            Submit.Text = "Submit";
            Submit.UseMnemonic = false;
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // NewCompanyBtn
            // 
            NewCompanyBtn.Location = new System.Drawing.Point(1222, 710);
            NewCompanyBtn.Name = "NewCompanyBtn";
            NewCompanyBtn.Size = new System.Drawing.Size(110, 23);
            NewCompanyBtn.TabIndex = 21;
            NewCompanyBtn.Text = "New Company";
            NewCompanyBtn.UseVisualStyleBackColor = true;
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
            NewCompanyPnl.Location = new System.Drawing.Point(1222, 392);
            NewCompanyPnl.Name = "NewCompanyPnl";
            NewCompanyPnl.Size = new System.Drawing.Size(298, 310);
            NewCompanyPnl.TabIndex = 22;
            NewCompanyPnl.Visible = false;
            // 
            // AddNewCompanyBtn
            // 
            AddNewCompanyBtn.Location = new System.Drawing.Point(3, 200);
            AddNewCompanyBtn.Name = "AddNewCompanyBtn";
            AddNewCompanyBtn.Size = new System.Drawing.Size(75, 23);
            AddNewCompanyBtn.TabIndex = 12;
            AddNewCompanyBtn.Text = "Add";
            AddNewCompanyBtn.UseVisualStyleBackColor = true;
            AddNewCompanyBtn.Click += AddNewCompanyBtn_Click;
            // 
            // CompanyHouseNrTxtBox
            // 
            CompanyHouseNrTxtBox.Location = new System.Drawing.Point(218, 160);
            CompanyHouseNrTxtBox.Name = "CompanyHouseNrTxtBox";
            CompanyHouseNrTxtBox.Size = new System.Drawing.Size(77, 23);
            CompanyHouseNrTxtBox.TabIndex = 11;
            // 
            // CompanyHouseNrLbl
            // 
            CompanyHouseNrLbl.AutoSize = true;
            CompanyHouseNrLbl.Location = new System.Drawing.Point(212, 142);
            CompanyHouseNrLbl.Name = "CompanyHouseNrLbl";
            CompanyHouseNrLbl.Size = new System.Drawing.Size(83, 15);
            CompanyHouseNrLbl.TabIndex = 10;
            CompanyHouseNrLbl.Text = "Housenumber";
            // 
            // CompanyStreetTxtBox
            // 
            CompanyStreetTxtBox.Location = new System.Drawing.Point(3, 160);
            CompanyStreetTxtBox.Name = "CompanyStreetTxtBox";
            CompanyStreetTxtBox.Size = new System.Drawing.Size(210, 23);
            CompanyStreetTxtBox.TabIndex = 9;
            // 
            // CompanyStreetLbl
            // 
            CompanyStreetLbl.AutoSize = true;
            CompanyStreetLbl.Location = new System.Drawing.Point(3, 142);
            CompanyStreetLbl.Name = "CompanyStreetLbl";
            CompanyStreetLbl.Size = new System.Drawing.Size(37, 15);
            CompanyStreetLbl.TabIndex = 8;
            CompanyStreetLbl.Text = "Street";
            // 
            // CompanyCityTxtBox
            // 
            CompanyCityTxtBox.Location = new System.Drawing.Point(74, 116);
            CompanyCityTxtBox.Name = "CompanyCityTxtBox";
            CompanyCityTxtBox.Size = new System.Drawing.Size(221, 23);
            CompanyCityTxtBox.TabIndex = 7;
            // 
            // CompanyCityLbl
            // 
            CompanyCityLbl.AutoSize = true;
            CompanyCityLbl.Location = new System.Drawing.Point(74, 98);
            CompanyCityLbl.Name = "CompanyCityLbl";
            CompanyCityLbl.Size = new System.Drawing.Size(28, 15);
            CompanyCityLbl.TabIndex = 6;
            CompanyCityLbl.Text = "City";
            // 
            // CompanyPostalTxtBox
            // 
            CompanyPostalTxtBox.Location = new System.Drawing.Point(3, 116);
            CompanyPostalTxtBox.Name = "CompanyPostalTxtBox";
            CompanyPostalTxtBox.Size = new System.Drawing.Size(68, 23);
            CompanyPostalTxtBox.TabIndex = 5;
            // 
            // CompanyPostalLbl
            // 
            CompanyPostalLbl.AutoSize = true;
            CompanyPostalLbl.Location = new System.Drawing.Point(3, 98);
            CompanyPostalLbl.Name = "CompanyPostalLbl";
            CompanyPostalLbl.Size = new System.Drawing.Size(65, 15);
            CompanyPostalLbl.TabIndex = 4;
            CompanyPostalLbl.Text = "Postalcode";
            // 
            // CompanyCountryTxtBox
            // 
            CompanyCountryTxtBox.Location = new System.Drawing.Point(3, 72);
            CompanyCountryTxtBox.Name = "CompanyCountryTxtBox";
            CompanyCountryTxtBox.Size = new System.Drawing.Size(292, 23);
            CompanyCountryTxtBox.TabIndex = 3;
            // 
            // CompanyCountryLbl
            // 
            CompanyCountryLbl.AutoSize = true;
            CompanyCountryLbl.Location = new System.Drawing.Point(3, 54);
            CompanyCountryLbl.Name = "CompanyCountryLbl";
            CompanyCountryLbl.Size = new System.Drawing.Size(50, 15);
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
            NewCompanyNameLbl.Location = new System.Drawing.Point(3, 10);
            NewCompanyNameLbl.Name = "NewCompanyNameLbl";
            NewCompanyNameLbl.Size = new System.Drawing.Size(94, 15);
            NewCompanyNameLbl.TabIndex = 0;
            NewCompanyNameLbl.Text = "Company Name";
            // 
            // CameraForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1520, 742);
            Controls.Add(NewCompanyPnl);
            Controls.Add(NewCompanyBtn);
            Controls.Add(Submit);
            Controls.Add(companyCheckedListBox);
            Controls.Add(interestsCheckedListBox);
            Controls.Add(textBoxHousenumber);
            Controls.Add(HousenumberLabel);
            Controls.Add(textBoxStreet);
            Controls.Add(StreetLabel);
            Controls.Add(textBoxPostcode);
            Controls.Add(ZipLabel);
            Controls.Add(textBoxCity);
            Controls.Add(CityLabel);
            Controls.Add(textBoxCountry);
            Controls.Add(CountryLabel);
            Controls.Add(textBoxName);
            Controls.Add(NameLabel);
            Controls.Add(PhotoButton);
            Controls.Add(StartCameraButton);
            Controls.Add(pictureBox1);
            Controls.Add(CameraLabel);
            Controls.Add(cboCamera);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "CameraForm";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            NewCompanyPnl.ResumeLayout(false);
            NewCompanyPnl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label CameraLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartCameraButton;
        private System.Windows.Forms.Button PhotoButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox textBoxCity;
        private System.Windows.Forms.Label ZipLabel;
        private System.Windows.Forms.TextBox textBoxPostcode;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label HousenumberLabel;
        private System.Windows.Forms.TextBox textBoxHousenumber;
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
    }
}

