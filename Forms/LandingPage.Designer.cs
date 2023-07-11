namespace Forms
{
    partial class LandingPage
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
            this.landPgTitleLab = new System.Windows.Forms.Label();
            this.LandPgCreateUserButton = new System.Windows.Forms.Button();
            this.LandPgLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // landPgTitleLab
            // 
            this.landPgTitleLab.AutoSize = true;
            this.landPgTitleLab.Font = new System.Drawing.Font("Broadway", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.landPgTitleLab.ForeColor = System.Drawing.Color.Crimson;
            this.landPgTitleLab.Location = new System.Drawing.Point(218, 39);
            this.landPgTitleLab.Name = "landPgTitleLab";
            this.landPgTitleLab.Size = new System.Drawing.Size(365, 46);
            this.landPgTitleLab.TabIndex = 0;
            this.landPgTitleLab.Text = "MOVIE GROOVY";
            // 
            // LandPgCreateUserButton
            // 
            this.LandPgCreateUserButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LandPgCreateUserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LandPgCreateUserButton.ForeColor = System.Drawing.Color.White;
            this.LandPgCreateUserButton.Location = new System.Drawing.Point(103, 194);
            this.LandPgCreateUserButton.Name = "LandPgCreateUserButton";
            this.LandPgCreateUserButton.Size = new System.Drawing.Size(181, 98);
            this.LandPgCreateUserButton.TabIndex = 29;
            this.LandPgCreateUserButton.Text = "Create User";
            this.LandPgCreateUserButton.UseVisualStyleBackColor = false;
            this.LandPgCreateUserButton.Click += new System.EventHandler(this.LandPgCreateMVButton_Click);
            // 
            // LandPgLoginButton
            // 
            this.LandPgLoginButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LandPgLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LandPgLoginButton.ForeColor = System.Drawing.Color.White;
            this.LandPgLoginButton.Location = new System.Drawing.Point(511, 194);
            this.LandPgLoginButton.Name = "LandPgLoginButton";
            this.LandPgLoginButton.Size = new System.Drawing.Size(178, 98);
            this.LandPgLoginButton.TabIndex = 30;
            this.LandPgLoginButton.Text = "Login";
            this.LandPgLoginButton.UseVisualStyleBackColor = false;
            this.LandPgLoginButton.Click += new System.EventHandler(this.LandPgSearchMVButton_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LandPgLoginButton);
            this.Controls.Add(this.LandPgCreateUserButton);
            this.Controls.Add(this.landPgTitleLab);
            this.Name = "LandingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label landPgTitleLab;
        private Button LandPgCreateUserButton;
        private Button LandPgLoginButton;
    }
}