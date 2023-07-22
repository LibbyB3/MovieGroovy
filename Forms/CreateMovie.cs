using AppLibrary.Models;
using AppLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class createMovieForm : Form
    {
        public createMovieForm()
        {
            InitializeComponent();
        }

        private void searchMovieLabel_Click(object sender, EventArgs e)
        {

        }

        private void createMovieButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (DateTime.TryParse(dateTextBox.Text, out DateTime releaseDate))
                {
                    int duration = int.Parse(durationTextBox.Text);

                    MoviesModel movie = new MoviesModel(titleTextBox.Text, releaseDate, duration);

                    GlobalConfig.Connection.CreateMovie(movie); //Global config is what will save the models back to the database
                    titleTextBox.Text = "";
                    dateTextBox.Text = "";
                    durationTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalid date format. Please enter a valid date (YYYY-MM-DD).");
                }
            }
            else
            {
                MessageBox.Show("This form has incorrect information, please look over and try again."); //popup to let user know there is an error
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            if (titleTextBox.Text.Length == 0) //this is validation to make sure that there is something in the email option
            {
                output = false;
            }
            if (dateTextBox.Text.Length == 0) //this and all validations following say that if there is no input in
            {                                   // the text box, then the validation fails
                output = false;
            }
            if (durationTextBox.Text.Length == 0) //same validation here
            {
                output = false;
            }

            return output;
        }
    }
}
