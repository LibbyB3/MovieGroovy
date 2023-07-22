using AppLibrary;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class SearchMovieForm : Form
    {
        public SearchMovieForm()
        {
            InitializeComponent(); //this initializes the form so that the code following will actually be used and popup
        }
        private void searchMoviesTextBox_TextChanged(object sender, EventArgs e)
        {
            //this is is mistake I made but if I delete it I am afraid that it will mess up the designer and so I'm just gonna keep it put
            //fyi it was a response that I wanted to happen when typing into the search bar but desided against it
        }

        private void searchMoviesButton_Click(object sender, EventArgs e) //the following will happen when the search button is clicked
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MovieAppCSC660"].ConnectionString)) //establishes the connection to the database
                {
                    if(sqlConnection.State == ConnectionState.Closed)
                        sqlConnection.Open(); //open the connection if it is closed

                    using(DataTable dt = new DataTable("Movie")) //the tutorial I watched recommended I create a new variable datatable; honestly I'm not sure why
                    {
                        string query;
                        SqlParameter parameter; 

                        if (int.TryParse(searchMoviesTextBox.Text, out int movieID)) //this is used for trying to search for a movie by its ID
                        {
                            query = "SELECT * FROM Movies WHERE MovieID = @MovieID"; //this is a SQL query that I am using here; probably could substitute with a trigger
                            parameter = new SqlParameter("@MovieID", SqlDbType.Int); //int is the datatype
                            parameter.Value = movieID;
                        }
                        else //this else will also search for a movie by title if the user does not enter an ID into the search testbox
                        {
                            query = "SELECT * FROM Movies WHERE Title LIKE @Title"; //again, another SQL query that will look through the Movies table for the specific title
                            parameter = new SqlParameter("@Title", SqlDbType.VarChar); //varchar is the datatype
                            parameter.Value = string.Format("%{0}%", searchMoviesTextBox.Text);
                        }
                        
                        using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
                        {
                            cmd.Parameters.Add(parameter);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            adapter.Fill(dt); //this will fill the datatable from earlier 
                            moviesDataGridView.DataSource = dt; //we want the datatable to be shown in the movie data grid on the form
                            moviesDataGridView.Refresh(); //this will also refresh the table for multiple searches
                            totalMoviesLabel.Text = $"Total Movies: {moviesDataGridView.RowCount}"; //this is what will show the number of total movies that relates to the specific searched item
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "An error occurred: ", MessageBoxButtons.OK, MessageBoxIcon.Error); //error messagebox if something is wrong
            }
        }

        private void searchMoviesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter
                searchMoviesButton.PerformClick();
        }

        private void allMoviesButton_Click(object sender, EventArgs e) //the following code is what will happen if the all movies button is clicked
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MovieAppCSC660"].ConnectionString)) //again, establishing connection
            {
                if (sqlConnection.State == ConnectionState.Closed)
                    sqlConnection.Open(); //also again, making sure the connection is open and if closed, opening it for us

                using (DataTable dt2 = new DataTable("Movie2")) //I decided to create a new datable for this action; not sure if I needed to since it is within its own private class 
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Movies", sqlConnection)) //SQL query to select all of the movies from the Movies table
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(dt2); //again, filling the datatable
                        moviesDataGridView.DataSource = dt2; //putting that filled datatable into the datagrid on the search movies form
                        totalMoviesLabel.Text = $"Total Movies: {moviesDataGridView.RowCount}"; //counting up all the movies in the database
                    }
                }
            }
        }

        private void newMovieButton_Click(object sender, EventArgs e)
        {
            createMovieForm frm = new createMovieForm();
            frm.Show();
        }
    }
}
