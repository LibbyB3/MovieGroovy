namespace Forms
{
    partial class createMovForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.searchMovieLabel = new System.Windows.Forms.Label();
            this.titleLab = new System.Windows.Forms.Label();
            this.createMovieLab = new System.Windows.Forms.Label();
            this.yearLab = new System.Windows.Forms.Label();
            this.primDirectLab = new System.Windows.Forms.Label();
            this.genreLab = new System.Windows.Forms.Label();
            this.synopsisLab = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.primDirectTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.synopsisTextBox = new System.Windows.Forms.TextBox();
            this.createMVButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchMovieLabel
            // 
            this.searchMovieLabel.Location = new System.Drawing.Point(0, 0);
            this.searchMovieLabel.Name = "searchMovieLabel";
            this.searchMovieLabel.Size = new System.Drawing.Size(100, 23);
            this.searchMovieLabel.TabIndex = 18;
            // 
            // titleLab
            // 
            this.titleLab.AutoSize = true;
            this.titleLab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLab.ForeColor = System.Drawing.Color.Crimson;
            this.titleLab.Location = new System.Drawing.Point(39, 71);
            this.titleLab.Name = "titleLab";
            this.titleLab.Size = new System.Drawing.Size(61, 32);
            this.titleLab.TabIndex = 16;
            this.titleLab.Text = "Title";
            // 
            // createMovieLab
            // 
            this.createMovieLab.AutoSize = true;
            this.createMovieLab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMovieLab.ForeColor = System.Drawing.Color.Crimson;
            this.createMovieLab.Location = new System.Drawing.Point(230, 9);
            this.createMovieLab.Name = "createMovieLab";
            this.createMovieLab.Size = new System.Drawing.Size(160, 32);
            this.createMovieLab.TabIndex = 17;
            this.createMovieLab.Text = "Create Movie";
            // 
            // yearLab
            // 
            this.yearLab.AutoSize = true;
            this.yearLab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yearLab.ForeColor = System.Drawing.Color.Crimson;
            this.yearLab.Location = new System.Drawing.Point(39, 134);
            this.yearLab.Name = "yearLab";
            this.yearLab.Size = new System.Drawing.Size(150, 32);
            this.yearLab.TabIndex = 19;
            this.yearLab.Text = "Release Year";
            // 
            // primDirectLab
            // 
            this.primDirectLab.AutoSize = true;
            this.primDirectLab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.primDirectLab.ForeColor = System.Drawing.Color.Crimson;
            this.primDirectLab.Location = new System.Drawing.Point(39, 204);
            this.primDirectLab.Name = "primDirectLab";
            this.primDirectLab.Size = new System.Drawing.Size(194, 32);
            this.primDirectLab.TabIndex = 20;
            this.primDirectLab.Text = "Primary Director";
            // 
            // genreLab
            // 
            this.genreLab.AutoSize = true;
            this.genreLab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.genreLab.ForeColor = System.Drawing.Color.Crimson;
            this.genreLab.Location = new System.Drawing.Point(39, 275);
            this.genreLab.Name = "genreLab";
            this.genreLab.Size = new System.Drawing.Size(80, 32);
            this.genreLab.TabIndex = 21;
            this.genreLab.Text = "Genre";
            // 
            // synopsisLab
            // 
            this.synopsisLab.AutoSize = true;
            this.synopsisLab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.synopsisLab.ForeColor = System.Drawing.Color.Crimson;
            this.synopsisLab.Location = new System.Drawing.Point(39, 342);
            this.synopsisLab.Name = "synopsisLab";
            this.synopsisLab.Size = new System.Drawing.Size(106, 32);
            this.synopsisLab.TabIndex = 22;
            this.synopsisLab.Text = "Synopsis";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.titleTextBox.Location = new System.Drawing.Point(315, 71);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(269, 31);
            this.titleTextBox.TabIndex = 23;
            // 
            // yearTextBox
            // 
            this.yearTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.yearTextBox.Location = new System.Drawing.Point(315, 134);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(269, 31);
            this.yearTextBox.TabIndex = 24;
            // 
            // primDirectTextBox
            // 
            this.primDirectTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.primDirectTextBox.Location = new System.Drawing.Point(315, 205);
            this.primDirectTextBox.Name = "primDirectTextBox";
            this.primDirectTextBox.Size = new System.Drawing.Size(269, 31);
            this.primDirectTextBox.TabIndex = 25;
            // 
            // genreTextBox
            // 
            this.genreTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.genreTextBox.Location = new System.Drawing.Point(315, 274);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(269, 31);
            this.genreTextBox.TabIndex = 26;
            // 
            // synopsisTextBox
            // 
            this.synopsisTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.synopsisTextBox.Location = new System.Drawing.Point(315, 342);
            this.synopsisTextBox.Name = "synopsisTextBox";
            this.synopsisTextBox.Size = new System.Drawing.Size(269, 31);
            this.synopsisTextBox.TabIndex = 27;
            // 
            // createMVButton
            // 
            this.createMVButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createMVButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createMVButton.ForeColor = System.Drawing.Color.White;
            this.createMVButton.Location = new System.Drawing.Point(259, 389);
            this.createMVButton.Name = "createMVButton";
            this.createMVButton.Size = new System.Drawing.Size(112, 62);
            this.createMVButton.TabIndex = 28;
            this.createMVButton.Text = "Create";
            this.createMVButton.UseVisualStyleBackColor = false;
            this.createMVButton.Click += new System.EventHandler(this.createMVButton_Click);
            // 
            // createMovForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(630, 474);
            this.Controls.Add(this.createMVButton);
            this.Controls.Add(this.synopsisTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.primDirectTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.synopsisLab);
            this.Controls.Add(this.genreLab);
            this.Controls.Add(this.primDirectLab);
            this.Controls.Add(this.yearLab);
            this.Controls.Add(this.createMovieLab);
            this.Controls.Add(this.titleLab);
            this.Controls.Add(this.searchMovieLabel);
            this.Name = "createMovForm";
            this.Text = "Create Movie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label searchMovieLabel;
        private Label titleLab;
        private Label createMovieLab;
        private Label yearLab;
        private Label primDirectLab;
        private Label genreLab;
        private Label synopsisLab;
        private TextBox titleTextBox;
        private TextBox yearTextBox;
        private TextBox primDirectTextBox;
        private TextBox genreTextBox;
        private TextBox synopsisTextBox;
        private Button createMVButton;
    }
}