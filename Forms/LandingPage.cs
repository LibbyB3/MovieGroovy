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
    public partial class LandingPage : Form
    {
        public LandingPage()
        {
            InitializeComponent();
        }

        private void LandPgSearchMVButton_Click(object sender, EventArgs e)
        {
            SearchMovieForm frm = new SearchMovieForm();
            frm.Show();
            //this.Close();

        }

        private void LandPgCreateMVButton_Click(object sender, EventArgs e)
        {
            //GlobalConfig.Connection.CreateMovie(cm);
            //Application.Run(new createMovForm());
            
            createUserForm frm = new createUserForm();
            frm.Show();
            //this.Close();
        }
    }
}
