namespace Forms
{
    partial class createMovieForm
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
            this.createMoviesLabel = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.createMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createMoviesLabel
            // 
            this.createMoviesLabel.AutoSize = true;
            this.createMoviesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMoviesLabel.ForeColor = System.Drawing.Color.Crimson;
            this.createMoviesLabel.Location = new System.Drawing.Point(242, 20);
            this.createMoviesLabel.Name = "createMoviesLabel";
            this.createMoviesLabel.Size = new System.Drawing.Size(170, 32);
            this.createMoviesLabel.TabIndex = 15;
            this.createMoviesLabel.Text = "Create Movies";
            this.createMoviesLabel.Click += new System.EventHandler(this.searchMovieLabel_Click);
            // 
            // durationTextBox
            // 
            this.durationTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.durationTextBox.Location = new System.Drawing.Point(196, 241);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(407, 31);
            this.durationTextBox.TabIndex = 25;
            this.durationTextBox.Text = "Enter Length of Time in Minutes (ex. 90)";
            // 
            // dateTextBox
            // 
            this.dateTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.dateTextBox.Location = new System.Drawing.Point(196, 174);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(407, 31);
            this.dateTextBox.TabIndex = 26;
            this.dateTextBox.Text = "Enter Date in YYYY-MM-DD";
            // 
            // titleTextBox
            // 
            this.titleTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.titleTextBox.Location = new System.Drawing.Point(196, 107);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(407, 31);
            this.titleTextBox.TabIndex = 27;
            this.titleTextBox.Text = "Enter Movie Title";
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.durationLabel.ForeColor = System.Drawing.Color.Crimson;
            this.durationLabel.Location = new System.Drawing.Point(23, 241);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(110, 32);
            this.durationLabel.TabIndex = 28;
            this.durationLabel.Text = "Duration";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateLabel.ForeColor = System.Drawing.Color.Crimson;
            this.dateLabel.Location = new System.Drawing.Point(23, 174);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(155, 32);
            this.dateLabel.TabIndex = 29;
            this.dateLabel.Text = "Release Date";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titleLabel.ForeColor = System.Drawing.Color.Crimson;
            this.titleLabel.Location = new System.Drawing.Point(23, 107);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(61, 32);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.Text = "Title";
            // 
            // createMovieButton
            // 
            this.createMovieButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.createMovieButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.createMovieButton.ForeColor = System.Drawing.Color.White;
            this.createMovieButton.Location = new System.Drawing.Point(262, 327);
            this.createMovieButton.Name = "createMovieButton";
            this.createMovieButton.Size = new System.Drawing.Size(112, 62);
            this.createMovieButton.TabIndex = 31;
            this.createMovieButton.Text = "Create";
            this.createMovieButton.UseVisualStyleBackColor = false;
            this.createMovieButton.Click += new System.EventHandler(this.createMovieButton_Click);
            // 
            // createMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(673, 450);
            this.Controls.Add(this.createMovieButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.createMoviesLabel);
            this.Name = "createMovieForm";
            this.Text = "CreateMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label createMoviesLabel;
        private TextBox durationTextBox;
        private TextBox dateTextBox;
        private TextBox titleTextBox;
        private Label durationLabel;
        private Label dateLabel;
        private Label titleLabel;
        private Button createMovieButton;
    }
}