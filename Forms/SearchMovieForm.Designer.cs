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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.searchMovieLabel = new System.Windows.Forms.Label();
            this.searchMoviesTextBox = new System.Windows.Forms.TextBox();
            this.searchMoviesButton = new System.Windows.Forms.Button();
            this.moviesDataGridView = new System.Windows.Forms.DataGridView();
            this.totalMoviesLabel = new System.Windows.Forms.Label();
            this.allMoviesButton = new System.Windows.Forms.Button();
            this.newMovieButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // searchMovieLabel
            // 
            this.searchMovieLabel.AutoSize = true;
            this.searchMovieLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchMovieLabel.ForeColor = System.Drawing.Color.Crimson;
            this.searchMovieLabel.Location = new System.Drawing.Point(256, 9);
            this.searchMovieLabel.Name = "searchMovieLabel";
            this.searchMovieLabel.Size = new System.Drawing.Size(171, 32);
            this.searchMovieLabel.TabIndex = 14;
            this.searchMovieLabel.Text = "Search Movies";
            // 
            // searchMoviesTextBox
            // 
            this.searchMoviesTextBox.BackColor = System.Drawing.Color.Goldenrod;
            this.searchMoviesTextBox.Location = new System.Drawing.Point(50, 59);
            this.searchMoviesTextBox.Name = "searchMoviesTextBox";
            this.searchMoviesTextBox.Size = new System.Drawing.Size(407, 31);
            this.searchMoviesTextBox.TabIndex = 24;
            this.searchMoviesTextBox.Text = "Enter Movie Title or ID";
            this.searchMoviesTextBox.TextChanged += new System.EventHandler(this.searchMoviesTextBox_TextChanged);
            this.searchMoviesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchMoviesTextBox_KeyPress);
            // 
            // searchMoviesButton
            // 
            this.searchMoviesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.searchMoviesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.searchMoviesButton.ForeColor = System.Drawing.Color.White;
            this.searchMoviesButton.Location = new System.Drawing.Point(484, 59);
            this.searchMoviesButton.Name = "searchMoviesButton";
            this.searchMoviesButton.Size = new System.Drawing.Size(112, 37);
            this.searchMoviesButton.TabIndex = 29;
            this.searchMoviesButton.Text = "Search";
            this.searchMoviesButton.UseVisualStyleBackColor = false;
            this.searchMoviesButton.Click += new System.EventHandler(this.searchMoviesButton_Click);
            // 
            // moviesDataGridView
            // 
            this.moviesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.moviesDataGridView.Location = new System.Drawing.Point(50, 145);
            this.moviesDataGridView.Name = "moviesDataGridView";
            this.moviesDataGridView.RowHeadersWidth = 62;
            this.moviesDataGridView.RowTemplate.Height = 33;
            this.moviesDataGridView.Size = new System.Drawing.Size(582, 325);
            this.moviesDataGridView.TabIndex = 30;
            // 
            // totalMoviesLabel
            // 
            this.totalMoviesLabel.AutoSize = true;
            this.totalMoviesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.totalMoviesLabel.ForeColor = System.Drawing.Color.Crimson;
            this.totalMoviesLabel.Location = new System.Drawing.Point(50, 494);
            this.totalMoviesLabel.Name = "totalMoviesLabel";
            this.totalMoviesLabel.Size = new System.Drawing.Size(164, 32);
            this.totalMoviesLabel.TabIndex = 31;
            this.totalMoviesLabel.Text = "Total Movies: ";
            // 
            // allMoviesButton
            // 
            this.allMoviesButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.allMoviesButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.allMoviesButton.ForeColor = System.Drawing.Color.White;
            this.allMoviesButton.Location = new System.Drawing.Point(484, 102);
            this.allMoviesButton.Name = "allMoviesButton";
            this.allMoviesButton.Size = new System.Drawing.Size(112, 37);
            this.allMoviesButton.TabIndex = 32;
            this.allMoviesButton.Text = "All Movies";
            this.allMoviesButton.UseVisualStyleBackColor = false;
            this.allMoviesButton.Click += new System.EventHandler(this.allMoviesButton_Click);
            // 
            // newMovieButton
            // 
            this.newMovieButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.newMovieButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.newMovieButton.ForeColor = System.Drawing.Color.White;
            this.newMovieButton.Location = new System.Drawing.Point(484, 489);
            this.newMovieButton.Name = "newMovieButton";
            this.newMovieButton.Size = new System.Drawing.Size(112, 37);
            this.newMovieButton.TabIndex = 33;
            this.newMovieButton.Text = "New Movie";
            this.newMovieButton.UseVisualStyleBackColor = false;
            this.newMovieButton.Click += new System.EventHandler(this.newMovieButton_Click);
            // 
            // SearchMovieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(671, 549);
            this.Controls.Add(this.newMovieButton);
            this.Controls.Add(this.allMoviesButton);
            this.Controls.Add(this.totalMoviesLabel);
            this.Controls.Add(this.moviesDataGridView);
            this.Controls.Add(this.searchMoviesButton);
            this.Controls.Add(this.searchMoviesTextBox);
            this.Controls.Add(this.searchMovieLabel);
            this.Name = "SearchMovieForm";
            this.Text = "Search Movie";
            ((System.ComponentModel.ISupportInitialize)(this.moviesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private Label searchMovieLabel;
        private TextBox searchMoviesTextBox;
        private Button searchMoviesButton;
        private DataGridView moviesDataGridView;
        private Label totalMoviesLabel;
        private Button allMoviesButton;
        private Button newMovieButton;
    }
}