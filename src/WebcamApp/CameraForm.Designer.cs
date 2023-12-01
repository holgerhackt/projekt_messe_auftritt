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
			textBoxAPIStatus = new System.Windows.Forms.TextBox();
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
			label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// cboCamera
			// 
			cboCamera.FormattingEnabled = true;
			cboCamera.Location = new System.Drawing.Point(110, 35);
			cboCamera.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			cboCamera.Name = "cboCamera";
			cboCamera.Size = new System.Drawing.Size(445, 23);
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
			pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
			pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			pictureBox1.Location = new System.Drawing.Point(46, 75);
			pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new System.Drawing.Size(779, 617);
			pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
			pictureBox1.TabIndex = 2;
			pictureBox1.TabStop = false;
			// 
			// StartCameraButton
			// 
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
			PhotoButton.Location = new System.Drawing.Point(737, 35);
			PhotoButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			PhotoButton.Name = "PhotoButton";
			PhotoButton.Size = new System.Drawing.Size(88, 27);
			PhotoButton.TabIndex = 4;
			PhotoButton.Text = "Photo";
			PhotoButton.UseVisualStyleBackColor = true;
			PhotoButton.Click += PhotoButton_Click;
			// 
			// textBoxAPIStatus
			// 
			textBoxAPIStatus.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			textBoxAPIStatus.Location = new System.Drawing.Point(855, 669);
			textBoxAPIStatus.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			textBoxAPIStatus.Name = "textBoxAPIStatus";
			textBoxAPIStatus.Size = new System.Drawing.Size(650, 23);
			textBoxAPIStatus.TabIndex = 5;
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
			// label8
			// 
			label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(852, 651);
			label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(60, 15);
			label8.TabIndex = 18;
			label8.Text = "Api Status";
			// 
			// CameraForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(1520, 742);
			Controls.Add(label8);
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
			Controls.Add(textBoxAPIStatus);
			Controls.Add(PhotoButton);
			Controls.Add(StartCameraButton);
			Controls.Add(pictureBox1);
			Controls.Add(CameraLabel);
			Controls.Add(cboCamera);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "CameraForm";
			Text = "Form1";
			FormClosing += Form1_FormClosing;
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label CameraLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button StartCameraButton;
        private System.Windows.Forms.Button PhotoButton;
        private System.Windows.Forms.TextBox textBoxAPIStatus;
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
        private System.Windows.Forms.Label label8;
    }
}

