namespace Forms
{
    partial class SearchMovieForm
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
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.titleCB = new System.Windows.Forms.ComboBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.directorCB = new System.Windows.Forms.ComboBox();
            this.genreCB = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchMovieLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(80, 105);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 32);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Title";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // titleCB
            // 
            this.titleCB.BackColor = System.Drawing.Color.Goldenrod;
            this.titleCB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titleCB.ForeColor = System.Drawing.Color.Black;
            this.titleCB.FormattingEnabled = true;
            this.titleCB.Location = new System.Drawing.Point(272, 104);
            this.titleCB.Name = "titleCB";
            this.titleCB.Size = new System.Drawing.Size(182, 33);
            this.titleCB.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearLabel.ForeColor = System.Drawing.Color.Crimson;
            this.yearLabel.Location = new System.Drawing.Point(36, 176);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(150, 32);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Release Year";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genreLabel.ForeColor = System.Drawing.Color.Crimson;
            this.genreLabel.Location = new System.Drawing.Point(74, 317);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(80, 32);
            this.genreLabel.TabIndex = 8;
            this.genreLabel.Text = "Genre";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.directorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.directorLabel.Location = new System.Drawing.Point(12, 246);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(194, 32);
            this.directorLabel.TabIndex = 9;
            this.directorLabel.Text = "Primary Director";
            // 
            // yearCB
            // 
            this.yearCB.BackColor = System.Drawing.Color.Goldenrod;
            this.yearCB.ForeColor = System.Drawing.Color.White;
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Location = new System.Drawing.Point(272, 176);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(182, 33);
            this.yearCB.TabIndex = 10;
            // 
            // directorCB
            // 
            this.directorCB.BackColor = System.Drawing.Color.Goldenrod;
            this.directorCB.ForeColor = System.Drawing.Color.White;
            this.directorCB.FormattingEnabled = true;
            this.directorCB.Location = new System.Drawing.Point(272, 246);
            this.directorCB.Name = "directorCB";
            this.directorCB.Size = new System.Drawing.Size(182, 33);
            this.directorCB.TabIndex = 11;
            // 
            // genreCB
            // 
            this.genreCB.BackColor = System.Drawing.Color.Goldenrod;
            this.genreCB.ForeColor = System.Drawing.Color.White;
            this.genreCB.FormattingEnabled = true;
            this.genreCB.Location = new System.Drawing.Point(272, 317);
            this.genreCB.Name = "genreCB";
            this.genreCB.Size = new System.Drawing.Size(182, 33);
            this.genreCB.TabIndex = 12;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(170, 365);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 62);
            this.searchButton.TabIndex = 13;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // searchMovieLabel
            // 
            this.searchMovieLabel.AutoSize = true;
            this.searchMovieLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchMovieLabel.ForeColor = System.Drawing.Color.Crimson;
            this.searchMovieLabel.Location = new System.Drawing.Point(137, 26);
            this.searchMovieLabel.Name = "searchMovieLabel";
            this.searchMovieLabel.Size = new System.Drawing.Size(171, 32);
            this.searchMovieLabel.TabIndex = 14;
            this.searchMovieLabel.Text = "Search Movies";
            // 
            // SearchMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.searchMovieLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.genreCB);
            this.Controls.Add(this.directorCB);
            this.Controls.Add(this.yearCB);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.titleCB);
            this.Controls.Add(this.titleLabel);
            this.Name = "SearchMovieForm";
            this.Text = "Search Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label titleLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox titleCB;
        private Label yearLabel;
        private Label genreLabel;
        private Label directorLabel;
        private ComboBox yearCB;
        private ComboBox directorCB;
        private ComboBox genreCB;
        private Button searchButton;
        private Label searchMovieLabel;
    }
}