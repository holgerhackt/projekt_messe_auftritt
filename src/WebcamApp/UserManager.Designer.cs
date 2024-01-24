namespace WebcamApp
{
    partial class UserManager
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
            UserTabelle = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Forename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            AddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            PostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyAddressId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyPostalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CompanyHouseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)UserTabelle).BeginInit();
            SuspendLayout();
            // 
            // UserTabelle
            // 
            UserTabelle.AllowUserToAddRows = false;
            UserTabelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            UserTabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserTabelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Forename, Lastname, Email, Image, AddressId, Country, City, PostalCode, Street, HouseNumber, CompanyId, CompanyName, CompanyAddressId, CompanyCountry, CompanyCity, CompanyPostalCode, CompanyStreet, CompanyHouseNumber });
            UserTabelle.GridColor = System.Drawing.SystemColors.ButtonFace;
            UserTabelle.Location = new System.Drawing.Point(12, 28);
            UserTabelle.Name = "UserTabelle";
            UserTabelle.RowTemplate.Height = 25;
            UserTabelle.Size = new System.Drawing.Size(1602, 848);
            UserTabelle.TabIndex = 0;
            UserTabelle.CellValueChanged += UserTabelle_CellValueChanged;
            UserTabelle.UserDeletingRow += UserTabelle_UserDeletingRow;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            Id.Width = 42;
            // 
            // Forename
            // 
            Forename.DataPropertyName = "Forename";
            Forename.HeaderText = "Forename";
            Forename.Name = "Forename";
            Forename.Width = 85;
            // 
            // Lastname
            // 
            Lastname.DataPropertyName = "Lastname";
            Lastname.HeaderText = "Lastname";
            Lastname.Name = "Lastname";
            Lastname.Width = 83;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.Width = 61;
            // 
            // Image
            // 
            Image.DataPropertyName = "Image";
            Image.HeaderText = "Image";
            Image.Name = "Image";
            Image.ReadOnly = true;
            Image.Visible = false;
            Image.Width = 65;
            // 
            // AddressId
            // 
            AddressId.DataPropertyName = "AddressId";
            AddressId.HeaderText = "AddressId";
            AddressId.Name = "AddressId";
            AddressId.ReadOnly = true;
            AddressId.Visible = false;
            AddressId.Width = 84;
            // 
            // Country
            // 
            Country.DataPropertyName = "Country";
            Country.HeaderText = "Country";
            Country.Name = "Country";
            Country.Width = 75;
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.Name = "City";
            City.Width = 53;
            // 
            // PostalCode
            // 
            PostalCode.DataPropertyName = "PostalCode";
            PostalCode.HeaderText = "PostalCode";
            PostalCode.Name = "PostalCode";
            PostalCode.Width = 92;
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.HeaderText = "Street";
            Street.Name = "Street";
            Street.Width = 62;
            // 
            // HouseNumber
            // 
            HouseNumber.DataPropertyName = "HouseNumber";
            HouseNumber.HeaderText = "HouseNumber";
            HouseNumber.Name = "HouseNumber";
            HouseNumber.Width = 110;
            // 
            // CompanyId
            // 
            CompanyId.DataPropertyName = "CompanyId";
            CompanyId.HeaderText = "CompanyId";
            CompanyId.Name = "CompanyId";
            CompanyId.ReadOnly = true;
            CompanyId.Visible = false;
            CompanyId.Width = 94;
            // 
            // CompanyName
            // 
            CompanyName.DataPropertyName = "CompanyName";
            CompanyName.HeaderText = "CompanyName";
            CompanyName.Name = "CompanyName";
            CompanyName.Width = 116;
            // 
            // CompanyAddressId
            // 
            CompanyAddressId.DataPropertyName = "CompanyAddressId";
            CompanyAddressId.HeaderText = "CompanyAddressId";
            CompanyAddressId.Name = "CompanyAddressId";
            CompanyAddressId.ReadOnly = true;
            CompanyAddressId.Visible = false;
            CompanyAddressId.Width = 136;
            // 
            // CompanyCountry
            // 
            CompanyCountry.DataPropertyName = "CompanyCountry";
            CompanyCountry.HeaderText = "CompanyCountry";
            CompanyCountry.Name = "CompanyCountry";
            CompanyCountry.Width = 127;
            // 
            // CompanyCity
            // 
            CompanyCity.DataPropertyName = "CompanyCity";
            CompanyCity.HeaderText = "CompanyCity";
            CompanyCity.Name = "CompanyCity";
            CompanyCity.Width = 105;
            // 
            // CompanyPostalCode
            // 
            CompanyPostalCode.DataPropertyName = "CompanyPostalCode";
            CompanyPostalCode.HeaderText = "CompanyPostalCode";
            CompanyPostalCode.Name = "CompanyPostalCode";
            CompanyPostalCode.Width = 144;
            // 
            // CompanyStreet
            // 
            CompanyStreet.DataPropertyName = "CompanyStreet";
            CompanyStreet.HeaderText = "CompanyStreet";
            CompanyStreet.Name = "CompanyStreet";
            CompanyStreet.Width = 114;
            // 
            // CompanyHouseNumber
            // 
            CompanyHouseNumber.DataPropertyName = "CompanyHouseNumber";
            CompanyHouseNumber.HeaderText = "CompanyHouseNumber";
            CompanyHouseNumber.Name = "CompanyHouseNumber";
            CompanyHouseNumber.Width = 162;
            // 
            // UserManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1626, 906);
            Controls.Add(UserTabelle);
            Name = "UserManager";
            Text = "UserManager";
            ((System.ComponentModel.ISupportInitialize)UserTabelle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView UserTabelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Forename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Image;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Street;
        private System.Windows.Forms.DataGridViewTextBoxColumn HouseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyAddressId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyPostalCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyHouseNumber;
    }
}