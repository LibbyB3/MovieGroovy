using AppLibrary;
using MovieAppCSC660.Models;

namespace Forms
{
    public partial class createUserForm : Form
    {
        public createUserForm()
        {
            InitializeComponent();
        }
        private void createUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                TitleModel model = new TitleModel(
                    usernameTextBox.Text);  //TODO - redo the constructors on each model and match them 
                PrimaryDirectorModel modelPD = new PrimaryDirectorModel(
                    passwordTextBox.Text);
                GenreModel modelG = new GenreModel
                    (genreTextBox.Text);
                SynopsisModel modelS = new SynopsisModel
                    (synopsisTextBox.Text);
                ReleaseYearModel modelY = new ReleaseYearModel(emailTextBox.Text);
                //I have to create separate things here bc I have multiple models w/info on this form

                //also have to make multiple connections here for the multiple models
                //globalconfig saves the models back to the DB
                GlobalConfig.Connection.CreateTitle(model); //have to have multiples models here
                usernameTextBox.Text = "";

                GlobalConfig.Connection.CreateYear(modelY);
                emailTextBox.Text = "0";

                GlobalConfig.Connection.CreatePrimaryDirector(modelPD);
                passwordTextBox.Text = "";
                //use split code to put last name in here as well

                GlobalConfig.Connection.CreateGenre(modelG);
                genreTextBox.Text = "";

                GlobalConfig.Connection.CreateSynopsis(modelS);
                synopsisTextBox.Text = "";
                //creating the connection to the database within this form
            }
            else 
            {
                MessageBox.Show("This form has incorrect information, please look over and try again.");
            } //this pops up a window to show the user that something is not correct

        }
        private bool ValidateForm()
        {
            // TODO - figure out what the heck I need to write here for the tryparse (spot 39:09 in video)
            bool output = true; 
            if(int.TryParse(emailTextBox.Text, out int year)== false) //converting from string to int
            {
                output = false;
            }
            if(year < 1) //making sure the year is not less than 1 //DO I REALLY NEED THIS?
            { 
                output = false; 
            }
            if(usernameTextBox.Text.Length == 0) //this and all validations following say that if there is no input in
            {                                  // the text box, then the validation fails
                output = false;
            }
            if(passwordTextBox.Text.Length == 0)
            {
                output = false;
            }
            if(genreTextBox.Text.Length == 0)
            {
                output=false;    //do not need to do a validation for Synopsis text box bc it is not a mandatory DB input
            }

            return output;
        }
    }
}

//bool yearValidate = int.TryParse(yearTextBox.Text, out int year);
//if (yearValidate)
//{
//   ReleaseYearModel modelY = new ReleaseYearModel(
//   year);
//}
//else //TODO - firgure out the freakin year problem
//{
//    MessageBox.Show("please enter a valid year.");
//}
//int.Parse(yearTextBox.Text);
//ReleaseYearModel modelY = new ReleaseYearModel(year);
//possibly need to change it from textbox?