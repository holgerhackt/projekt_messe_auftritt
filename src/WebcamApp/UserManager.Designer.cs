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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            UserTabelle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            UserTabelle.BackgroundColor = System.Drawing.Color.FromArgb(24, 24, 24);
            UserTabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserTabelle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, Forename, Lastname, Email, Image, AddressId, Country, City, PostalCode, Street, HouseNumber, CompanyId, CompanyName, CompanyAddressId, CompanyCountry, CompanyCity, CompanyPostalCode, CompanyStreet, CompanyHouseNumber });
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            UserTabelle.DefaultCellStyle = dataGridViewCellStyle1;
            UserTabelle.GridColor = System.Drawing.SystemColors.ControlText;
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
            // 
            // Forename
            // 
            Forename.DataPropertyName = "Forename";
            Forename.HeaderText = "Forename";
            Forename.Name = "Forename";
            // 
            // Lastname
            // 
            Lastname.DataPropertyName = "Lastname";
            Lastname.HeaderText = "Lastname";
            Lastname.Name = "Lastname";
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Image
            // 
            Image.DataPropertyName = "Image";
            Image.HeaderText = "Image";
            Image.Name = "Image";
            Image.ReadOnly = true;
            Image.Visible = false;
            // 
            // AddressId
            // 
            AddressId.DataPropertyName = "AddressId";
            AddressId.HeaderText = "AddressId";
            AddressId.Name = "AddressId";
            AddressId.ReadOnly = true;
            AddressId.Visible = false;
            // 
            // Country
            // 
            Country.DataPropertyName = "Country";
            Country.HeaderText = "Country";
            Country.Name = "Country";
            // 
            // City
            // 
            City.DataPropertyName = "City";
            City.HeaderText = "City";
            City.Name = "City";
            // 
            // PostalCode
            // 
            PostalCode.DataPropertyName = "PostalCode";
            PostalCode.HeaderText = "PostalCode";
            PostalCode.Name = "PostalCode";
            // 
            // Street
            // 
            Street.DataPropertyName = "Street";
            Street.HeaderText = "Street";
            Street.Name = "Street";
            // 
            // HouseNumber
            // 
            HouseNumber.DataPropertyName = "HouseNumber";
            HouseNumber.HeaderText = "HouseNumber";
            HouseNumber.Name = "HouseNumber";
            // 
            // CompanyId
            // 
            CompanyId.DataPropertyName = "CompanyId";
            CompanyId.HeaderText = "CompanyId";
            CompanyId.Name = "CompanyId";
            CompanyId.ReadOnly = true;
            CompanyId.Visible = false;
            // 
            // CompanyName
            // 
            CompanyName.DataPropertyName = "CompanyName";
            CompanyName.HeaderText = "CompanyName";
            CompanyName.Name = "CompanyName";
            // 
            // CompanyAddressId
            // 
            CompanyAddressId.DataPropertyName = "CompanyAddressId";
            CompanyAddressId.HeaderText = "CompanyAddressId";
            CompanyAddressId.Name = "CompanyAddressId";
            CompanyAddressId.ReadOnly = true;
            CompanyAddressId.Visible = false;
            // 
            // CompanyCountry
            // 
            CompanyCountry.DataPropertyName = "CompanyCountry";
            CompanyCountry.HeaderText = "CompanyCountry";
            CompanyCountry.Name = "CompanyCountry";
            // 
            // CompanyCity
            // 
            CompanyCity.DataPropertyName = "CompanyCity";
            CompanyCity.HeaderText = "CompanyCity";
            CompanyCity.Name = "CompanyCity";
            // 
            // CompanyPostalCode
            // 
            CompanyPostalCode.DataPropertyName = "CompanyPostalCode";
            CompanyPostalCode.HeaderText = "CompanyPostalCode";
            CompanyPostalCode.Name = "CompanyPostalCode";
            // 
            // CompanyStreet
            // 
            CompanyStreet.DataPropertyName = "CompanyStreet";
            CompanyStreet.HeaderText = "CompanyStreet";
            CompanyStreet.Name = "CompanyStreet";
            // 
            // CompanyHouseNumber
            // 
            CompanyHouseNumber.DataPropertyName = "CompanyHouseNumber";
            CompanyHouseNumber.HeaderText = "CompanyHouseNumber";
            CompanyHouseNumber.Name = "CompanyHouseNumber";
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