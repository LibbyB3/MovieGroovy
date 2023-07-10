using AppLibrary;
using MovieAppCSC660.Models;
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
    public partial class SearchMovieForm : Form
    {
        List<TitleModel> currentTitles = GlobalConfig.Connection.GetAllTitles();
        List<ReleaseYearModel> currentYears = GlobalConfig.Connection.GetAllYears();
        List<PrimaryDirectorModel> currentDirectors = GlobalConfig.Connection.GetAllDirectors();
        List<GenreModel> currentGenres = GlobalConfig.Connection.GetAllGenres();

        private void WireUP() //this connects the dropdown to be filled with info from DB
        {
            titleCB.DataSource = currentTitles;
            titleCB.DisplayMember = "createdTitle";

            yearCB.DataSource = currentYears;
            yearCB.DisplayMember = "Year";

            directorCB.DataSource = currentDirectors; 
            directorCB.DisplayMember = "createdDirector";

            genreCB.DataSource = currentGenres;
            genreCB.DisplayMember = "Genre";
        }
        public SearchMovieForm()
        {
            InitializeComponent();
            WireUP();
        }
    }
}
