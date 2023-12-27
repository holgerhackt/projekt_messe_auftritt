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
            Login = new System.Windows.Forms.Button();
            UsernameTextBox = new System.Windows.Forms.TextBox();
            PasswordTextBox = new System.Windows.Forms.TextBox();
            UsernameLabel = new System.Windows.Forms.Label();
            PasswordLabel = new System.Windows.Forms.Label();
            StartApp = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Login.BackColor = System.Drawing.Color.Fuchsia;
            Login.Enabled = false;
            Login.Location = new System.Drawing.Point(291, 169);
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
            UsernameTextBox.Location = new System.Drawing.Point(118, 27);
            UsernameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new System.Drawing.Size(383, 23);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.TextChanged += TextBox_TextChanged;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            PasswordTextBox.Location = new System.Drawing.Point(118, 65);
            PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new System.Drawing.Size(383, 23);
            PasswordTextBox.TabIndex = 3;
            PasswordTextBox.UseSystemPasswordChar = true;
            PasswordTextBox.TextChanged += TextBox_TextChanged;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new System.Drawing.Point(28, 27);
            UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new System.Drawing.Size(60, 15);
            UsernameLabel.TabIndex = 4;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new System.Drawing.Point(28, 65);
            PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new System.Drawing.Size(57, 15);
            PasswordLabel.TabIndex = 5;
            PasswordLabel.Text = "Password";
            // 
            // StartApp
            // 
            StartApp.BackColor = System.Drawing.Color.SpringGreen;
            StartApp.Location = new System.Drawing.Point(67, 171);
            StartApp.Name = "StartApp";
            StartApp.Size = new System.Drawing.Size(90, 23);
            StartApp.TabIndex = 6;
            StartApp.Text = "Start App";
            StartApp.UseVisualStyleBackColor = false;
            StartApp.Click += StartApp_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(515, 211);
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
    }
}