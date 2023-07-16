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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandingPageLoginButton_Click(object sender, EventArgs e)
        {
            loginForm frm = new loginForm();
            frm.Show();
            //this.Close();

        }

        private void LandingPageCreateUserButton_Click(object sender, EventArgs e)
        {
            createUserForm frm = new createUserForm();
            frm.Show();
            //this.Close();
        }
    }
}
