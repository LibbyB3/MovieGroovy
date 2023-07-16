using AppLibrary;
using AppLibrary.Models;

namespace Forms
{
    public partial class createUserForm : Form
    {
        public createUserForm()
        {
            InitializeComponent();
        }
        private void createUserButton_Click(object sender, EventArgs e) //the following code inside the brackets happens whenever the 
        {                                                               //create user button is clicked
            if (ValidateForm())
            {
                UsersModel user = new UsersModel(usernameTextBox.Text, emailTextBox.Text, passwordTextBox.Text);
                
                GlobalConfig.Connection.CreateUser(user); //Global config is what will save the models back to the database
                usernameTextBox.Text = "";
                emailTextBox.Text = "";
                passwordTextBox.Text = "";
            }
            else 
            {
                MessageBox.Show("This form has incorrect information, please look over and try again."); //popup to let user know there is an error
            } 

        }
        private bool ValidateForm()
        {
            bool output = true; 
            if(emailTextBox.Text.Length == 0) //this is validation to make sure that there is something in the email option
            {
                output = false;
            }
            if(usernameTextBox.Text.Length == 0) //this and all validations following say that if there is no input in
            {                                   // the text box, then the validation fails
                output = false;
            }
            if(passwordTextBox.Text.Length == 0) //same validation here
            {
                output = false;
            }

            return output;
        }
    }
}