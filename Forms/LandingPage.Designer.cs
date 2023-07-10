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
            this.LandPgCreateMVButton = new System.Windows.Forms.Button();
            this.LandPgSearchMVButton = new System.Windows.Forms.Button();
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
            // LandPgCreateMVButton
            // 
            this.LandPgCreateMVButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LandPgCreateMVButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LandPgCreateMVButton.ForeColor = System.Drawing.Color.White;
            this.LandPgCreateMVButton.Location = new System.Drawing.Point(103, 194);
            this.LandPgCreateMVButton.Name = "LandPgCreateMVButton";
            this.LandPgCreateMVButton.Size = new System.Drawing.Size(181, 98);
            this.LandPgCreateMVButton.TabIndex = 29;
            this.LandPgCreateMVButton.Text = "Create Movie";
            this.LandPgCreateMVButton.UseVisualStyleBackColor = false;
            this.LandPgCreateMVButton.Click += new System.EventHandler(this.LandPgCreateMVButton_Click);
            // 
            // LandPgSearchMVButton
            // 
            this.LandPgSearchMVButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LandPgSearchMVButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LandPgSearchMVButton.ForeColor = System.Drawing.Color.White;
            this.LandPgSearchMVButton.Location = new System.Drawing.Point(511, 194);
            this.LandPgSearchMVButton.Name = "LandPgSearchMVButton";
            this.LandPgSearchMVButton.Size = new System.Drawing.Size(178, 98);
            this.LandPgSearchMVButton.TabIndex = 30;
            this.LandPgSearchMVButton.Text = "Search Movie";
            this.LandPgSearchMVButton.UseVisualStyleBackColor = false;
            this.LandPgSearchMVButton.Click += new System.EventHandler(this.LandPgSearchMVButton_Click);
            // 
            // LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LandPgSearchMVButton);
            this.Controls.Add(this.LandPgCreateMVButton);
            this.Controls.Add(this.landPgTitleLab);
            this.Name = "LandingPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label landPgTitleLab;
        private Button LandPgCreateMVButton;
        private Button LandPgSearchMVButton;
    }
}