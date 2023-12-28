namespace WebcamApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Login = new System.Windows.Forms.Button();
            UsernameTextBox = new System.Windows.Forms.TextBox();
            PasswordTextBox = new System.Windows.Forms.TextBox();
            UsernameLabel = new System.Windows.Forms.Label();
            PasswordLabel = new System.Windows.Forms.Label();
            StartApp = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Login.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            Login.Enabled = false;
            Login.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Login.ForeColor = System.Drawing.Color.White;
            Login.Image = (System.Drawing.Image)resources.GetObject("Login.Image");
            Login.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            Login.Location = new System.Drawing.Point(243, 145);
            Login.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Login.Name = "Login";
            Login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Login.Size = new System.Drawing.Size(162, 27);
            Login.TabIndex = 0;
            Login.Text = "Login and Sync";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            UsernameTextBox.ForeColor = System.Drawing.Color.White;
            UsernameTextBox.Location = new System.Drawing.Point(243, 65);
            UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new System.Drawing.Size(262, 23);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += TextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PasswordTextBox.ForeColor = System.Drawing.Color.White;
            PasswordTextBox.Location = new System.Drawing.Point(243, 103);
            PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new System.Drawing.Size(262, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += TextBox_TextChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.ForeColor = System.Drawing.Color.White;
            UsernameLabel.Location = new System.Drawing.Point(175, 67);
            UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(60, 15);
            UsernameLabel.TabIndex = 4;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.ForeColor = System.Drawing.Color.White;
            PasswordLabel.Location = new System.Drawing.Point(178, 105);
            PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new System.Drawing.Size(57, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // StartApp
            // 
            StartApp.BackColor = System.Drawing.Color.FromArgb(61, 61, 61);
            StartApp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(90, 90, 90);
            StartApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StartApp.ForeColor = System.Drawing.Color.White;
            StartApp.Image = (System.Drawing.Image)resources.GetObject("StartApp.Image");
            StartApp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            StartApp.Location = new System.Drawing.Point(28, 79);
            StartApp.Name = "StartApp";
            StartApp.Size = new System.Drawing.Size(90, 28);
            StartApp.TabIndex = 6;
            StartApp.Text = "Start App";
            StartApp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            StartApp.UseVisualStyleBackColor = false;
            StartApp.Click += StartApp_Click;
            // 
            // label1
            // 
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.Location = new System.Drawing.Point(141, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(2, 193);
            label1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            ClientSize = new System.Drawing.Size(515, 211);
            Controls.Add(label1);
            Controls.Add(StartApp);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(Login);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button StartApp;
        private System.Windows.Forms.Label label1;
    }
}