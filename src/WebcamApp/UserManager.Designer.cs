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
            ((System.ComponentModel.ISupportInitialize)UserTabelle).BeginInit();
            SuspendLayout();
            // 
            // UserTabelle
            // 
            UserTabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UserTabelle.Location = new System.Drawing.Point(12, 28);
            UserTabelle.Name = "UserTabelle";
            UserTabelle.RowTemplate.Height = 25;
            UserTabelle.Size = new System.Drawing.Size(756, 410);
            UserTabelle.TabIndex = 0;
            UserTabelle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(UserTabelle_CellValueChanged);
            UserTabelle.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(UserTabelle_UserDeletingRow);
            // 
            // UserManager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(UserTabelle);
            Name = "UserManager";
            Text = "UserManager";
            ((System.ComponentModel.ISupportInitialize)UserTabelle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView UserTabelle;
    }
}