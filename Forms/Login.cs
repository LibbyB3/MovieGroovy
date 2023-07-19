using AppLibrary.Models;
using AppLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //UsersModel user = new UsersModel(usernameTextBox.Text, passwordTextBox.Text);
                string username = usernameTextBox.Text; //= "";
                string password = passwordTextBox.Text; //= "";

                //SqlConnection con = new SqlConnection("Server=BOOK-T9BLIKLMOS\\CSCDATABASE;Database=Movie_Groovy_625;Trusted_Connection=True;");
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Count(*) From Users where Username=@Username AND Password=@Password", con);
                //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select Count(*) From Login where Username='" + usernameTextBox.Text + "' and Password='" + passwordTextBox.Text + "'");
                SearchMovieForm frm = new SearchMovieForm();
                frm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("This form has incorrect information, please look over and try again."); //popup to let user know there is an error
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
            if (usernameTextBox.Text.Length == 0) //this and all validations following say that if there is no input in
            {                                   // the text box, then the validation fails
                output = false;
            }
            if (passwordTextBox.Text.Length == 0) //same validation here
            {
                output = false;
            }

            return output;
        }
    }
}
